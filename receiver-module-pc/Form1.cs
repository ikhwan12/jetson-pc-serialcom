
using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialReader
{
    public partial class MainForm : Form
    {

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        private const int MONITOR_ON = -1;
        private const int MONITOR_OFF = 2;
        private const int MONITOR_STANBY = 1;

        string dataOUT;
        string dataIn;

        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        /**
         * https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-sendmessagew
         */
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private void MainForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> portItems = new Dictionary<string, string>();

            string[] ports;  ports = SerialPort.GetPortNames();

            //Console.WriteLine("Searching Port");

            comPortCB.Items.AddRange(ports);

            dtrChB.Checked = false;
            serialPort1.DtrEnable = false;
            rtsChB.Checked = false;
            serialPort1.RtsEnable = false;
            writeChB.Checked = true;
            writeLineChB.Checked = false;
            sendBtn.Enabled = false;
            refreshChB.Checked = true;
        }

        private void ChangeStatus(bool connected)
        {
            if (!connected)
            {
                serialPort1.Close();
            }
            else
            {
                serialPort1.Open();
            }
            
            progressBar1.Value = connected ? 100 : 0;
            sendBtn.Enabled = connected ? true : false;
            comStatusLbl.Text = connected ? "ON" : "OFF";
            comStatusLbl.ForeColor = connected ? System.Drawing.Color.Green : System.Drawing.Color.Black;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comPortCB.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudRateCB.Text);
                serialPort1.DataBits = Convert.ToInt32(dataBitsCB.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsCB.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), parityBitsCB.Text);

                ChangeStatus(true);

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                ChangeStatus(false);
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = serialDataRT.Text;
                if (writeChB.Checked)
                {
                    serialPort1.Write(dataOUT);
                }
                else
                {
                    serialPort1.WriteLine(dataOUT);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (refreshChB.Checked)
            {
                receivedDataRT.Text = dataIn;
            }
            else
            {
                receivedDataRT.Text += dataIn;
            }
            string code = ConfigurationManager.AppSettings.Get(dataIn);
            if (dataIn != null)
            {
                SendMessage(this.Handle, WM_APPCOMMAND, this.Handle, new IntPtr(Convert.ToInt32(code, 16)));
            }
        }

        private void dtrChB_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.DtrEnable = dtrChB.Checked;
            if (dtrChB.Checked)
            {
                MessageBox.Show("DTR Enabled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rtsChB_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.RtsEnable = rtsChB.Checked;
            if (rtsChB.Checked)
            {
                MessageBox.Show("RTS Enabled!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearBtn1_Click(object sender, EventArgs e)
        {
            serialDataRT.Text = "";
        }

        private void writeLineChB_CheckedChanged(object sender, EventArgs e)
        {
            writeChB.Checked = !writeLineChB.Checked;
        }

        private void writeChB_CheckedChanged(object sender, EventArgs e)
        {
            writeLineChB.Checked = !writeChB.Checked;
        }

        private void clearBtn2_Click(object sender, EventArgs e)
        {
            receivedDataRT.Text = "";
        }

        private void refreshChB_CheckedChanged(object sender, EventArgs e)
        {
            appendChB.Checked = !refreshChB.Checked;
        }

        private void appendChB_CheckedChanged(object sender, EventArgs e)
        {
            refreshChB.Checked = !appendChB.Checked;
        }

        private void displayManagement(int state)
        {
            const int SC_MONITORPOWER = 0xF170;
            const int WM_SYSCOMMAND = 0x0112;
            SendMessage(this.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)state);
        }
    }
}



namespace SerialReader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtsChB = new System.Windows.Forms.CheckBox();
            this.dtrChB = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comStatusLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.closeBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.parityBitsCB = new System.Windows.Forms.ComboBox();
            this.stopBitsCB = new System.Windows.Forms.ComboBox();
            this.dataBitsCB = new System.Windows.Forms.ComboBox();
            this.baudRateCB = new System.Windows.Forms.ComboBox();
            this.comPortCB = new System.Windows.Forms.ComboBox();
            this.parityBitsLbl = new System.Windows.Forms.Label();
            this.stopBitsLbl = new System.Windows.Forms.Label();
            this.dataBitsLbl = new System.Windows.Forms.Label();
            this.baudRatelbl = new System.Windows.Forms.Label();
            this.comPortLbl = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.serialDataRT = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.receivedDataRT = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.writeChB = new System.Windows.Forms.CheckBox();
            this.writeLineChB = new System.Windows.Forms.CheckBox();
            this.clearBtn1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.appendChB = new System.Windows.Forms.CheckBox();
            this.refreshChB = new System.Windows.Forms.CheckBox();
            this.clearBtn2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtsChB);
            this.groupBox2.Controls.Add(this.dtrChB);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.parityBitsCB);
            this.groupBox2.Controls.Add(this.stopBitsCB);
            this.groupBox2.Controls.Add(this.dataBitsCB);
            this.groupBox2.Controls.Add(this.baudRateCB);
            this.groupBox2.Controls.Add(this.comPortCB);
            this.groupBox2.Controls.Add(this.parityBitsLbl);
            this.groupBox2.Controls.Add(this.stopBitsLbl);
            this.groupBox2.Controls.Add(this.dataBitsLbl);
            this.groupBox2.Controls.Add(this.baudRatelbl);
            this.groupBox2.Controls.Add(this.comPortLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 299);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Com Parameters";
            // 
            // rtsChB
            // 
            this.rtsChB.AutoSize = true;
            this.rtsChB.Location = new System.Drawing.Point(131, 171);
            this.rtsChB.Name = "rtsChB";
            this.rtsChB.Size = new System.Drawing.Size(103, 20);
            this.rtsChB.TabIndex = 13;
            this.rtsChB.Text = "RTS Enable";
            this.rtsChB.UseVisualStyleBackColor = true;
            this.rtsChB.CheckedChanged += new System.EventHandler(this.rtsChB_CheckedChanged);
            // 
            // dtrChB
            // 
            this.dtrChB.AutoSize = true;
            this.dtrChB.Location = new System.Drawing.Point(10, 171);
            this.dtrChB.Name = "dtrChB";
            this.dtrChB.Size = new System.Drawing.Size(104, 20);
            this.dtrChB.TabIndex = 12;
            this.dtrChB.Text = "DTR Enable";
            this.dtrChB.UseVisualStyleBackColor = true;
            this.dtrChB.CheckedChanged += new System.EventHandler(this.dtrChB_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comStatusLbl);
            this.groupBox6.Location = new System.Drawing.Point(167, 194);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(85, 89);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // comStatusLbl
            // 
            this.comStatusLbl.AutoSize = true;
            this.comStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comStatusLbl.Location = new System.Drawing.Point(10, 35);
            this.comStatusLbl.Name = "comStatusLbl";
            this.comStatusLbl.Size = new System.Drawing.Size(76, 36);
            this.comStatusLbl.TabIndex = 0;
            this.comStatusLbl.Text = "OFF";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.closeBtn);
            this.groupBox3.Controls.Add(this.openBtn);
            this.groupBox3.Location = new System.Drawing.Point(10, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 88);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 52);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(138, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(76, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(69, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(6, 12);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(64, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // parityBitsCB
            // 
            this.parityBitsCB.FormattingEnabled = true;
            this.parityBitsCB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.parityBitsCB.Location = new System.Drawing.Point(131, 133);
            this.parityBitsCB.Name = "parityBitsCB";
            this.parityBitsCB.Size = new System.Drawing.Size(121, 24);
            this.parityBitsCB.TabIndex = 9;
            this.parityBitsCB.Text = "None";
            // 
            // stopBitsCB
            // 
            this.stopBitsCB.FormattingEnabled = true;
            this.stopBitsCB.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopBitsCB.Location = new System.Drawing.Point(131, 105);
            this.stopBitsCB.Name = "stopBitsCB";
            this.stopBitsCB.Size = new System.Drawing.Size(121, 24);
            this.stopBitsCB.TabIndex = 8;
            this.stopBitsCB.Text = "One";
            // 
            // dataBitsCB
            // 
            this.dataBitsCB.FormattingEnabled = true;
            this.dataBitsCB.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.dataBitsCB.Location = new System.Drawing.Point(131, 76);
            this.dataBitsCB.Name = "dataBitsCB";
            this.dataBitsCB.Size = new System.Drawing.Size(121, 24);
            this.dataBitsCB.TabIndex = 7;
            this.dataBitsCB.Text = "8";
            // 
            // baudRateCB
            // 
            this.baudRateCB.FormattingEnabled = true;
            this.baudRateCB.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.baudRateCB.Location = new System.Drawing.Point(131, 49);
            this.baudRateCB.Name = "baudRateCB";
            this.baudRateCB.Size = new System.Drawing.Size(121, 24);
            this.baudRateCB.TabIndex = 6;
            this.baudRateCB.Text = "9600";
            // 
            // comPortCB
            // 
            this.comPortCB.FormattingEnabled = true;
            this.comPortCB.Location = new System.Drawing.Point(131, 22);
            this.comPortCB.Name = "comPortCB";
            this.comPortCB.Size = new System.Drawing.Size(121, 24);
            this.comPortCB.TabIndex = 5;
            // 
            // parityBitsLbl
            // 
            this.parityBitsLbl.AutoSize = true;
            this.parityBitsLbl.Location = new System.Drawing.Point(7, 136);
            this.parityBitsLbl.Name = "parityBitsLbl";
            this.parityBitsLbl.Size = new System.Drawing.Size(89, 16);
            this.parityBitsLbl.TabIndex = 4;
            this.parityBitsLbl.Text = "PARITY BITS";
            // 
            // stopBitsLbl
            // 
            this.stopBitsLbl.AutoSize = true;
            this.stopBitsLbl.Location = new System.Drawing.Point(6, 109);
            this.stopBitsLbl.Name = "stopBitsLbl";
            this.stopBitsLbl.Size = new System.Drawing.Size(77, 16);
            this.stopBitsLbl.TabIndex = 3;
            this.stopBitsLbl.Text = "STOP BITS";
            // 
            // dataBitsLbl
            // 
            this.dataBitsLbl.AutoSize = true;
            this.dataBitsLbl.Location = new System.Drawing.Point(7, 79);
            this.dataBitsLbl.Name = "dataBitsLbl";
            this.dataBitsLbl.Size = new System.Drawing.Size(77, 16);
            this.dataBitsLbl.TabIndex = 2;
            this.dataBitsLbl.Text = "DATA BITS";
            // 
            // baudRatelbl
            // 
            this.baudRatelbl.AutoSize = true;
            this.baudRatelbl.Location = new System.Drawing.Point(7, 52);
            this.baudRatelbl.Name = "baudRatelbl";
            this.baudRatelbl.Size = new System.Drawing.Size(85, 16);
            this.baudRatelbl.TabIndex = 1;
            this.baudRatelbl.Text = "BAUD RATE";
            // 
            // comPortLbl
            // 
            this.comPortLbl.AutoSize = true;
            this.comPortLbl.Location = new System.Drawing.Point(7, 25);
            this.comPortLbl.Name = "comPortLbl";
            this.comPortLbl.Size = new System.Drawing.Size(78, 16);
            this.comPortLbl.TabIndex = 0;
            this.comPortLbl.Text = "COM PORT";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(6, 200);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 40);
            this.sendBtn.TabIndex = 11;
            this.sendBtn.Text = "Send Data";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // serialDataRT
            // 
            this.serialDataRT.Location = new System.Drawing.Point(6, 22);
            this.serialDataRT.Name = "serialDataRT";
            this.serialDataRT.Size = new System.Drawing.Size(248, 166);
            this.serialDataRT.TabIndex = 1;
            this.serialDataRT.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // receivedDataRT
            // 
            this.receivedDataRT.Location = new System.Drawing.Point(6, 22);
            this.receivedDataRT.Name = "receivedDataRT";
            this.receivedDataRT.ReadOnly = true;
            this.receivedDataRT.Size = new System.Drawing.Size(255, 166);
            this.receivedDataRT.TabIndex = 2;
            this.receivedDataRT.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.clearBtn1);
            this.groupBox4.Controls.Add(this.sendBtn);
            this.groupBox4.Controls.Add(this.serialDataRT);
            this.groupBox4.Location = new System.Drawing.Point(282, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 299);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sender Control";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.writeChB);
            this.groupBox7.Controls.Add(this.writeLineChB);
            this.groupBox7.Location = new System.Drawing.Point(87, 201);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 82);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Write Mode";
            // 
            // writeChB
            // 
            this.writeChB.AutoSize = true;
            this.writeChB.Location = new System.Drawing.Point(7, 51);
            this.writeChB.Name = "writeChB";
            this.writeChB.Size = new System.Drawing.Size(60, 20);
            this.writeChB.TabIndex = 14;
            this.writeChB.Text = "Write";
            this.writeChB.UseVisualStyleBackColor = true;
            this.writeChB.CheckedChanged += new System.EventHandler(this.writeChB_CheckedChanged);
            // 
            // writeLineChB
            // 
            this.writeLineChB.AutoSize = true;
            this.writeLineChB.Location = new System.Drawing.Point(6, 23);
            this.writeLineChB.Name = "writeLineChB";
            this.writeLineChB.Size = new System.Drawing.Size(88, 20);
            this.writeLineChB.TabIndex = 13;
            this.writeLineChB.Text = "Write Line";
            this.writeLineChB.UseVisualStyleBackColor = true;
            this.writeLineChB.CheckedChanged += new System.EventHandler(this.writeLineChB_CheckedChanged);
            // 
            // clearBtn1
            // 
            this.clearBtn1.Location = new System.Drawing.Point(7, 246);
            this.clearBtn1.Name = "clearBtn1";
            this.clearBtn1.Size = new System.Drawing.Size(74, 36);
            this.clearBtn1.TabIndex = 12;
            this.clearBtn1.Text = "Clear";
            this.clearBtn1.UseVisualStyleBackColor = true;
            this.clearBtn1.Click += new System.EventHandler(this.clearBtn1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.clearBtn2);
            this.groupBox5.Controls.Add(this.receivedDataRT);
            this.groupBox5.Location = new System.Drawing.Point(550, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 299);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receiver Control";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.appendChB);
            this.groupBox8.Controls.Add(this.refreshChB);
            this.groupBox8.Location = new System.Drawing.Point(99, 203);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(162, 79);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Read Mode";
            // 
            // appendChB
            // 
            this.appendChB.AutoSize = true;
            this.appendChB.Location = new System.Drawing.Point(7, 48);
            this.appendChB.Name = "appendChB";
            this.appendChB.Size = new System.Drawing.Size(109, 20);
            this.appendChB.TabIndex = 1;
            this.appendChB.Text = "Append Data";
            this.appendChB.UseVisualStyleBackColor = true;
            this.appendChB.CheckedChanged += new System.EventHandler(this.appendChB_CheckedChanged);
            // 
            // refreshChB
            // 
            this.refreshChB.AutoSize = true;
            this.refreshChB.Location = new System.Drawing.Point(7, 21);
            this.refreshChB.Name = "refreshChB";
            this.refreshChB.Size = new System.Drawing.Size(108, 20);
            this.refreshChB.TabIndex = 0;
            this.refreshChB.Text = "Refresh Data";
            this.refreshChB.UseVisualStyleBackColor = true;
            this.refreshChB.CheckedChanged += new System.EventHandler(this.refreshChB_CheckedChanged);
            // 
            // clearBtn2
            // 
            this.clearBtn2.Location = new System.Drawing.Point(6, 229);
            this.clearBtn2.Name = "clearBtn2";
            this.clearBtn2.Size = new System.Drawing.Size(75, 29);
            this.clearBtn2.TabIndex = 3;
            this.clearBtn2.Text = "Clear";
            this.clearBtn2.UseVisualStyleBackColor = true;
            this.clearBtn2.Click += new System.EventHandler(this.clearBtn2_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(831, 320);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findComBtn;
        private System.Windows.Forms.ComboBox portItemCB;
        private System.Windows.Forms.Button sendDataBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.ComboBox parityBitsCB;
        private System.Windows.Forms.ComboBox stopBitsCB;
        private System.Windows.Forms.ComboBox dataBitsCB;
        private System.Windows.Forms.ComboBox baudRateCB;
        private System.Windows.Forms.ComboBox comPortCB;
        private System.Windows.Forms.Label parityBitsLbl;
        private System.Windows.Forms.Label stopBitsLbl;
        private System.Windows.Forms.Label dataBitsLbl;
        private System.Windows.Forms.Label baudRatelbl;
        private System.Windows.Forms.Label comPortLbl;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox serialDataRT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox receivedDataRT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label comStatusLbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearBtn1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox rtsChB;
        private System.Windows.Forms.CheckBox dtrChB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox writeChB;
        private System.Windows.Forms.CheckBox writeLineChB;
        private System.Windows.Forms.Button clearBtn2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox appendChB;
        private System.Windows.Forms.CheckBox refreshChB;
    }
}


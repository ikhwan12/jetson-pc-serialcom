using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialReader
{
    internal class AppCommand
    {
        public IntPtr Message { get; set; }
        public IntPtr WParam { get; set; }
        public IntPtr LParam { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_winAPI
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr HWnd, string Text, string Caption, int Option);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        IntPtr ptr = IntPtr.Zero;
        const uint WM_SETTEXT = 0x000C;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        [DllImport("user32.dll")]

        public static extern bool MessageBeep(uint uType);
        public Form1()
        {
            InitializeComponent();
        }

        private void b_call_mess_box_Click(object sender, EventArgs e)
        {
            string mashinInfo ="computer name: " +SystemInformation.ComputerName+
                "\n\ruser name: "+SystemInformation.UserName+"\n\roperation system: "+Environment.OSVersion.ToString()+
                "\n\rmodel processor: "+ Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            MessageBox(IntPtr.Zero, mashinInfo, "Информация о компьютере", 1);
            MessageBox(IntPtr.Zero, mashinInfo, "Второй message box  по заданию", 1);
        }

        private void b_searchWin_Click(object sender, EventArgs e)
        {
            IntPtr ptr = FindWindow(null, tb_nameFindWin.Text);
            if (ptr != IntPtr.Zero)
            {
                if (MessageBox(IntPtr.Zero, "хотите поменять заголовок?", "окно найденно", 4) == 6)
                    b_mess.Enabled = true;
                else
                    return;
            }
        }

        private void b_mess_Click(object sender, EventArgs e)
        {
            IntPtr ptr = FindWindow(null, tb_nameFindWin.Text);
            SendMessage(ptr, WM_SETTEXT, IntPtr.Zero, Marshal.StringToBSTR(tb_messToWin.Text));
        }

        private void b_playing_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            MessageBeep((uint)0x00000040L);
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {
                Beep(random.Next(400, 700), random.Next(5, 20) * 10);
            }
        }
    }
}

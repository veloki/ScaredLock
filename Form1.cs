using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point = new Point();

            bool result = WindowsAPI.GetCursorPos(ref point);

            int x = point.X;
            int y = point.Y;
            while (true)
            {
                WindowsAPI.GetCursorPos(ref point);
                if (x != point.X)
                {
                    Form2 m = new Form2();
                    m.Show();
                    break;
                }
            }

        }

        public class WindowsAPI
        {
            [DllImport("user32.dll")]
            public static extern bool GetCursorPos(ref Point pt);
        }
    }

}

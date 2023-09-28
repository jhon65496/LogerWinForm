using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogerWinForm
{
    public partial class Form1 : Form
    {
        Loger loger;
        public Form1()
        {
            InitializeComponent();
            loger = new Loger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log();
        }


        public void Log()
        {
            loger.Log(" ");
            loger.Log("=== === === === === === === === === === === === === === ===");
            loger.Log("Класс Program. Main() === === === === === === === === === ===");
        }
    }
}

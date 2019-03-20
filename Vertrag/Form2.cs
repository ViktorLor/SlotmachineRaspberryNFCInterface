using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
			btn_oke.Text = "bestätigen";
			lbl_age.Text = Program.name + " " + Program.surname + " ist zu jung!";
            //doesnt load probably
            /*this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
        }

        private void btn_oke_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}


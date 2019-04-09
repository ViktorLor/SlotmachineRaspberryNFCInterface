using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prototype
{
    public partial class Form3 : Form
    {
        string rescan_id;

        public Form3()
        {
            InitializeComponent();
            lbl_information.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Bold);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
			this.Activated += AfterLoading;
			this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            Application.DoEvents();
            this.Hide();
            this.Show();
            this.Activated -= AfterLoading;
            rescan_id = Form1.NFC_in();
            if (Program.UID == rescan_id)
            {
                Protokoll.BookData();
                if (File.Exists(Program.filepathSend + "cmdbook.txt"))
                	File.Delete(Program.filepathSend + "cmdbook.txt");
                lbl_information.Text = "kauf abgeschlossen";
				Form1.automat(Form1.number);

				Form1.wait(2000);
                this.Close();
            }
            else
            {
                lbl_information.Text = "Abbruch";
                Form1.wait(2000);
                this.Close();
            }
        }
    }
}


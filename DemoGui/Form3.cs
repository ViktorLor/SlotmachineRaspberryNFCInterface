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
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.Activated += AfterLoading;
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            Application.DoEvents();
            this.Hide();
            this.Show();
            this.Activated -= AfterLoading;
            rescan_id = Form2.NFC_in();
            if (Form2.UID == rescan_id)
            {
                //Protokoll.BookData(Protokoll.ipadress, Protokoll.port);
                //if (File.Exists(Program.filepath + "SendData/cmdbook.txt"))
                //	File.Delete(Program.filepath + "SendData/cmdbook.txt");
                lbl_information.Text = "kauf abgeschlossen";
                //send to automat
                //wait for automat finished
                wait(2000);                 //wait for 2000 ms
                this.Close();               //fenster schließen
            }
            else
            {
                lbl_information.Text = "Abbruch";
                wait(2000);                 //wait for 2000 ms
                this.Close();               //fenster schließen
            }
        }

        public static void wait(int min)       //wait funktion
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (min == 0 || min < 0) return;
            timer1.Interval = min;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}


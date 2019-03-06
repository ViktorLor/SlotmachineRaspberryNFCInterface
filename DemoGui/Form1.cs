using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
	public partial class Form1 : Form
	{
		public static int cnt = 1;
		public static string productID;

		List<Product> productList = new List<Product>();        //liste zur anzeige der produkte
		string name, surname, UID;
		double price, fullprice;
		int age_rating;

		public Form1()
		{
			InitializeComponent();
			lb_productList.Font = new Font("Microsoft Sans Serif", 12);
			lbl_product.Font = new Font("Microsoft Sans Serif", 10);
			lbl_productPrice.Font = new Font("Microsoft Sans Serif", 10);
			lbl_count.Font = new Font("Microsoft Sans Serif", 10);
			lbl_fullPrice.Font = new Font("Microsoft Sans Serif", 10);
			lbl_displayProductName.Font = new Font("Microsoft Sans Serif", 10);
			lbl_displayPrice.Font = new Font("Microsoft Sans Serif", 10);
			lbl_displayCount.Font = new Font("Microsoft Sans Serif", 10);
			lbl_displayFullPrice.Font = new Font("Microsoft Sans Serif", 10);
			lbl_user.Font = new Font("Microsoft Sans Serif", 10);
			btn_cancel.Font = new Font("Microsoft Sans Serif", 10);
			btn_confirm.Font = new Font("Microsoft Sans Serif", 10);
			UID = Form2.UID;
			name = Form2.name;
			surname = Form2.surname;

			lbl_displayFullPrice.Text = lbl_displayPrice.Text;
			btn_confirm.Enabled = false;

			string text = File.ReadAllText(Program.filepath + "Test_data.txt", Encoding.UTF8);          //einlesen der datenbank(produktliste
			string[] lines = File.ReadAllLines(Program.filepath + "Test_data.txt", Encoding.UTF8);      //trennen in die einzelnen zeilen
			foreach (string line in lines)
			{
				string[] atributes = line.Split('/');       //jede zeile in die einzelnen bestandteile zerlegen (produktID/name/preis)  "/" als trennzeichen
				Product p = new Product();
				p.id = atributes[0];                                    //atribute der einzelnen produkte aus der datenbank in die eigene liste einfügen
				p.name = atributes[1];
				double.TryParse(atributes[2], out p.price);             //den produktpreis aus der datenbank in einen double wert parsen
				p.price = p.price / 100; 
				int.TryParse(atributes[3],  out age_rating);
				if (age_rating > Form2.age) { }				//auf mindestalter prüfen
				else
					productList.Add(p);						//produkte zur liste hinzufügen
			}

			lb_productList.Items.AddRange(productList.ToArray());       //produktliste wird in der listbox angezeigt

			lb_productList.SetSelected(0, true);

			lbl_user.Text = surname + " " + name + " ";           //aktuellen benutzer anzeigen
			lbl_bill.Text = string.Format("{0:F2}", Form2.saldo);
			lbl_limit.Text = string.Format("{0:F2}", Form2.limit);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
		}

		private void lbl_displayProductName_Click(object sender, EventArgs e)
		{

		}

		private void lbl_displayPrice_Click(object sender, EventArgs e)
		{

		}

		private void lbl_displayCount_Click(object sender, EventArgs e)
		{

		}

		private void lbl_displayFullPrice_Click(object sender, EventArgs e)
		{

		}

		private void lbl_user_Click(object sender, EventArgs e)
		{

		}

		private void lbl_bill_Click(object sender, EventArgs e)
		{

		}

		private void btn_plus_Click(object sender, EventArgs e)     //erhöht den zählerwert um 1
		{
			int i;
			int.TryParse(lbl_displayCount.Text, out i);             //den eingestellten zählerwert in einen integer wert parsen
			double.TryParse(lbl_displayPrice.Text, out price);      //den produktpreis in einen double wert parsen
			//price = price / 100;
			i++;
			fullprice = i * price;
			if (fullprice + Form2.saldo > Form2.limit)
			{
				i--;
				fullprice = i * price;
			}
			lbl_displayCount.Text = "" + i;
			lbl_displayFullPrice.Text = string.Format("{0:F2}", fullprice);     //zeigt den gesammtpreis mit zwei dezimalstellen an
			cnt = i;
		}

		private void btn_minus_Click(object sender, EventArgs e)    //verringert den zählwert um 1
		{
			int i;
			int.TryParse(lbl_displayCount.Text, out i);             //den eingestellten zählerwert in einen integer wert parsen
			double.TryParse(lbl_displayPrice.Text, out price);      //den produktpreis in einen double wert parsen
			if (i > 1)                                              //prüfen auf kleiner 1 (0 bestellen nicht möglich)
				i--;
			lbl_displayCount.Text = "" + i;
			//price = price / 100;
			fullprice = i * price;
			lbl_displayFullPrice.Text = string.Format("{0:F2}", fullprice);     //zeigt den gesammtpreis mit zwei dezimalstellen an
			cnt = i;
		}

		private void btn_confirm_Click(object sender, EventArgs e)      //info fenster öffnen und dieses fenster schließen
		{
			writeData();
			Form3 frm = new Form3();
			frm.Location = this.Location;
			frm.StartPosition = FormStartPosition.Manual;
			frm.ShowDialog();
			this.Hide();
			this.Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e)       //schließen des aktuellen fensters
		{
			this.Hide();
			this.Close();
		}

		private void lb_productList_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < productList.Count; i++)             //nur ein produkt gleichzeitig auswählbar
			{
				if (lb_productList.GetItemChecked(i))
				{
					lb_productList.SetItemChecked(i, false);
				}
			}
			try                                                     //falls index = -1 (wenn ins leere gedrückt wird)
			{
				lb_productList.SetItemChecked(lb_productList.SelectedIndex, true);
				btn_confirm.Enabled = true;
			}
			catch { }

			for (int i = 0; i < productList.Count; i++)
			{
				if (lb_productList.GetItemChecked(i))
				{
					lbl_displayPrice.Text = string.Format("{0:F2}", productList[i].price);      //preis des gewählten produktes mit zwei dezimalstellen ausgeben
					lbl_displayPrice.Text = lbl_displayPrice.Text;
					lbl_displayProductName.Text = productList[i].name;                          //name des gewählten produktes ausgeben
					int j;
					int.TryParse(lbl_displayCount.Text, out j);                                 //den eingestellten zählerwert in einen integer wert parsen
					double.TryParse(lbl_displayPrice.Text, out price);
					//price = price / 100;														//den produktpreis in einen double wert parsen
					fullprice = j * price;
					while (fullprice + Form2.saldo > Form2.limit)
					{
						j--;
						fullprice = j * price;
					}
					lbl_displayCount.Text = "" + j;
					lbl_displayFullPrice.Text = string.Format("{0:F2}", fullprice);             //zeigt den gesammtpreis mit zwei dezimalstellen an
				}
			}
		}

		public class Product
		{       //erstellen einer klasse (Product) womit die liste befüllt wird
			public string id;
			public string name;
			public double price;

			public override string ToString()
			{
				return name;
			}
		}

		private void writeData()
		{
			string fileName = "cmdbook.txt";							//template filename
			string targetPath = Program.filepath + "SendData/";					//ziel pfad

			string sourceFile = System.IO.Path.Combine(Program.filepath, fileName);					//pfad zum template file erstellen
			string targetFile = System.IO.Path.Combine(targetPath, fileName);                       //ziel pfad erstellen

			string text = File.ReadAllText(sourceFile);                                             //template file einlesen
			text = text.Replace("%uid%", UID);                                                      //daten eintragen
			for (int i = 0; i < productList.Count; i++)
			{
				if (lb_productList.GetItemChecked(i))
				{
					text = text.Replace("%nr%", productList[i].id);                                 //daten eintragen
				}
			}
			text = text.Replace("%cnt%", cnt.ToString());                                           //daten eintragen
			File.WriteAllText(targetFile, text);                                                    //neues file mit eingetragenen daten im zielordner erstellen
		}
	}
}


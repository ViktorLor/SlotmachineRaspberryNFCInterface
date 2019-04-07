namespace Prototype
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_name = new System.Windows.Forms.Label();
			this.lbl_gesamtanzahl = new System.Windows.Forms.Label();
			this.lbl_display_fullcnt = new System.Windows.Forms.Label();
			this.lbl_freegame = new System.Windows.Forms.Label();
			this.lbl_anz = new System.Windows.Forms.Label();
			this.lbl_free = new System.Windows.Forms.Label();
			this.btn_minus = new System.Windows.Forms.Button();
			this.btn_plus = new System.Windows.Forms.Button();
			this.lbl_price = new System.Windows.Forms.Label();
			this.lbl_fullprice = new System.Windows.Forms.Label();
			this.lbl_unit = new System.Windows.Forms.Label();
			this.lbl_confirm = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.lbl_user = new System.Windows.Forms.Label();
			this.lbl_display_sal = new System.Windows.Forms.Label();
			this.lbl_saldo = new System.Windows.Forms.Label();
			this.lbl_display_limit = new System.Windows.Forms.Label();
			this.lbl_limit = new System.Windows.Forms.Label();
			this.lbl_unit1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_name.Location = new System.Drawing.Point(12, 9);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(168, 31);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Boxautomat";
			// 
			// lbl_gesamtanzahl
			// 
			this.lbl_gesamtanzahl.AutoSize = true;
			this.lbl_gesamtanzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_gesamtanzahl.Location = new System.Drawing.Point(12, 159);
			this.lbl_gesamtanzahl.Name = "lbl_gesamtanzahl";
			this.lbl_gesamtanzahl.Size = new System.Drawing.Size(130, 20);
			this.lbl_gesamtanzahl.TabIndex = 1;
			this.lbl_gesamtanzahl.Text = "Gesamtanzahl:";
			// 
			// lbl_display_fullcnt
			// 
			this.lbl_display_fullcnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_display_fullcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_display_fullcnt.Location = new System.Drawing.Point(172, 153);
			this.lbl_display_fullcnt.Name = "lbl_display_fullcnt";
			this.lbl_display_fullcnt.Size = new System.Drawing.Size(57, 33);
			this.lbl_display_fullcnt.TabIndex = 2;
			this.lbl_display_fullcnt.Text = "1";
			this.lbl_display_fullcnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_freegame
			// 
			this.lbl_freegame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_freegame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_freegame.Location = new System.Drawing.Point(172, 110);
			this.lbl_freegame.Name = "lbl_freegame";
			this.lbl_freegame.Size = new System.Drawing.Size(57, 33);
			this.lbl_freegame.TabIndex = 3;
			this.lbl_freegame.Text = "0";
			this.lbl_freegame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_anz
			// 
			this.lbl_anz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_anz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_anz.Location = new System.Drawing.Point(172, 69);
			this.lbl_anz.Name = "lbl_anz";
			this.lbl_anz.Size = new System.Drawing.Size(57, 33);
			this.lbl_anz.TabIndex = 4;
			this.lbl_anz.Text = "1";
			this.lbl_anz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_free
			// 
			this.lbl_free.AutoSize = true;
			this.lbl_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_free.Location = new System.Drawing.Point(12, 116);
			this.lbl_free.Name = "lbl_free";
			this.lbl_free.Size = new System.Drawing.Size(110, 20);
			this.lbl_free.TabIndex = 5;
			this.lbl_free.Text = "Gratisspiele:";
			// 
			// btn_minus
			// 
			this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_minus.Location = new System.Drawing.Point(129, 69);
			this.btn_minus.Name = "btn_minus";
			this.btn_minus.Size = new System.Drawing.Size(37, 33);
			this.btn_minus.TabIndex = 6;
			this.btn_minus.Text = "-";
			this.btn_minus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_minus.UseVisualStyleBackColor = true;
			this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
			// 
			// btn_plus
			// 
			this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_plus.Location = new System.Drawing.Point(235, 69);
			this.btn_plus.Name = "btn_plus";
			this.btn_plus.Size = new System.Drawing.Size(37, 33);
			this.btn_plus.TabIndex = 7;
			this.btn_plus.Text = "+";
			this.btn_plus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_plus.UseVisualStyleBackColor = true;
			this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
			// 
			// lbl_price
			// 
			this.lbl_price.AutoSize = true;
			this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_price.Location = new System.Drawing.Point(12, 203);
			this.lbl_price.Name = "lbl_price";
			this.lbl_price.Size = new System.Drawing.Size(116, 20);
			this.lbl_price.TabIndex = 8;
			this.lbl_price.Text = "Gesamtpreis:";
			// 
			// lbl_fullprice
			// 
			this.lbl_fullprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_fullprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_fullprice.Location = new System.Drawing.Point(172, 197);
			this.lbl_fullprice.Name = "lbl_fullprice";
			this.lbl_fullprice.Size = new System.Drawing.Size(57, 33);
			this.lbl_fullprice.TabIndex = 9;
			this.lbl_fullprice.Text = "0,50";
			this.lbl_fullprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_unit
			// 
			this.lbl_unit.AutoSize = true;
			this.lbl_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_unit.Location = new System.Drawing.Point(235, 203);
			this.lbl_unit.Name = "lbl_unit";
			this.lbl_unit.Size = new System.Drawing.Size(18, 20);
			this.lbl_unit.TabIndex = 10;
			this.lbl_unit.Text = "€";
			// 
			// lbl_confirm
			// 
			this.lbl_confirm.AutoSize = true;
			this.lbl_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_confirm.Location = new System.Drawing.Point(204, 252);
			this.lbl_confirm.Name = "lbl_confirm";
			this.lbl_confirm.Size = new System.Drawing.Size(198, 20);
			this.lbl_confirm.TabIndex = 11;
			this.lbl_confirm.Text = "Mit NFC-Scan bezahlen";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Location = new System.Drawing.Point(12, 243);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(129, 29);
			this.btn_cancel.TabIndex = 12;
			this.btn_cancel.Text = "Abbruch";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// lbl_user
			// 
			this.lbl_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_user.Location = new System.Drawing.Point(225, 9);
			this.lbl_user.Name = "lbl_user";
			this.lbl_user.Size = new System.Drawing.Size(177, 23);
			this.lbl_user.TabIndex = 13;
			this.lbl_user.Text = "Max Mustermann";
			this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_user.UseMnemonic = false;
			// 
			// lbl_display_sal
			// 
			this.lbl_display_sal.AutoSize = true;
			this.lbl_display_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_display_sal.Location = new System.Drawing.Point(315, 53);
			this.lbl_display_sal.Name = "lbl_display_sal";
			this.lbl_display_sal.Size = new System.Drawing.Size(72, 16);
			this.lbl_display_sal.TabIndex = 14;
			this.lbl_display_sal.Text = "Rechnung:";
			// 
			// lbl_saldo
			// 
			this.lbl_saldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_saldo.Location = new System.Drawing.Point(314, 69);
			this.lbl_saldo.Name = "lbl_saldo";
			this.lbl_saldo.Size = new System.Drawing.Size(73, 23);
			this.lbl_saldo.TabIndex = 15;
			this.lbl_saldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_display_limit
			// 
			this.lbl_display_limit.AutoSize = true;
			this.lbl_display_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_display_limit.Location = new System.Drawing.Point(349, 110);
			this.lbl_display_limit.Name = "lbl_display_limit";
			this.lbl_display_limit.Size = new System.Drawing.Size(38, 16);
			this.lbl_display_limit.TabIndex = 16;
			this.lbl_display_limit.Text = "Limit:";
			// 
			// lbl_limit
			// 
			this.lbl_limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_limit.Location = new System.Drawing.Point(314, 126);
			this.lbl_limit.Name = "lbl_limit";
			this.lbl_limit.Size = new System.Drawing.Size(73, 23);
			this.lbl_limit.TabIndex = 17;
			this.lbl_limit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_unit1
			// 
			this.lbl_unit1.AutoSize = true;
			this.lbl_unit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_unit1.Location = new System.Drawing.Point(387, 72);
			this.lbl_unit1.Name = "lbl_unit1";
			this.lbl_unit1.Size = new System.Drawing.Size(15, 16);
			this.lbl_unit1.TabIndex = 18;
			this.lbl_unit1.Text = "€";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(387, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "€";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 281);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_unit1);
			this.Controls.Add(this.lbl_limit);
			this.Controls.Add(this.lbl_display_limit);
			this.Controls.Add(this.lbl_saldo);
			this.Controls.Add(this.lbl_display_sal);
			this.Controls.Add(this.lbl_user);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.lbl_confirm);
			this.Controls.Add(this.lbl_unit);
			this.Controls.Add(this.lbl_fullprice);
			this.Controls.Add(this.lbl_price);
			this.Controls.Add(this.btn_plus);
			this.Controls.Add(this.btn_minus);
			this.Controls.Add(this.lbl_free);
			this.Controls.Add(this.lbl_anz);
			this.Controls.Add(this.lbl_freegame);
			this.Controls.Add(this.lbl_display_fullcnt);
			this.Controls.Add(this.lbl_gesamtanzahl);
			this.Controls.Add(this.lbl_name);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "[T]";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Label lbl_gesamtanzahl;
		private System.Windows.Forms.Label lbl_display_fullcnt;
		private System.Windows.Forms.Label lbl_freegame;
		private System.Windows.Forms.Label lbl_anz;
		private System.Windows.Forms.Label lbl_free;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Label lbl_price;
		private System.Windows.Forms.Label lbl_fullprice;
		private System.Windows.Forms.Label lbl_unit;
		private System.Windows.Forms.Label lbl_confirm;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_display_sal;
		private System.Windows.Forms.Label lbl_saldo;
		private System.Windows.Forms.Label lbl_display_limit;
		private System.Windows.Forms.Label lbl_limit;
		private System.Windows.Forms.Label lbl_unit1;
		private System.Windows.Forms.Label label1;
	}
}


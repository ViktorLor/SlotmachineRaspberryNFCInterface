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
			this.lbl_user = new System.Windows.Forms.Label();
			this.lbl_product = new System.Windows.Forms.Label();
			this.lbl_displayProductName = new System.Windows.Forms.Label();
			this.lbl_productPrice = new System.Windows.Forms.Label();
			this.lbl_displayPrice = new System.Windows.Forms.Label();
			this.lbl_count = new System.Windows.Forms.Label();
			this.lbl_displayCount = new System.Windows.Forms.Label();
			this.btn_minus = new System.Windows.Forms.Button();
			this.btn_plus = new System.Windows.Forms.Button();
			this.lbl_fullPrice = new System.Windows.Forms.Label();
			this.lbl_displayFullPrice = new System.Windows.Forms.Label();
			this.btn_confirm = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.lbl_unit1 = new System.Windows.Forms.Label();
			this.lbl_unit2 = new System.Windows.Forms.Label();
			this.lb_productList = new System.Windows.Forms.CheckedListBox();
			this.lbl_bill = new System.Windows.Forms.Label();
			this.lbl_unit3 = new System.Windows.Forms.Label();
			this.lbl_billinfo = new System.Windows.Forms.Label();
			this.lbl_InfoLimit = new System.Windows.Forms.Label();
			this.lbl_limit = new System.Windows.Forms.Label();
			this.lbl_unit4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_user
			// 
			this.lbl_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_user.Location = new System.Drawing.Point(272, 7);
			this.lbl_user.Name = "lbl_user";
			this.lbl_user.Size = new System.Drawing.Size(130, 22);
			this.lbl_user.TabIndex = 0;
			this.lbl_user.Text = "User_Name ";
			this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
			// 
			// lbl_product
			// 
			this.lbl_product.AutoSize = true;
			this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_product.Location = new System.Drawing.Point(10, 27);
			this.lbl_product.Name = "lbl_product";
			this.lbl_product.Size = new System.Drawing.Size(57, 16);
			this.lbl_product.TabIndex = 1;
			this.lbl_product.Text = "Produkt:";
			// 
			// lbl_displayProductName
			// 
			this.lbl_displayProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_displayProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_displayProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_displayProductName.Location = new System.Drawing.Point(94, 24);
			this.lbl_displayProductName.Name = "lbl_displayProductName";
			this.lbl_displayProductName.Size = new System.Drawing.Size(83, 22);
			this.lbl_displayProductName.TabIndex = 2;
			this.lbl_displayProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_displayProductName.Click += new System.EventHandler(this.lbl_displayProductName_Click);
			// 
			// lbl_productPrice
			// 
			this.lbl_productPrice.AutoSize = true;
			this.lbl_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_productPrice.Location = new System.Drawing.Point(10, 51);
			this.lbl_productPrice.Name = "lbl_productPrice";
			this.lbl_productPrice.Size = new System.Drawing.Size(87, 16);
			this.lbl_productPrice.TabIndex = 3;
			this.lbl_productPrice.Text = "Produktpreis:";
			// 
			// lbl_displayPrice
			// 
			this.lbl_displayPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_displayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_displayPrice.Location = new System.Drawing.Point(123, 50);
			this.lbl_displayPrice.Name = "lbl_displayPrice";
			this.lbl_displayPrice.Size = new System.Drawing.Size(54, 17);
			this.lbl_displayPrice.TabIndex = 4;
			this.lbl_displayPrice.Text = "0,00";
			this.lbl_displayPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_displayPrice.Click += new System.EventHandler(this.lbl_displayPrice_Click);
			// 
			// lbl_count
			// 
			this.lbl_count.AutoSize = true;
			this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_count.Location = new System.Drawing.Point(10, 231);
			this.lbl_count.Name = "lbl_count";
			this.lbl_count.Size = new System.Drawing.Size(51, 16);
			this.lbl_count.TabIndex = 5;
			this.lbl_count.Text = "Anzahl:";
			// 
			// lbl_displayCount
			// 
			this.lbl_displayCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_displayCount.Location = new System.Drawing.Point(124, 227);
			this.lbl_displayCount.Name = "lbl_displayCount";
			this.lbl_displayCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_displayCount.Size = new System.Drawing.Size(30, 24);
			this.lbl_displayCount.TabIndex = 6;
			this.lbl_displayCount.Text = "1";
			this.lbl_displayCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_displayCount.Click += new System.EventHandler(this.lbl_displayCount_Click);
			// 
			// btn_minus
			// 
			this.btn_minus.Location = new System.Drawing.Point(94, 226);
			this.btn_minus.Name = "btn_minus";
			this.btn_minus.Size = new System.Drawing.Size(24, 24);
			this.btn_minus.TabIndex = 7;
			this.btn_minus.Text = "-";
			this.btn_minus.UseVisualStyleBackColor = true;
			this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
			// 
			// btn_plus
			// 
			this.btn_plus.Location = new System.Drawing.Point(160, 227);
			this.btn_plus.Name = "btn_plus";
			this.btn_plus.Size = new System.Drawing.Size(24, 24);
			this.btn_plus.TabIndex = 8;
			this.btn_plus.Text = "+";
			this.btn_plus.UseVisualStyleBackColor = true;
			this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
			// 
			// lbl_fullPrice
			// 
			this.lbl_fullPrice.AutoSize = true;
			this.lbl_fullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_fullPrice.Location = new System.Drawing.Point(10, 253);
			this.lbl_fullPrice.Name = "lbl_fullPrice";
			this.lbl_fullPrice.Size = new System.Drawing.Size(88, 16);
			this.lbl_fullPrice.TabIndex = 9;
			this.lbl_fullPrice.Text = "Gesamtpreis:";
			// 
			// lbl_displayFullPrice
			// 
			this.lbl_displayFullPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_displayFullPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_displayFullPrice.Location = new System.Drawing.Point(123, 253);
			this.lbl_displayFullPrice.Name = "lbl_displayFullPrice";
			this.lbl_displayFullPrice.Size = new System.Drawing.Size(54, 16);
			this.lbl_displayFullPrice.TabIndex = 10;
			this.lbl_displayFullPrice.Text = "0.00";
			this.lbl_displayFullPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lbl_displayFullPrice.Click += new System.EventHandler(this.lbl_displayFullPrice_Click);
			// 
			// btn_confirm
			// 
			this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_confirm.Location = new System.Drawing.Point(314, 242);
			this.btn_confirm.Name = "btn_confirm";
			this.btn_confirm.Size = new System.Drawing.Size(88, 27);
			this.btn_confirm.TabIndex = 11;
			this.btn_confirm.Text = "Bestätigen";
			this.btn_confirm.UseVisualStyleBackColor = true;
			this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Location = new System.Drawing.Point(221, 242);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(87, 27);
			this.btn_cancel.TabIndex = 12;
			this.btn_cancel.Text = "Abbrechen";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// lbl_unit1
			// 
			this.lbl_unit1.AutoSize = true;
			this.lbl_unit1.Location = new System.Drawing.Point(175, 52);
			this.lbl_unit1.Name = "lbl_unit1";
			this.lbl_unit1.Size = new System.Drawing.Size(13, 13);
			this.lbl_unit1.TabIndex = 13;
			this.lbl_unit1.Text = "€";
			// 
			// lbl_unit2
			// 
			this.lbl_unit2.AutoSize = true;
			this.lbl_unit2.Location = new System.Drawing.Point(175, 255);
			this.lbl_unit2.Name = "lbl_unit2";
			this.lbl_unit2.Size = new System.Drawing.Size(13, 13);
			this.lbl_unit2.TabIndex = 14;
			this.lbl_unit2.Text = "€";
			// 
			// lb_productList
			// 
			this.lb_productList.CheckOnClick = true;
			this.lb_productList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_productList.FormattingEnabled = true;
			this.lb_productList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lb_productList.Location = new System.Drawing.Point(13, 70);
			this.lb_productList.Name = "lb_productList";
			this.lb_productList.Size = new System.Drawing.Size(389, 151);
			this.lb_productList.TabIndex = 15;
			this.lb_productList.SelectedIndexChanged += new System.EventHandler(this.lb_productList_SelectedIndexChanged);
			// 
			// lbl_bill
			// 
			this.lbl_bill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_bill.Location = new System.Drawing.Point(332, 31);
			this.lbl_bill.Name = "lbl_bill";
			this.lbl_bill.Size = new System.Drawing.Size(62, 17);
			this.lbl_bill.TabIndex = 16;
			this.lbl_bill.Text = "0.00";
			this.lbl_bill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_bill.Click += new System.EventHandler(this.lbl_bill_Click);
			// 
			// lbl_unit3
			// 
			this.lbl_unit3.AutoSize = true;
			this.lbl_unit3.Location = new System.Drawing.Point(389, 33);
			this.lbl_unit3.Name = "lbl_unit3";
			this.lbl_unit3.Size = new System.Drawing.Size(13, 13);
			this.lbl_unit3.TabIndex = 17;
			this.lbl_unit3.Text = "€";
			// 
			// lbl_billinfo
			// 
			this.lbl_billinfo.AutoSize = true;
			this.lbl_billinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_billinfo.Location = new System.Drawing.Point(244, 29);
			this.lbl_billinfo.Name = "lbl_billinfo";
			this.lbl_billinfo.Size = new System.Drawing.Size(72, 16);
			this.lbl_billinfo.TabIndex = 18;
			this.lbl_billinfo.Text = "Rechnung:";
			this.lbl_billinfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_InfoLimit
			// 
			this.lbl_InfoLimit.AutoSize = true;
			this.lbl_InfoLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_InfoLimit.Location = new System.Drawing.Point(244, 51);
			this.lbl_InfoLimit.Name = "lbl_InfoLimit";
			this.lbl_InfoLimit.Size = new System.Drawing.Size(38, 16);
			this.lbl_InfoLimit.TabIndex = 19;
			this.lbl_InfoLimit.Text = "Limit:";
			this.lbl_InfoLimit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_limit
			// 
			this.lbl_limit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_limit.Location = new System.Drawing.Point(332, 51);
			this.lbl_limit.Name = "lbl_limit";
			this.lbl_limit.Size = new System.Drawing.Size(62, 17);
			this.lbl_limit.TabIndex = 20;
			this.lbl_limit.Text = "0,00";
			this.lbl_limit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_unit4
			// 
			this.lbl_unit4.AutoSize = true;
			this.lbl_unit4.Location = new System.Drawing.Point(389, 52);
			this.lbl_unit4.Name = "lbl_unit4";
			this.lbl_unit4.Size = new System.Drawing.Size(13, 13);
			this.lbl_unit4.TabIndex = 21;
			this.lbl_unit4.Text = "€";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 281);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_unit4);
			this.Controls.Add(this.lbl_limit);
			this.Controls.Add(this.lbl_InfoLimit);
			this.Controls.Add(this.lbl_billinfo);
			this.Controls.Add(this.lbl_unit3);
			this.Controls.Add(this.lbl_bill);
			this.Controls.Add(this.lb_productList);
			this.Controls.Add(this.lbl_unit2);
			this.Controls.Add(this.lbl_unit1);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_confirm);
			this.Controls.Add(this.lbl_displayFullPrice);
			this.Controls.Add(this.lbl_fullPrice);
			this.Controls.Add(this.btn_plus);
			this.Controls.Add(this.btn_minus);
			this.Controls.Add(this.lbl_displayCount);
			this.Controls.Add(this.lbl_count);
			this.Controls.Add(this.lbl_displayPrice);
			this.Controls.Add(this.lbl_productPrice);
			this.Controls.Add(this.lbl_displayProductName);
			this.Controls.Add(this.lbl_product);
			this.Controls.Add(this.lbl_user);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "[T]";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.Label lbl_product;
		private System.Windows.Forms.Label lbl_displayProductName;
		private System.Windows.Forms.Label lbl_productPrice;
		private System.Windows.Forms.Label lbl_displayPrice;
		private System.Windows.Forms.Label lbl_count;
		private System.Windows.Forms.Label lbl_displayCount;
		private System.Windows.Forms.Button btn_minus;
		private System.Windows.Forms.Button btn_plus;
		private System.Windows.Forms.Label lbl_fullPrice;
		private System.Windows.Forms.Label lbl_displayFullPrice;
		private System.Windows.Forms.Button btn_confirm;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label lbl_unit1;
		private System.Windows.Forms.Label lbl_unit2;
		private System.Windows.Forms.CheckedListBox lb_productList;
		private System.Windows.Forms.Label lbl_bill;
		private System.Windows.Forms.Label lbl_unit3;
		private System.Windows.Forms.Label lbl_billinfo;
		private System.Windows.Forms.Label lbl_InfoLimit;
		private System.Windows.Forms.Label lbl_limit;
		private System.Windows.Forms.Label lbl_unit4;
	}
}


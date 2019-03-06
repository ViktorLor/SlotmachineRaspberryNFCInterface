namespace Prototype
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_age = new System.Windows.Forms.Label();
			this.btn_oke = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_age
			// 
			this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_age.Location = new System.Drawing.Point(12, 9);
			this.lbl_age.Name = "lbl_age";
			this.lbl_age.Size = new System.Drawing.Size(260, 78);
			this.lbl_age.TabIndex = 0;
			this.lbl_age.Text = "ZU JUNG!!!!";
			this.lbl_age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_oke
			// 
			this.btn_oke.BackColor = System.Drawing.Color.Red;
			this.btn_oke.Location = new System.Drawing.Point(12, 90);
			this.btn_oke.Name = "btn_oke";
			this.btn_oke.Size = new System.Drawing.Size(260, 31);
			this.btn_oke.TabIndex = 1;
			this.btn_oke.Text = "oke";
			this.btn_oke.UseVisualStyleBackColor = false;
			this.btn_oke.Click += new System.EventHandler(this.btn_oke_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(284, 133);
			this.ControlBox = false;
			this.Controls.Add(this.btn_oke);
			this.Controls.Add(this.lbl_age);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowIcon = false;
			this.Text = "[T]";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_age;
		private System.Windows.Forms.Button btn_oke;
	}
}
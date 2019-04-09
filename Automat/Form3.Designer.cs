namespace Prototype
{
	partial class Form3
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
			this.lbl_information = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_information
			// 
			this.lbl_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_information.Location = new System.Drawing.Point(12, 9);
			this.lbl_information.Name = "lbl_information";
			this.lbl_information.Size = new System.Drawing.Size(390, 263);
			this.lbl_information.TabIndex = 0;
			this.lbl_information.Text = "Mit NFC-Scan bestätigen";
			this.lbl_information.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 281);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_information);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form3";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "[T]";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lbl_information;
	}
}
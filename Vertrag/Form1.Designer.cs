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
			this.btn_paintball = new System.Windows.Forms.Button();
			this.btn_splatmaster = new System.Windows.Forms.Button();
			this.btn_bubble = new System.Windows.Forms.Button();
			this.btn_archery = new System.Windows.Forms.Button();
			this.lbl_display = new System.Windows.Forms.Label();
			this.lbl_chosen = new System.Windows.Forms.Label();
			this.lbl_confirm = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_paintball
			// 
			this.btn_paintball.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_paintball.Location = new System.Drawing.Point(13, 13);
			this.btn_paintball.Name = "btn_paintball";
			this.btn_paintball.Size = new System.Drawing.Size(192, 66);
			this.btn_paintball.TabIndex = 0;
			this.btn_paintball.Text = "Paintball";
			this.btn_paintball.UseVisualStyleBackColor = true;
			this.btn_paintball.Click += new System.EventHandler(this.btn_paintball_Click);
			// 
			// btn_splatmaster
			// 
			this.btn_splatmaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_splatmaster.Location = new System.Drawing.Point(210, 13);
			this.btn_splatmaster.Name = "btn_splatmaster";
			this.btn_splatmaster.Size = new System.Drawing.Size(192, 66);
			this.btn_splatmaster.TabIndex = 1;
			this.btn_splatmaster.Text = "Splat Master";
			this.btn_splatmaster.UseVisualStyleBackColor = true;
			this.btn_splatmaster.Click += new System.EventHandler(this.btn_splatmaster_Click);
			// 
			// btn_bubble
			// 
			this.btn_bubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_bubble.Location = new System.Drawing.Point(13, 85);
			this.btn_bubble.Name = "btn_bubble";
			this.btn_bubble.Size = new System.Drawing.Size(192, 66);
			this.btn_bubble.TabIndex = 2;
			this.btn_bubble.Text = "Bubble Bounce";
			this.btn_bubble.UseVisualStyleBackColor = true;
			this.btn_bubble.Click += new System.EventHandler(this.btn_bubble_Click);
			// 
			// btn_archery
			// 
			this.btn_archery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_archery.Location = new System.Drawing.Point(211, 85);
			this.btn_archery.Name = "btn_archery";
			this.btn_archery.Size = new System.Drawing.Size(192, 66);
			this.btn_archery.TabIndex = 3;
			this.btn_archery.Text = "Archery";
			this.btn_archery.UseVisualStyleBackColor = true;
			this.btn_archery.Click += new System.EventHandler(this.btn_archery_Click);
			// 
			// lbl_display
			// 
			this.lbl_display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_display.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbl_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_display.Location = new System.Drawing.Point(131, 248);
			this.lbl_display.Name = "lbl_display";
			this.lbl_display.Size = new System.Drawing.Size(271, 23);
			this.lbl_display.TabIndex = 4;
			this.lbl_display.Text = "Haftungsausschuss Paintball";
			this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_chosen
			// 
			this.lbl_chosen.AutoSize = true;
			this.lbl_chosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_chosen.Location = new System.Drawing.Point(9, 249);
			this.lbl_chosen.Name = "lbl_chosen";
			this.lbl_chosen.Size = new System.Drawing.Size(96, 20);
			this.lbl_chosen.TabIndex = 5;
			this.lbl_chosen.Text = "Ausgewählt:";
			// 
			// lbl_confirm
			// 
			this.lbl_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_confirm.Location = new System.Drawing.Point(12, 167);
			this.lbl_confirm.Name = "lbl_confirm";
			this.lbl_confirm.Size = new System.Drawing.Size(393, 68);
			this.lbl_confirm.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 281);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_confirm);
			this.Controls.Add(this.lbl_chosen);
			this.Controls.Add(this.lbl_display);
			this.Controls.Add(this.btn_archery);
			this.Controls.Add(this.btn_bubble);
			this.Controls.Add(this.btn_splatmaster);
			this.Controls.Add(this.btn_paintball);
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

		private System.Windows.Forms.Button btn_paintball;
		private System.Windows.Forms.Button btn_splatmaster;
		private System.Windows.Forms.Button btn_bubble;
		private System.Windows.Forms.Button btn_archery;
		private System.Windows.Forms.Label lbl_display;
		private System.Windows.Forms.Label lbl_chosen;
		private System.Windows.Forms.Label lbl_confirm;
	}
}



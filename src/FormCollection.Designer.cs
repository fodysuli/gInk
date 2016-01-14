﻿namespace gInk
{
	partial class FormCollection
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
			this.components = new System.ComponentModel.Container();
			this.btColorRed = new System.Windows.Forms.Button();
			this.btColorYellow = new System.Windows.Forms.Button();
			this.btColorBlue = new System.Windows.Forms.Button();
			this.gpButtons = new System.Windows.Forms.Panel();
			this.btEraser = new System.Windows.Forms.Button();
			this.btStop = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.tiSlide = new System.Windows.Forms.Timer(this.components);
			this.gpButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// btColorRed
			// 
			this.btColorRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btColorRed.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btColorRed.FlatAppearance.BorderSize = 0;
			this.btColorRed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btColorRed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btColorRed.Location = new System.Drawing.Point(150, 40);
			this.btColorRed.Name = "btColorRed";
			this.btColorRed.Size = new System.Drawing.Size(40, 40);
			this.btColorRed.TabIndex = 1;
			this.btColorRed.UseVisualStyleBackColor = false;
			this.btColorRed.Click += new System.EventHandler(this.btColor_Click);
			// 
			// btColorYellow
			// 
			this.btColorYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
			this.btColorYellow.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btColorYellow.FlatAppearance.BorderSize = 0;
			this.btColorYellow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
			this.btColorYellow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
			this.btColorYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btColorYellow.Location = new System.Drawing.Point(80, 40);
			this.btColorYellow.Name = "btColorYellow";
			this.btColorYellow.Size = new System.Drawing.Size(40, 40);
			this.btColorYellow.TabIndex = 1;
			this.btColorYellow.UseVisualStyleBackColor = false;
			this.btColorYellow.Click += new System.EventHandler(this.btColor_Click);
			// 
			// btColorBlue
			// 
			this.btColorBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(220)))));
			this.btColorBlue.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.btColorBlue.FlatAppearance.BorderSize = 0;
			this.btColorBlue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(220)))));
			this.btColorBlue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(220)))));
			this.btColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btColorBlue.Location = new System.Drawing.Point(10, 40);
			this.btColorBlue.Name = "btColorBlue";
			this.btColorBlue.Size = new System.Drawing.Size(40, 40);
			this.btColorBlue.TabIndex = 1;
			this.btColorBlue.UseVisualStyleBackColor = false;
			this.btColorBlue.Click += new System.EventHandler(this.btColor_Click);
			// 
			// gpButtons
			// 
			this.gpButtons.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gpButtons.Controls.Add(this.btEraser);
			this.gpButtons.Controls.Add(this.btStop);
			this.gpButtons.Controls.Add(this.btColorBlue);
			this.gpButtons.Controls.Add(this.btColorRed);
			this.gpButtons.Controls.Add(this.btClear);
			this.gpButtons.Controls.Add(this.btColorYellow);
			this.gpButtons.Location = new System.Drawing.Point(42, 84);
			this.gpButtons.Name = "gpButtons";
			this.gpButtons.Size = new System.Drawing.Size(578, 92);
			this.gpButtons.TabIndex = 3;
			// 
			// btEraser
			// 
			this.btEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btEraser.FlatAppearance.BorderSize = 0;
			this.btEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
			this.btEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btEraser.Location = new System.Drawing.Point(210, 10);
			this.btEraser.Name = "btEraser";
			this.btEraser.Size = new System.Drawing.Size(80, 80);
			this.btEraser.TabIndex = 0;
			this.btEraser.UseVisualStyleBackColor = true;
			this.btEraser.Click += new System.EventHandler(this.btEraser_Click);
			// 
			// btStop
			// 
			this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btStop.FlatAppearance.BorderSize = 0;
			this.btStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
			this.btStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btStop.Location = new System.Drawing.Point(390, 10);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(80, 80);
			this.btStop.TabIndex = 0;
			this.btStop.UseVisualStyleBackColor = true;
			this.btStop.Click += new System.EventHandler(this.btStop_Click);
			// 
			// btClear
			// 
			this.btClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btClear.FlatAppearance.BorderSize = 0;
			this.btClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
			this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btClear.Location = new System.Drawing.Point(300, 5);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(80, 80);
			this.btClear.TabIndex = 1;
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// tiSlide
			// 
			this.tiSlide.Enabled = true;
			this.tiSlide.Interval = 15;
			this.tiSlide.Tick += new System.EventHandler(this.tiSlide_Tick);
			// 
			// FormCollection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1410, 921);
			this.Controls.Add(this.gpButtons);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCollection";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gpButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btStop;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btColorRed;
		private System.Windows.Forms.Button btColorYellow;
		private System.Windows.Forms.Button btColorBlue;
		public System.Windows.Forms.Panel gpButtons;
		private System.Windows.Forms.Button btEraser;
		private System.Windows.Forms.Timer tiSlide;
	}
}


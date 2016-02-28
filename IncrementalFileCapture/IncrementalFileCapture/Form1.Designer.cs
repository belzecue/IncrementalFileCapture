namespace IncrementalFileCapture
{
	partial class Form1
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
			this.btnSource = new System.Windows.Forms.Button();
			this.btnTarget = new System.Windows.Forms.Button();
			this.lbTarget = new System.Windows.Forms.Label();
			this.lbSource = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.cbHour = new System.Windows.Forms.ComboBox();
			this.cbMinute = new System.Windows.Forms.ComboBox();
			this.cbSecond = new System.Windows.Forms.ComboBox();
			this.cbAMPM = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSource
			// 
			this.btnSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSource.Location = new System.Drawing.Point(25, 45);
			this.btnSource.Name = "btnSource";
			this.btnSource.Size = new System.Drawing.Size(95, 44);
			this.btnSource.TabIndex = 0;
			this.btnSource.Text = "Source";
			this.btnSource.UseVisualStyleBackColor = true;
			this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
			// 
			// btnTarget
			// 
			this.btnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTarget.Location = new System.Drawing.Point(25, 119);
			this.btnTarget.Name = "btnTarget";
			this.btnTarget.Size = new System.Drawing.Size(95, 44);
			this.btnTarget.TabIndex = 1;
			this.btnTarget.Text = "Target";
			this.btnTarget.UseVisualStyleBackColor = true;
			// 
			// lbTarget
			// 
			this.lbTarget.AutoEllipsis = true;
			this.lbTarget.AutoSize = true;
			this.lbTarget.BackColor = System.Drawing.SystemColors.Info;
			this.lbTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTarget.Location = new System.Drawing.Point(126, 119);
			this.lbTarget.MaximumSize = new System.Drawing.Size(370, 44);
			this.lbTarget.MinimumSize = new System.Drawing.Size(370, 44);
			this.lbTarget.Name = "lbTarget";
			this.lbTarget.Size = new System.Drawing.Size(370, 44);
			this.lbTarget.TabIndex = 3;
			this.lbTarget.Text = "Please select...";
			// 
			// lbSource
			// 
			this.lbSource.AutoEllipsis = true;
			this.lbSource.AutoSize = true;
			this.lbSource.BackColor = System.Drawing.SystemColors.Info;
			this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSource.Location = new System.Drawing.Point(126, 45);
			this.lbSource.MaximumSize = new System.Drawing.Size(370, 44);
			this.lbSource.MinimumSize = new System.Drawing.Size(370, 44);
			this.lbSource.Name = "lbSource";
			this.lbSource.Size = new System.Drawing.Size(370, 44);
			this.lbSource.TabIndex = 4;
			this.lbSource.Text = "Please select...";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(130, 190);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(366, 32);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// cbHour
			// 
			this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbHour.FormattingEnabled = true;
			this.cbHour.Location = new System.Drawing.Point(186, 228);
			this.cbHour.Name = "cbHour";
			this.cbHour.Size = new System.Drawing.Size(50, 33);
			this.cbHour.TabIndex = 6;
			this.cbHour.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// cbMinute
			// 
			this.cbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMinute.FormattingEnabled = true;
			this.cbMinute.Location = new System.Drawing.Point(256, 228);
			this.cbMinute.Name = "cbMinute";
			this.cbMinute.Size = new System.Drawing.Size(50, 33);
			this.cbMinute.TabIndex = 7;
			// 
			// cbSecond
			// 
			this.cbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSecond.FormattingEnabled = true;
			this.cbSecond.Location = new System.Drawing.Point(326, 228);
			this.cbSecond.Name = "cbSecond";
			this.cbSecond.Size = new System.Drawing.Size(50, 33);
			this.cbSecond.TabIndex = 8;
			// 
			// cbAMPM
			// 
			this.cbAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAMPM.FormattingEnabled = true;
			this.cbAMPM.Location = new System.Drawing.Point(396, 228);
			this.cbAMPM.Name = "cbAMPM";
			this.cbAMPM.Size = new System.Drawing.Size(50, 33);
			this.cbAMPM.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(309, 235);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(239, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = ":";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 332);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbAMPM);
			this.Controls.Add(this.cbSecond);
			this.Controls.Add(this.cbMinute);
			this.Controls.Add(this.cbHour);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lbSource);
			this.Controls.Add(this.lbTarget);
			this.Controls.Add(this.btnTarget);
			this.Controls.Add(this.btnSource);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSource;
		private System.Windows.Forms.Button btnTarget;
		private System.Windows.Forms.Label lbTarget;
		private System.Windows.Forms.Label lbSource;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox cbHour;
		private System.Windows.Forms.ComboBox cbMinute;
		private System.Windows.Forms.ComboBox cbSecond;
		private System.Windows.Forms.ComboBox cbAMPM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}


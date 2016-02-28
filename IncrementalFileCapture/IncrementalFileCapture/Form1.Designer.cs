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
			this.label4 = new System.Windows.Forms.Label();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbIgnore = new System.Windows.Forms.TextBox();
			this.lbIgnoreMatching = new System.Windows.Forms.Label();
			this.lbIgnoreContaining = new System.Windows.Forms.Label();
			this.tbContaining = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSource
			// 
			this.btnSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSource.Location = new System.Drawing.Point(12, 45);
			this.btnSource.Name = "btnSource";
			this.btnSource.Size = new System.Drawing.Size(95, 44);
			this.btnSource.TabIndex = 0;
			this.btnSource.Text = "Source Folder";
			this.btnSource.UseVisualStyleBackColor = true;
			this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
			// 
			// btnTarget
			// 
			this.btnTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTarget.Location = new System.Drawing.Point(12, 119);
			this.btnTarget.Name = "btnTarget";
			this.btnTarget.Size = new System.Drawing.Size(95, 44);
			this.btnTarget.TabIndex = 1;
			this.btnTarget.Text = "Save To Folder";
			this.btnTarget.UseVisualStyleBackColor = true;
			this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
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
			this.dateTimePicker1.Location = new System.Drawing.Point(130, 226);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(366, 32);
			this.dateTimePicker1.TabIndex = 5;
			// 
			// cbHour
			// 
			this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbHour.FormattingEnabled = true;
			this.cbHour.Location = new System.Drawing.Point(186, 264);
			this.cbHour.Name = "cbHour";
			this.cbHour.Size = new System.Drawing.Size(55, 33);
			this.cbHour.TabIndex = 6;
			this.cbHour.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// cbMinute
			// 
			this.cbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMinute.FormattingEnabled = true;
			this.cbMinute.Location = new System.Drawing.Point(256, 264);
			this.cbMinute.Name = "cbMinute";
			this.cbMinute.Size = new System.Drawing.Size(55, 33);
			this.cbMinute.TabIndex = 7;
			// 
			// cbSecond
			// 
			this.cbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSecond.FormattingEnabled = true;
			this.cbSecond.Location = new System.Drawing.Point(326, 264);
			this.cbSecond.Name = "cbSecond";
			this.cbSecond.Size = new System.Drawing.Size(55, 33);
			this.cbSecond.TabIndex = 8;
			// 
			// cbAMPM
			// 
			this.cbAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAMPM.FormattingEnabled = true;
			this.cbAMPM.Location = new System.Drawing.Point(396, 264);
			this.cbAMPM.Name = "cbAMPM";
			this.cbAMPM.Size = new System.Drawing.Size(55, 33);
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
			this.label5.Location = new System.Drawing.Point(313, 271);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(243, 271);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = ":";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(151, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(325, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Collect all files that are new or changed after:";
			// 
			// tbLog
			// 
			this.tbLog.Location = new System.Drawing.Point(12, 524);
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.Size = new System.Drawing.Size(484, 125);
			this.tbLog.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 501);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Activity Log";
			// 
			// tbIgnore
			// 
			this.tbIgnore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIgnore.Location = new System.Drawing.Point(13, 358);
			this.tbIgnore.Multiline = true;
			this.tbIgnore.Name = "tbIgnore";
			this.tbIgnore.Size = new System.Drawing.Size(240, 125);
			this.tbIgnore.TabIndex = 16;
			this.tbIgnore.Leave += new System.EventHandler(this.tbIgnore_Leave);
			// 
			// lbIgnoreMatching
			// 
			this.lbIgnoreMatching.AutoSize = true;
			this.lbIgnoreMatching.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreMatching.Location = new System.Drawing.Point(13, 335);
			this.lbIgnoreMatching.Name = "lbIgnoreMatching";
			this.lbIgnoreMatching.Size = new System.Drawing.Size(206, 20);
			this.lbIgnoreMatching.TabIndex = 17;
			this.lbIgnoreMatching.Text = "Ignore Dir Names Matching:";
			// 
			// lbIgnoreContaining
			// 
			this.lbIgnoreContaining.AutoSize = true;
			this.lbIgnoreContaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreContaining.Location = new System.Drawing.Point(253, 335);
			this.lbIgnoreContaining.Name = "lbIgnoreContaining";
			this.lbIgnoreContaining.Size = new System.Drawing.Size(217, 20);
			this.lbIgnoreContaining.TabIndex = 19;
			this.lbIgnoreContaining.Text = "Ignore Dir Names Containing:";
			// 
			// tbContaining
			// 
			this.tbContaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbContaining.Location = new System.Drawing.Point(252, 358);
			this.tbContaining.Multiline = true;
			this.tbContaining.Name = "tbContaining";
			this.tbContaining.Size = new System.Drawing.Size(244, 125);
			this.tbContaining.TabIndex = 18;
			this.tbContaining.Leave += new System.EventHandler(this.tbContaining_Leave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 661);
			this.Controls.Add(this.lbIgnoreContaining);
			this.Controls.Add(this.tbContaining);
			this.Controls.Add(this.lbIgnoreMatching);
			this.Controls.Add(this.tbIgnore);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbLog);
			this.Controls.Add(this.label4);
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
			this.Text = "Incremental File Capture";
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbLog;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbIgnore;
		private System.Windows.Forms.Label lbIgnoreMatching;
		private System.Windows.Forms.Label lbIgnoreContaining;
		private System.Windows.Forms.TextBox tbContaining;
	}
}


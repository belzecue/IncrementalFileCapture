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
			this.tbLog = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbIgnoreMatchingDir = new System.Windows.Forms.RichTextBox();
			this.lbIgnoreMatchingDir = new System.Windows.Forms.Label();
			this.lbIgnoreContainingDir = new System.Windows.Forms.Label();
			this.tbIgnoreContainingDir = new System.Windows.Forms.RichTextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.lbIgnoreContainingFile = new System.Windows.Forms.Label();
			this.tbIgnoreContainingFile = new System.Windows.Forms.RichTextBox();
			this.lbIgnoreMatchingFile = new System.Windows.Forms.Label();
			this.tbIgnoreMatchingFile = new System.Windows.Forms.RichTextBox();
			this.btnSaveConfig = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
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
			this.btnTarget.Text = "Copy To Folder";
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
			this.tbLog.Location = new System.Drawing.Point(512, 119);
			this.tbLog.Name = "tbLog";
			this.tbLog.Size = new System.Drawing.Size(484, 530);
			this.tbLog.TabIndex = 14;
			this.tbLog.Text = "";
			this.tbLog.WordWrap = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(960, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Log";
			// 
			// tbIgnoreMatchingDir
			// 
			this.tbIgnoreMatchingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIgnoreMatchingDir.Location = new System.Drawing.Point(13, 358);
			this.tbIgnoreMatchingDir.Name = "tbIgnoreMatchingDir";
			this.tbIgnoreMatchingDir.Size = new System.Drawing.Size(240, 125);
			this.tbIgnoreMatchingDir.TabIndex = 16;
			this.tbIgnoreMatchingDir.Text = "";
			this.tbIgnoreMatchingDir.Leave += new System.EventHandler(this.tbIgnoreMatchingDir_Leave);
			// 
			// lbIgnoreMatchingDir
			// 
			this.lbIgnoreMatchingDir.AutoSize = true;
			this.lbIgnoreMatchingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreMatchingDir.Location = new System.Drawing.Point(13, 335);
			this.lbIgnoreMatchingDir.Name = "lbIgnoreMatchingDir";
			this.lbIgnoreMatchingDir.Size = new System.Drawing.Size(206, 20);
			this.lbIgnoreMatchingDir.TabIndex = 17;
			this.lbIgnoreMatchingDir.Text = "Ignore Dir Names Matching:";
			// 
			// lbIgnoreContainingDir
			// 
			this.lbIgnoreContainingDir.AutoSize = true;
			this.lbIgnoreContainingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreContainingDir.Location = new System.Drawing.Point(253, 335);
			this.lbIgnoreContainingDir.Name = "lbIgnoreContainingDir";
			this.lbIgnoreContainingDir.Size = new System.Drawing.Size(217, 20);
			this.lbIgnoreContainingDir.TabIndex = 19;
			this.lbIgnoreContainingDir.Text = "Ignore Dir Names Containing:";
			// 
			// tbIgnoreContainingDir
			// 
			this.tbIgnoreContainingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIgnoreContainingDir.Location = new System.Drawing.Point(252, 358);
			this.tbIgnoreContainingDir.Name = "tbIgnoreContainingDir";
			this.tbIgnoreContainingDir.Size = new System.Drawing.Size(244, 125);
			this.tbIgnoreContainingDir.TabIndex = 18;
			this.tbIgnoreContainingDir.Text = "";
			this.tbIgnoreContainingDir.Leave += new System.EventHandler(this.tbIgnoreContainingDir_Leave);
			// 
			// btnGo
			// 
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.Location = new System.Drawing.Point(12, 195);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(95, 93);
			this.btnGo.TabIndex = 20;
			this.btnGo.Text = "RUN";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// lbIgnoreContainingFile
			// 
			this.lbIgnoreContainingFile.AutoSize = true;
			this.lbIgnoreContainingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreContainingFile.Location = new System.Drawing.Point(253, 501);
			this.lbIgnoreContainingFile.Name = "lbIgnoreContainingFile";
			this.lbIgnoreContainingFile.Size = new System.Drawing.Size(222, 20);
			this.lbIgnoreContainingFile.TabIndex = 24;
			this.lbIgnoreContainingFile.Text = "Ignore File Names Containing:";
			// 
			// tbIgnoreContainingFile
			// 
			this.tbIgnoreContainingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIgnoreContainingFile.Location = new System.Drawing.Point(252, 524);
			this.tbIgnoreContainingFile.Name = "tbIgnoreContainingFile";
			this.tbIgnoreContainingFile.Size = new System.Drawing.Size(244, 125);
			this.tbIgnoreContainingFile.TabIndex = 23;
			this.tbIgnoreContainingFile.Text = "";
			this.tbIgnoreContainingFile.Leave += new System.EventHandler(this.tbIgnoreContainingFile_Leave);
			// 
			// lbIgnoreMatchingFile
			// 
			this.lbIgnoreMatchingFile.AutoSize = true;
			this.lbIgnoreMatchingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreMatchingFile.Location = new System.Drawing.Point(13, 501);
			this.lbIgnoreMatchingFile.Name = "lbIgnoreMatchingFile";
			this.lbIgnoreMatchingFile.Size = new System.Drawing.Size(211, 20);
			this.lbIgnoreMatchingFile.TabIndex = 22;
			this.lbIgnoreMatchingFile.Text = "Ignore File Names Matching:";
			// 
			// tbIgnoreMatchingFile
			// 
			this.tbIgnoreMatchingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbIgnoreMatchingFile.Location = new System.Drawing.Point(13, 524);
			this.tbIgnoreMatchingFile.Name = "tbIgnoreMatchingFile";
			this.tbIgnoreMatchingFile.Size = new System.Drawing.Size(240, 125);
			this.tbIgnoreMatchingFile.TabIndex = 21;
			this.tbIgnoreMatchingFile.Text = "";
			this.tbIgnoreMatchingFile.Leave += new System.EventHandler(this.tbIgnoreMatchingFile_Leave);
			// 
			// btnSaveConfig
			// 
			this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveConfig.Location = new System.Drawing.Point(542, 45);
			this.btnSaveConfig.Name = "btnSaveConfig";
			this.btnSaveConfig.Size = new System.Drawing.Size(95, 44);
			this.btnSaveConfig.TabIndex = 25;
			this.btnSaveConfig.Text = "Save Config";
			this.btnSaveConfig.UseVisualStyleBackColor = true;
			this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(650, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(307, 40);
			this.label8.TabIndex = 26;
			this.label8.Text = "Saves an ini file in Source folder to be\r\nused in future when that folder is sele" +
    "cted.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 661);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnSaveConfig);
			this.Controls.Add(this.lbIgnoreContainingFile);
			this.Controls.Add(this.tbIgnoreContainingFile);
			this.Controls.Add(this.lbIgnoreMatchingFile);
			this.Controls.Add(this.tbIgnoreMatchingFile);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.lbIgnoreContainingDir);
			this.Controls.Add(this.tbIgnoreContainingDir);
			this.Controls.Add(this.lbIgnoreMatchingDir);
			this.Controls.Add(this.tbIgnoreMatchingDir);
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
		private System.Windows.Forms.RichTextBox tbLog;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox tbIgnoreMatchingDir;
		private System.Windows.Forms.Label lbIgnoreMatchingDir;
		private System.Windows.Forms.Label lbIgnoreContainingDir;
		private System.Windows.Forms.RichTextBox tbIgnoreContainingDir;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Label lbIgnoreContainingFile;
		private System.Windows.Forms.RichTextBox tbIgnoreContainingFile;
		private System.Windows.Forms.Label lbIgnoreMatchingFile;
		private System.Windows.Forms.RichTextBox tbIgnoreMatchingFile;
		private System.Windows.Forms.Button btnSaveConfig;
		private System.Windows.Forms.Label label8;
	}
}


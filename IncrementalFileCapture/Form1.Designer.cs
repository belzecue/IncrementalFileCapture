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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnSource = new System.Windows.Forms.Button();
			this.btnTarget = new System.Windows.Forms.Button();
			this.lbTarget = new System.Windows.Forms.Label();
			this.lbSource = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.cbHour = new System.Windows.Forms.ComboBox();
			this.cbMinute = new System.Windows.Forms.ComboBox();
			this.cbSecond = new System.Windows.Forms.ComboBox();
			this.cbAMPM = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rtbLog = new System.Windows.Forms.RichTextBox();
			this.lbLog = new System.Windows.Forms.Label();
			this.rtbIgnoreMatchingDir = new System.Windows.Forms.RichTextBox();
			this.lbIgnoreMatchingDir = new System.Windows.Forms.Label();
			this.lbIgnoreContainingDir = new System.Windows.Forms.Label();
			this.rtbIgnoreContainingDir = new System.Windows.Forms.RichTextBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.lbIgnoreContainingFile = new System.Windows.Forms.Label();
			this.rtbIgnoreContainingFile = new System.Windows.Forms.RichTextBox();
			this.lbIgnoreMatchingFile = new System.Windows.Forms.Label();
			this.rtbIgnoreMatchingFile = new System.Windows.Forms.RichTextBox();
			this.btnSaveConfig = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.lbIgnoreEndingFile = new System.Windows.Forms.Label();
			this.rtbIgnoreEndingFile = new System.Windows.Forms.RichTextBox();
			this.btnScanForNewest = new System.Windows.Forms.Button();
			this.lbScanForNewest = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnSource
			// 
			this.btnSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSource.Location = new System.Drawing.Point(12, 9);
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
			this.btnTarget.Location = new System.Drawing.Point(12, 83);
			this.btnTarget.Name = "btnTarget";
			this.btnTarget.Size = new System.Drawing.Size(95, 44);
			this.btnTarget.TabIndex = 1;
			this.btnTarget.Text = "Copy To Folder";
			this.btnTarget.UseVisualStyleBackColor = true;
			this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
			// 
			// rtbTarget
			// 
			this.lbTarget.AutoEllipsis = true;
			this.lbTarget.AutoSize = true;
			this.lbTarget.BackColor = System.Drawing.SystemColors.Info;
			this.lbTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTarget.Location = new System.Drawing.Point(126, 83);
			this.lbTarget.MaximumSize = new System.Drawing.Size(370, 44);
			this.lbTarget.MinimumSize = new System.Drawing.Size(370, 44);
			this.lbTarget.Name = "rtbTarget";
			this.lbTarget.Size = new System.Drawing.Size(370, 44);
			this.lbTarget.TabIndex = 3;
			// 
			// lbSource
			// 
			this.lbSource.AutoEllipsis = true;
			this.lbSource.AutoSize = true;
			this.lbSource.BackColor = System.Drawing.SystemColors.Info;
			this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSource.Location = new System.Drawing.Point(126, 9);
			this.lbSource.MaximumSize = new System.Drawing.Size(370, 44);
			this.lbSource.MinimumSize = new System.Drawing.Size(370, 44);
			this.lbSource.Name = "lbSource";
			this.lbSource.Size = new System.Drawing.Size(370, 44);
			this.lbSource.TabIndex = 4;
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker.Location = new System.Drawing.Point(130, 255);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(366, 32);
			this.dateTimePicker.TabIndex = 5;
			// 
			// cbHour
			// 
			this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbHour.FormattingEnabled = true;
			this.cbHour.Location = new System.Drawing.Point(186, 293);
			this.cbHour.Name = "cbHour";
			this.cbHour.Size = new System.Drawing.Size(55, 33);
			this.cbHour.TabIndex = 6;
			this.cbHour.Leave += new System.EventHandler(this.cbHour_Leave);
			// 
			// cbMinute
			// 
			this.cbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMinute.FormattingEnabled = true;
			this.cbMinute.Location = new System.Drawing.Point(256, 293);
			this.cbMinute.Name = "cbMinute";
			this.cbMinute.Size = new System.Drawing.Size(55, 33);
			this.cbMinute.TabIndex = 7;
			this.cbMinute.Leave += new System.EventHandler(this.cbMinute_Leave);
			// 
			// cbSecond
			// 
			this.cbSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSecond.FormattingEnabled = true;
			this.cbSecond.Location = new System.Drawing.Point(326, 293);
			this.cbSecond.Name = "cbSecond";
			this.cbSecond.Size = new System.Drawing.Size(55, 33);
			this.cbSecond.TabIndex = 8;
			this.cbSecond.Leave += new System.EventHandler(this.cbSecond_Leave);
			// 
			// cbAMPM
			// 
			this.cbAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAMPM.FormattingEnabled = true;
			this.cbAMPM.Location = new System.Drawing.Point(396, 293);
			this.cbAMPM.Name = "cbAMPM";
			this.cbAMPM.Size = new System.Drawing.Size(55, 33);
			this.cbAMPM.TabIndex = 9;
			this.cbAMPM.Leave += new System.EventHandler(this.cbAMPM_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(313, 300);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(13, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(243, 300);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = ":";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(126, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(325, 20);
			this.label4.TabIndex = 13;
			this.label4.Text = "Collect all files that are new or changed after:";
			// 
			// rtbLog
			// 
			this.rtbLog.Location = new System.Drawing.Point(12, 358);
			this.rtbLog.Name = "rtbLog";
			this.rtbLog.Size = new System.Drawing.Size(484, 291);
			this.rtbLog.TabIndex = 14;
			this.rtbLog.Text = "";
			this.rtbLog.WordWrap = false;
			// 
			// lbLog
			// 
			this.lbLog.AutoSize = true;
			this.lbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLog.Location = new System.Drawing.Point(17, 335);
			this.lbLog.Name = "lbLog";
			this.lbLog.Size = new System.Drawing.Size(40, 20);
			this.lbLog.TabIndex = 15;
			this.lbLog.Text = "Log:";
			this.lbLog.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// rtbIgnoreMatchingDir
			// 
			this.rtbIgnoreMatchingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIgnoreMatchingDir.Location = new System.Drawing.Point(512, 358);
			this.rtbIgnoreMatchingDir.Name = "rtbIgnoreMatchingDir";
			this.rtbIgnoreMatchingDir.Size = new System.Drawing.Size(240, 125);
			this.rtbIgnoreMatchingDir.TabIndex = 16;
			this.rtbIgnoreMatchingDir.Text = "";
			this.rtbIgnoreMatchingDir.Leave += new System.EventHandler(this.rtbExclusion_Leave);
			// 
			// lbIgnoreMatchingDir
			// 
			this.lbIgnoreMatchingDir.AutoSize = true;
			this.lbIgnoreMatchingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreMatchingDir.Location = new System.Drawing.Point(512, 335);
			this.lbIgnoreMatchingDir.Name = "lbIgnoreMatchingDir";
			this.lbIgnoreMatchingDir.Size = new System.Drawing.Size(206, 20);
			this.lbIgnoreMatchingDir.TabIndex = 17;
			this.lbIgnoreMatchingDir.Text = "Ignore Dir Names Matching:";
			// 
			// lbIgnoreContainingDir
			// 
			this.lbIgnoreContainingDir.AutoSize = true;
			this.lbIgnoreContainingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreContainingDir.Location = new System.Drawing.Point(513, 501);
			this.lbIgnoreContainingDir.Name = "lbIgnoreContainingDir";
			this.lbIgnoreContainingDir.Size = new System.Drawing.Size(217, 20);
			this.lbIgnoreContainingDir.TabIndex = 19;
			this.lbIgnoreContainingDir.Text = "Ignore Dir Names Containing:";
			// 
			// rtbIgnoreContainingDir
			// 
			this.rtbIgnoreContainingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIgnoreContainingDir.Location = new System.Drawing.Point(512, 524);
			this.rtbIgnoreContainingDir.Name = "rtbIgnoreContainingDir";
			this.rtbIgnoreContainingDir.Size = new System.Drawing.Size(244, 125);
			this.rtbIgnoreContainingDir.TabIndex = 18;
			this.rtbIgnoreContainingDir.Text = "";
			this.rtbIgnoreContainingDir.Leave += new System.EventHandler(this.rtbExclusion_Leave);
			// 
			// btnGo
			// 
			this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGo.Location = new System.Drawing.Point(12, 224);
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
			this.lbIgnoreContainingFile.Location = new System.Drawing.Point(752, 501);
			this.lbIgnoreContainingFile.Name = "lbIgnoreContainingFile";
			this.lbIgnoreContainingFile.Size = new System.Drawing.Size(222, 20);
			this.lbIgnoreContainingFile.TabIndex = 24;
			this.lbIgnoreContainingFile.Text = "Ignore File Names Containing:";
			// 
			// rtbIgnoreContainingFile
			// 
			this.rtbIgnoreContainingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIgnoreContainingFile.Location = new System.Drawing.Point(751, 524);
			this.rtbIgnoreContainingFile.Name = "rtbIgnoreContainingFile";
			this.rtbIgnoreContainingFile.Size = new System.Drawing.Size(244, 125);
			this.rtbIgnoreContainingFile.TabIndex = 23;
			this.rtbIgnoreContainingFile.Text = "";
			this.rtbIgnoreContainingFile.Leave += new System.EventHandler(this.rtbExclusion_Leave);
			// 
			// lbIgnoreMatchingFile
			// 
			this.lbIgnoreMatchingFile.AutoSize = true;
			this.lbIgnoreMatchingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreMatchingFile.Location = new System.Drawing.Point(751, 335);
			this.lbIgnoreMatchingFile.Name = "lbIgnoreMatchingFile";
			this.lbIgnoreMatchingFile.Size = new System.Drawing.Size(211, 20);
			this.lbIgnoreMatchingFile.TabIndex = 22;
			this.lbIgnoreMatchingFile.Text = "Ignore File Names Matching:";
			// 
			// rtbIgnoreMatchingFile
			// 
			this.rtbIgnoreMatchingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIgnoreMatchingFile.Location = new System.Drawing.Point(751, 358);
			this.rtbIgnoreMatchingFile.Name = "rtbIgnoreMatchingFile";
			this.rtbIgnoreMatchingFile.Size = new System.Drawing.Size(240, 125);
			this.rtbIgnoreMatchingFile.TabIndex = 21;
			this.rtbIgnoreMatchingFile.Text = "";
			this.rtbIgnoreMatchingFile.Leave += new System.EventHandler(this.rtbExclusion_Leave);
			// 
			// btnSaveConfig
			// 
			this.btnSaveConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveConfig.Location = new System.Drawing.Point(12, 156);
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
			this.label8.Location = new System.Drawing.Point(126, 156);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(307, 40);
			this.label8.TabIndex = 26;
			this.label8.Text = "Saves an ini file in Source folder to be\r\nused in future when that folder is sele" +
    "cted.";
			// 
			// lbIgnoreEndingFile
			// 
			this.lbIgnoreEndingFile.AutoSize = true;
			this.lbIgnoreEndingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIgnoreEndingFile.Location = new System.Drawing.Point(751, 169);
			this.lbIgnoreEndingFile.Name = "lbIgnoreEndingFile";
			this.lbIgnoreEndingFile.Size = new System.Drawing.Size(214, 20);
			this.lbIgnoreEndingFile.TabIndex = 28;
			this.lbIgnoreEndingFile.Text = "Ignore File Names Ending In:";
			// 
			// rtbIgnoreEndingFile
			// 
			this.rtbIgnoreEndingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIgnoreEndingFile.Location = new System.Drawing.Point(751, 192);
			this.rtbIgnoreEndingFile.Name = "rtbIgnoreEndingFile";
			this.rtbIgnoreEndingFile.Size = new System.Drawing.Size(240, 125);
			this.rtbIgnoreEndingFile.TabIndex = 27;
			this.rtbIgnoreEndingFile.Text = "";
			this.rtbIgnoreEndingFile.Leave += new System.EventHandler(this.rtbExclusion_Leave);
			// 
			// btnScanForNewest
			// 
			this.btnScanForNewest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnScanForNewest.Location = new System.Drawing.Point(517, 9);
			this.btnScanForNewest.Name = "btnScanForNewest";
			this.btnScanForNewest.Size = new System.Drawing.Size(95, 44);
			this.btnScanForNewest.TabIndex = 29;
			this.btnScanForNewest.Text = "Scan For Newest";
			this.btnScanForNewest.UseVisualStyleBackColor = true;
			this.btnScanForNewest.Click += new System.EventHandler(this.btnScanForNewest_Click);
			// 
			// lbScanForNewest
			// 
			this.lbScanForNewest.AutoEllipsis = true;
			this.lbScanForNewest.AutoSize = true;
			this.lbScanForNewest.BackColor = System.Drawing.SystemColors.Info;
			this.lbScanForNewest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbScanForNewest.Location = new System.Drawing.Point(621, 9);
			this.lbScanForNewest.MaximumSize = new System.Drawing.Size(370, 44);
			this.lbScanForNewest.MinimumSize = new System.Drawing.Size(370, 44);
			this.lbScanForNewest.Name = "lbScanForNewest";
			this.lbScanForNewest.Size = new System.Drawing.Size(370, 44);
			this.lbScanForNewest.TabIndex = 30;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1008, 661);
			this.Controls.Add(this.lbScanForNewest);
			this.Controls.Add(this.btnScanForNewest);
			this.Controls.Add(this.lbIgnoreEndingFile);
			this.Controls.Add(this.rtbIgnoreEndingFile);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnSaveConfig);
			this.Controls.Add(this.lbIgnoreContainingFile);
			this.Controls.Add(this.rtbIgnoreContainingFile);
			this.Controls.Add(this.lbIgnoreMatchingFile);
			this.Controls.Add(this.rtbIgnoreMatchingFile);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.lbIgnoreContainingDir);
			this.Controls.Add(this.rtbIgnoreContainingDir);
			this.Controls.Add(this.lbIgnoreMatchingDir);
			this.Controls.Add(this.rtbIgnoreMatchingDir);
			this.Controls.Add(this.lbLog);
			this.Controls.Add(this.rtbLog);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbAMPM);
			this.Controls.Add(this.cbSecond);
			this.Controls.Add(this.cbMinute);
			this.Controls.Add(this.cbHour);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.lbSource);
			this.Controls.Add(this.lbTarget);
			this.Controls.Add(this.btnTarget);
			this.Controls.Add(this.btnSource);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.ComboBox cbHour;
		private System.Windows.Forms.ComboBox cbMinute;
		private System.Windows.Forms.ComboBox cbSecond;
		private System.Windows.Forms.ComboBox cbAMPM;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtbLog;
		private System.Windows.Forms.Label lbLog;
		private System.Windows.Forms.RichTextBox rtbIgnoreMatchingDir;
		private System.Windows.Forms.Label lbIgnoreMatchingDir;
		private System.Windows.Forms.Label lbIgnoreContainingDir;
		private System.Windows.Forms.RichTextBox rtbIgnoreContainingDir;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Label lbIgnoreContainingFile;
		private System.Windows.Forms.RichTextBox rtbIgnoreContainingFile;
		private System.Windows.Forms.Label lbIgnoreMatchingFile;
		private System.Windows.Forms.RichTextBox rtbIgnoreMatchingFile;
		private System.Windows.Forms.Button btnSaveConfig;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbIgnoreEndingFile;
		private System.Windows.Forms.RichTextBox rtbIgnoreEndingFile;
		private System.Windows.Forms.Button btnScanForNewest;
		private System.Windows.Forms.Label lbScanForNewest;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}


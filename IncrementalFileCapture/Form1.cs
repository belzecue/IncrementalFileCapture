using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ini;

namespace IncrementalFileCapture
{
	public partial class Form1 : Form
	{
		enum hours : int { max = 12, min = 1 }
		enum minutes : int { max = 59, min = 0 }
		enum seconds : int { max = 59, min = 0 }

		private DateTime baseDateTime;
		private string awaitingInputText = "Please select...";

		public Form1()
		{
			InitializeComponent();

			lbSource.Text = Sanitize(lbSource.Text);
			lbTarget.Text = Sanitize(lbTarget.Text);

			// populate Time hour/min/second dropdowns

			// hours

			for (int i = (int)hours.min; i <= (int)hours.max; i++)
			{
				cbHour.Items.Add(i);
			}
			cbHour.SelectedItem = (int)hours.max;

			// minutes

			for (int i = (int)minutes.min; i <= (int)minutes.max; i++)
			{
				cbMinute.Items.Add(i);
			}
			cbMinute.SelectedItem = (int)minutes.min;

			// seconds

			for (int i = (int)seconds.min; i <= (int)seconds.max; i++)
			{
				cbSecond.Items.Add(i);
			}
			cbSecond.SelectedItem = (int)seconds.min;

			// AM/PM

			cbAMPM.Items.Add("AM");
			cbAMPM.Items.Add("PM");
			cbAMPM.SelectedItem = "AM";
		}

		private void btnSource_Click(object sender, EventArgs e)
		{
			var sourceFolder = new FolderBrowserDialog();
			sourceFolder.ShowDialog();
			lbSource.Text = sourceFolder.SelectedPath;

			if (CheckPathRoot(lbSource.Text) == 0) ReadIniFile();
		}

		private void btnTarget_Click(object sender, EventArgs e)
		{
			var targetFolder = new FolderBrowserDialog();
			targetFolder.ShowDialog();
			lbTarget.Text = targetFolder.SelectedPath;
		}

		private void tbIgnoreMatchingDir_Leave(object sender, EventArgs e)
		{
			tbIgnoreMatchingDir.Lines = StripBlankLines(tbIgnoreMatchingDir.Lines);
			lbIgnoreMatchingDir.Text = UpdateListBoxLabel(tbIgnoreMatchingDir, lbIgnoreMatchingDir);

		}

		private void tbIgnoreMatchingFile_Leave(object sender, EventArgs e)
		{
			tbIgnoreMatchingFile.Lines = StripBlankLines(tbIgnoreMatchingFile.Lines);
			lbIgnoreMatchingFile.Text = UpdateListBoxLabel(tbIgnoreMatchingFile, lbIgnoreMatchingFile);
		}

		private void tbIgnoreContainingDir_Leave(object sender, EventArgs e)
		{
			tbIgnoreContainingDir.Lines = StripBlankLines(tbIgnoreContainingDir.Lines);
			lbIgnoreContainingDir.Text = UpdateListBoxLabel(tbIgnoreContainingDir, lbIgnoreContainingDir);

		}

		private void tbIgnoreContainingFile_Leave(object sender, EventArgs e)
		{
			tbIgnoreContainingFile.Lines = StripBlankLines(tbIgnoreContainingFile.Lines);
			lbIgnoreContainingFile.Text = UpdateListBoxLabel(tbIgnoreContainingFile, lbIgnoreContainingFile);
		}

		private string[] StripBlankLines (string[] strList)
		{
			// trim leading and trailing whitespace
			for (int i = 0; i < strList.Length; i++)
			{
				strList[i] = strList[i].Trim();
			}

			// flush any blank lines and make the list distinct
			strList = strList.Where(
				s => !string.IsNullOrWhiteSpace(s)
			).Distinct().ToArray<string>();

			return strList.OrderBy(s => s).ToArray<string>();

		}

		private string UpdateListBoxLabel (RichTextBox listBox, Label label)
		{
			return String.Format(
				"{0}: {1}"
				, label.Text.Split(':')[0] 
				, listBox.Lines.Count()
			);
		}

		private void btnSaveConfig_Click(object sender, EventArgs e)
		{
			if (lbSource.Text == awaitingInputText)
			{
				LogEntry("ERROR!  Please select a valid source folder.");
				return;
			}
			WriteIniFile();
		}

		private void LogEntry (string str)
		{
			Color textOrig = tbLog.SelectionColor;

			if (str.StartsWith("ERROR!"))
			{
				tbLog.SelectionColor = Color.Red;

				AppendLine(
					tbLog
					, string.Format(
						"{0} {1}"
						, DateTime.Now
						, str
						)
				);

				tbLog.SelectionColor = textOrig;
			}
			else
			{
				AppendLine(
					tbLog
					, string.Format(
						"{0} {1}"
						, DateTime.Now
						, str
						)
				);
			}
		}

		private void AppendLine(RichTextBox source, string str)
		{
			source.AppendText(str + System.Environment.NewLine);
		}

		private bool WriteIniFile()
		{
			string iniPath = Sanitize(lbSource.Text);

			if (Directory.Exists(iniPath))
			{
				string iniFilename = iniPath + @"\IFC.ini";
				bool iniFileExists = File.Exists(iniFilename);

				if (iniFileExists)
				{
					LogEntry("Overwriting config file at " + iniFilename);

				}
				else
				{
					LogEntry("Writing config file at " + iniFilename);
				}

				WriteIniFileKey(iniFilename, "Exclusions", "IgnoreMatchingDir", tbIgnoreMatchingDir);
				WriteIniFileKey(iniFilename, "Exclusions", "IgnoreMatchingFile", tbIgnoreMatchingFile);
				WriteIniFileKey(iniFilename, "Exclusions", "IgnoreContainingDir", tbIgnoreContainingDir);
				WriteIniFileKey(iniFilename, "Exclusions", "IgnoreContainingFile", tbIgnoreContainingFile);

				return true;
			}
			else
			{
				LogEntry("ERROR!  Failed to write ini file, invalid path: " + iniPath);
				return false;
			}
		}

		private void WriteIniFileKey(string iniFilename, string section, string key, RichTextBox tb)
		{
			IniFile ini = new IniFile(iniFilename);

			ini.IniWriteValue(
				section
				, key
				, string.Join("|", tb.Lines)
			);

			LogEntry(
				String.Format(
					"Wrote config key value: {0}, {1}"
					, section
					, key
				)
			);
		}

		private bool ReadIniFile()
		{
			string iniPath = Sanitize(lbSource.Text);

			if (Directory.Exists(iniPath))
			{
				string iniFilename = iniPath + @"\IFC.ini";
				bool iniFileExists = File.Exists(iniFilename);

				if (iniFileExists)
				{
					LogEntry("Found config file at " + iniFilename);

					tbIgnoreMatchingDir.Clear();
					tbIgnoreMatchingFile.Clear();
					tbIgnoreContainingDir.Clear();
					tbIgnoreContainingFile.Clear();

					ReadIniFileKey(iniFilename, "Exclusions", "IgnoreMatchingDir", tbIgnoreMatchingDir);
					ReadIniFileKey(iniFilename, "Exclusions", "IgnoreMatchingFile", tbIgnoreMatchingFile);
					ReadIniFileKey(iniFilename, "Exclusions", "IgnoreContainingDir", tbIgnoreContainingDir);
					ReadIniFileKey(iniFilename, "Exclusions", "IgnoreContainingFile", tbIgnoreContainingFile);
					return true;
				}
				else
				{
					LogEntry("INFO! No config file found at: " + iniFilename);
					return false;
				}
			}
			else
			{
				LogEntry("Failed to read ini file, invalid path: " + iniPath);
				return false;
			}
		}


		private void ReadIniFileKey(string iniFilename, string section, string key, RichTextBox tb)
		{
			IniFile ini = new IniFile(iniFilename);

			string content = ini.IniReadValue(
				section
				, key
			);

			string[] contents = content.Split('|');
			foreach (string s in contents)
			{
				AppendLine(tb, s);
			}

			LogEntry(
				String.Format(
					"Read config key value: {0}, {1}"
					,section
					,key
				)
			);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (
				lbSource.Text == awaitingInputText
				|| lbTarget.Text == awaitingInputText
				)
			{
				LogEntry("ERROR!  Please select valid source and target folders.");
				return;
			}
			if (
				string.IsNullOrEmpty(cbHour.Text)
				|| string.IsNullOrEmpty(cbMinute.Text)
				|| string.IsNullOrEmpty(cbSecond.Text)
				|| string.IsNullOrEmpty(cbAMPM.Text)
				)
			{
				LogEntry("ERROR!  Failed to get comparison time.  Please select a valid date and time.");
				return;
			}

			if(
				CheckPathRoot(lbSource.Text) == 1
				|| CheckPathRoot(lbTarget.Text) == 1
			)
			{
				LogEntry("ERROR!  Source and Target cannot be root folders.");
				return;
			}

			btnGo.Enabled = false;

			// set the comparison time

			int hourModifier = 0;

			if (cbAMPM.Text == "PM")
			{
				if(cbHour.Text != "12")
				{
					hourModifier = 12;
				}
			} else
			{
				if(cbHour.Text == "12")
				{
					hourModifier = -12;
				}
			}

			baseDateTime = dateTimePicker.Value.Date.AddHours(
				Convert.ToDouble(cbHour.Text) + hourModifier
			).AddMinutes(
				Convert.ToDouble(cbMinute.Text)
			).AddSeconds(
				Convert.ToDouble(cbSecond.Text)
			);

			LogEntry(
				string.Format(
					"Comparison time for file checking is: {0}"
					, baseDateTime.ToString()
				)
			);

			System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(Sanitize(lbSource.Text));
			WalkDirectoryTree(root);

			btnGo.Enabled = true;
		}

		private string Sanitize (string inStr)
		{
			if (string.IsNullOrWhiteSpace(inStr))
			{
				return awaitingInputText;
			}
			else
			{
				return inStr;
			}
		}

		private void WalkDirectoryTree(System.IO.DirectoryInfo root)
		{
			System.IO.FileInfo[] files = null;
			System.IO.DirectoryInfo[] subDirs = null;

			// First, process all the files directly under this folder
			try
			{
				files = root.GetFiles("*.*");
			}
			// This is thrown if even one of the files requires permissions greater
			// than the application provides.
			catch (UnauthorizedAccessException e)
			{
				// This code just writes out the message and continues to recurse.
				// You may decide to do something different here. For example, you
				// can try to elevate your privileges and access the file again.
				LogEntry(e.Message);
			}

			catch (System.IO.DirectoryNotFoundException e)
			{
				LogEntry(e.Message);
			}

			if (files != null)
			{
				foreach (System.IO.FileInfo fi in files)
				{
					// In this example, we only access the existing FileInfo object. If we
					// want to open, delete or modify the file, then
					// a try-catch block is required here to handle the case
					// where the file has been deleted since the call to TraverseTree().


					if (fi.LastWriteTime.AddTicks(-(fi.LastWriteTime.Ticks % TimeSpan.TicksPerSecond)) > baseDateTime) // discard milliseconds in LastWriteTime
					// check if file older than compare datetime
					{
						// yes
						LogEntry(
							String.Format(
								"Collecting file: {0} [{1}]"
								,fi.FullName
								,fi.LastWriteTime
							)
						);

						// copy the file to target, including paths

						if (CopyFile(fi.FullName, fi.Name))
						{
							LogEntry(
								string.Format(
									"Copied file: {0}"
									, fi.FullName
								)
							);
						}
						else
						{
							LogEntry(
								string.Format(
									"ERROR!  Failed to copy file: {0}"
									, fi.FullName
								)
							);
						}

					} 
					else
					{
						// no
						LogEntry(
							String.Format(
								"Ignoring file: {0} [{1}]"
								, fi.FullName
								, fi.LastWriteTime
							)
						);

					}
				}

				// Now find all the subdirectories under this directory.
				subDirs = root.GetDirectories();

				foreach (System.IO.DirectoryInfo dirInfo in subDirs)
				{
					// Resursive call for each subdirectory.
					WalkDirectoryTree(dirInfo);
				}
			}
		}

		private void cbHour_Leave(object sender, EventArgs e)
		{
			if (
				!ValidateNumberEntry(
					cbHour.Text
					, (int)hours.min
					, (int)hours.max
				)
			)
			{
				cbHour.Text = string.Empty;
			}
		}

		private bool ValidateNumberEntry(string value, int min, int max)
		{
			int valueNum;
			try
			{
				valueNum = Convert.ToInt16(value);
				return (valueNum <= max && valueNum >= min) ? true : false;
			}
			catch
			{
				return false;
			}
		}

			

		private void cbMinute_Leave(object sender, EventArgs e)
		{
			if (
				!ValidateNumberEntry(
					cbMinute.Text
					, (int)minutes.min
					, (int)minutes.max
				)
			)
			{
				cbMinute.Text = string.Empty;
			}
		}

		private void cbSecond_Leave(object sender, EventArgs e)
		{
			if (
				!ValidateNumberEntry(
					cbSecond.Text
					, (int)seconds.min
					, (int)seconds.max
				)
			)
			{
				cbSecond.Text = string.Empty;
			}
		}

		private void cbAMPM_Leave(object sender, EventArgs e)
		{
			if (
				cbAMPM.Text != "AM"
				&& cbAMPM.Text != "PM"
			)
			{
				cbAMPM.Text = string.Empty;
			}

		}

		private bool CopyFile (string sourceFullName, string sourceName)
		{
			if (sourceName == "IFC.ini") return true;

			string targetFilename = sourceFullName.Replace(
				lbSource.Text
				, lbTarget.Text
			);

			//LogEntry("targetfilename = " + targetFilename);

			try {
				DirectoryInfo thePath = Directory.CreateDirectory(targetFilename.Replace('\\' + sourceName, ""));
				File.Copy(
					sourceFullName
					, targetFilename
					, true
				);
				return true;
			}
			catch (Exception e) {
				LogEntry(e.Message);
				return false;
			}
		}

		private int CheckPathRoot (string strPath)
		{
			DirectoryInfo dirInfo;

			try
			{
				dirInfo = new DirectoryInfo(strPath);
			}
			catch (Exception e)
			{
				LogEntry(e.Message);
				return -1;
			}

			if (dirInfo.Name == dirInfo.Root.Name)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}

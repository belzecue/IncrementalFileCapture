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
		private string pleaseSelectText = "Please select...";

		private int filesCopied;
		private int runErrors;

		DateTime resultGetNewestFileDateTime;
		string resultGetNewestFilename;


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

			toolTip1.SetToolTip(lbSource, lbSource.Text);

			if (CheckPathRoot(lbSource.Text) == 0)
			{
				ReadIniFile();
				toolTip1.SetToolTip(lbTarget, lbTarget.Text);
			}
		}

		private void btnTarget_Click(object sender, EventArgs e)
		{
			var targetFolder = new FolderBrowserDialog();
			targetFolder.ShowDialog();
			lbTarget.Text = targetFolder.SelectedPath;

			toolTip1.SetToolTip(lbTarget, lbTarget.Text);

		}

		private void rtbExclusion_Leave(object sender, EventArgs e)
		{
			RichTextBox rtb = sender as RichTextBox;
			rtb.Lines = StripBlankLines(rtb.Lines);

			Label label = this.Controls.Find(rtb.Name.Replace("rtb", "lb"), false)[0] as Label;
			label.Text = UpdateListBoxLabel(rtb, label);
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

		private void UpdateLogLabel(RichTextBox listBox, Label label)
		{
			label.Text = String.Format(
				"{0}: {1}"
				, label.Text.Split(':')[0]
				, runErrors + " errors during last job"
			);
		}

		private void btnSaveConfig_Click(object sender, EventArgs e)
		{
			if (lbSource.Text == pleaseSelectText)
			{
				LogEntry("ERROR!  Please select a valid source folder.");
				return;
			}
			WriteIniFile();

			rtbLog.SelectionStart = rtbLog.Text.Length;
			rtbLog.ScrollToCaret();

		}

		private void LogEntry (string str)
		{
			Color textOrig = rtbLog.SelectionColor;

			if (str.StartsWith("ERROR!"))
			{
				rtbLog.SelectionColor = Color.Red;
			}
			else if (str.StartsWith("INFO*"))
			{
				rtbLog.SelectionColor = Color.Blue;
			}

			AppendLine(
				rtbLog
				, string.Format(
					"{0} {1}"
					, DateTime.Now
					, str
					)
			);

			rtbLog.SelectionColor = textOrig;
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

				WriteIniFileKeyString(iniFilename, "Paths", "sourceDir", lbSource.Text);
				WriteIniFileKeyString(iniFilename, "Paths", "targetDir", lbTarget.Text);
				WriteIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreMatchingDir", rtbIgnoreMatchingDir);
				WriteIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreMatchingDir", rtbIgnoreMatchingDir);
				WriteIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreMatchingFile", rtbIgnoreMatchingFile);
				WriteIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreContainingDir", rtbIgnoreContainingDir);
				WriteIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreContainingFile", rtbIgnoreContainingFile);
				WriteIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreEndingFile", rtbIgnoreEndingFile);

				return true;
			}
			else
			{
				LogEntry("ERROR!  Failed to write ini file, invalid path: " + iniPath);
				runErrors++;
				return false;
			}
		}

		private void WriteIniFileKeyForRTB(string iniFilename, string section, string key, RichTextBox tb)
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

		private void WriteIniFileKeyString(string iniFilename, string section, string key, string value)
		{
			IniFile ini = new IniFile(iniFilename);

			ini.IniWriteValue(
				section
				, key
				, value
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

					rtbIgnoreMatchingDir.Clear();
					rtbIgnoreMatchingFile.Clear();
					rtbIgnoreContainingDir.Clear();
					rtbIgnoreContainingFile.Clear();
					rtbIgnoreEndingFile.Clear();

					ReadIniFileKeyForLabel(iniFilename, "Paths", "sourceDir", lbSource);
					ReadIniFileKeyForLabel(iniFilename, "Paths", "targetDir", lbTarget);
					ReadIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreMatchingDir", rtbIgnoreMatchingDir);
					ReadIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreMatchingFile", rtbIgnoreMatchingFile);
					ReadIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreContainingDir", rtbIgnoreContainingDir);
					ReadIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreContainingFile", rtbIgnoreContainingFile);
					ReadIniFileKeyForRTB(iniFilename, "Exclusions", "IgnoreEndingFile", rtbIgnoreEndingFile);

					return true;
				}
				else
				{
					LogEntry("No config file found at: " + iniFilename);
					return false;
				}
			}
			else
			{
				LogEntry("Failed to read ini file, invalid path: " + iniPath);
				return false;
			}
		}


		private void ReadIniFileKeyForRTB(string iniFilename, string section, string key, RichTextBox rtb)
		{
			IniFile ini = new IniFile(iniFilename);

			string content = ini.IniReadValue(
				section
				, key
			);

			string[] contents = content.Split(
				new string[] { "|" }
				, StringSplitOptions.RemoveEmptyEntries
			);
			foreach (string s in contents)
			{
				if(!string.IsNullOrWhiteSpace(s)) AppendLine(rtb, s);
			}

			rtbExclusion_Leave(rtb, EventArgs.Empty);

			LogEntry(
				String.Format(
					"Read config key value: {0}, {1}"
					,section
					,key
				)
			);
		}

		private void ReadIniFileKeyForLabel(string iniFilename, string section, string key, Label label)
		{
			IniFile ini = new IniFile(iniFilename);

			string result = ini.IniReadValue(
				section
				, key
			);

			label.Text = (Sanitize(result) == pleaseSelectText) ?
				label.Text
				: result
				;

			LogEntry(
				String.Format(
					"Read config key value: {0}, {1}"
					, section
					, key
				)
			);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (
				lbSource.Text == pleaseSelectText
				|| lbTarget.Text == pleaseSelectText
				)
			{
				LogEntry("ERROR!  Please select valid source and target folders.");
				return;
			}
			if (
				string.IsNullOrWhiteSpace(cbHour.Text)
				|| string.IsNullOrWhiteSpace(cbMinute.Text)
				|| string.IsNullOrWhiteSpace(cbSecond.Text)
				|| string.IsNullOrWhiteSpace(cbAMPM.Text)
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

			filesCopied = 0;
			runErrors = 0;

			LogEntry("Starting ----------");

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

			LogEntry("INFO* Files copied: " + filesCopied);
			LogEntry("Error count: " + runErrors);
			LogEntry("---------- Finished.");

			rtbLog.SelectionStart = rtbLog.Text.Length;
			rtbLog.ScrollToCaret();

			UpdateLogLabel(rtbLog, lbLog);
		}

		private string Sanitize (string inStr)
		{
			if (string.IsNullOrWhiteSpace(inStr))
			{
				return pleaseSelectText;
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
			catch (UnauthorizedAccessException e)
			{
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

						int result = CopyFile(fi.FullName, fi.Name);

						if ( result == 0)
						{
							//LogEntry(
							//	string.Format(
							//		"Copied file: {0}"
							//		, fi.FullName
							//	)
							//);
							filesCopied++;
						}
						else if (result == -1)
						{
							LogEntry(
								string.Format(
									"ERROR!  Failed to copy file: {0}"
									, fi.FullName
								)
							);
							runErrors++;
						}
						else if (result == 1)
						{
							LogEntry(
								string.Format(
									"Skipped copying file: {0}"
									, fi.FullName
								)
							);
						}
						else if (result == 2)
						{
							LogEntry(
								string.Format(
									"Skipped copying file [Dir exclusion match]: {0}"
									, fi.FullName
								)
							);
						}
						else if (result == 3)
						{
							LogEntry(
								string.Format(
									"Skipped copying file [Dir exclusion match - contains]: {0}"
									, fi.FullName
								)
							);
						}
						else if (result == 4)
						{
							LogEntry(
								string.Format(
									"Skipped copying file [File exclusion match]: {0}"
									, fi.FullName
								)
							);
						}
						else if (result == 5)
						{
							LogEntry(
								string.Format(
									"Skipped copying file [File exclusion match - contains]: {0}"
									, fi.FullName
								)
							);
						}
						else if (result == 6)
						{
							LogEntry(
								string.Format(
									"Skipped copying file [File exclusion match - ending]: {0}"
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

		private int CopyFile (string sourceFullName, string sourceName)
		{
			// return values
			// -1 = exception; 0 = success; 1 = skipped because IFC.ini match
			// 2 = skipped because directory exclusion exact match
			// 3 = skipped because directory exclusion contains match
			// 4 = skipped because file exclusion exact match
			// 5 = skipped because file exclusion contains match
			// 6 = skipped because file exclusion ending match

			if (sourceName == "IFC.ini") return 1;

			string[] dirMatchList =
				sourceFullName.Replace(
					sourceName
					, string.Empty
				).Replace(
					lbSource.Text
					, string.Empty
				).Split(
					new string[] {@"\"}
					,StringSplitOptions.RemoveEmptyEntries
				);

			// check for directory exclusion exact matches

			if (rtbIgnoreMatchingDir.Lines.Count() > 0)
			{
				foreach (string i in dirMatchList)
				{
					if(rtbIgnoreMatchingDir.Lines.Contains(i))
					{
						return 2;
					}
				}
			}

			// check for directory exclusion contains matches

			if (rtbIgnoreContainingDir.Lines.Count() > 0)
			{
				foreach (string i in dirMatchList)
				{
					foreach (string x in rtbIgnoreContainingDir.Lines)
					{
						if (i.Contains(x))
						{
							return 3;
						}
					}
				}
			}

			// check for file exclusion exact matches

			if (rtbIgnoreMatchingFile.Lines.Count() > 0)
			{
				foreach (string i in rtbIgnoreMatchingFile.Lines)
				{
					if (i == sourceName)
					{
						return 4;
					}
				}
			}

			// check for file exclusion contains matches

			if (rtbIgnoreContainingFile.Lines.Count() > 0)
			{
				foreach (string i in rtbIgnoreContainingFile.Lines)
				{
					if (sourceName.Contains(i))
					{
						return 5;
					}
				}
			}

			// check for file exclusion ending matches

			if (rtbIgnoreEndingFile.Lines.Count() > 0)
			{
				foreach (string i in rtbIgnoreEndingFile.Lines)
				{
					if (sourceName.EndsWith(i))
					{
						return 6;
					}
				}
			}

			string targetFilename = sourceFullName.Replace(
				lbSource.Text
				, lbTarget.Text
			);

			try {
				DirectoryInfo thePath = Directory.CreateDirectory(targetFilename.Replace('\\' + sourceName, ""));
				File.Copy(
					sourceFullName
					, targetFilename
					, true
				);
				return 0;
			}
			catch (Exception e) {
				LogEntry(e.Message);
				return -1;
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

		private void btnScanForNewest_Click(object sender, EventArgs e)
		{
			if (lbSource.Text == pleaseSelectText)
			{
				LogEntry("ERROR!  Please select valid source folder to scan.");
				return;
			}

			if (
				CheckPathRoot(lbSource.Text) == 1
			)
			{
				LogEntry("ERROR!  Source cannot be a root folder.");
				return;
			}

			btnScanForNewest.Enabled = false;


			resultGetNewestFileDateTime = DateTime.MinValue;
			resultGetNewestFilename = "";

			System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(Sanitize(lbSource.Text));

			GetNewestFileTime(root);

			lbScanForNewest.Text = string.Format(
				"{0}{1}{2}"
				,resultGetNewestFileDateTime
				,System.Environment.NewLine
				,resultGetNewestFilename
			);

			toolTip1.SetToolTip(lbScanForNewest, lbScanForNewest.Text);

			btnScanForNewest.Enabled = true;
		}

		private void GetNewestFileTime(DirectoryInfo root)
		{
			System.IO.FileInfo[] files = null;
			System.IO.DirectoryInfo[] subDirs = null;


			// First, process all the files directly under this folder
			try
			{
				files = root.GetFiles("*.*");
			}
			catch (UnauthorizedAccessException e)
			{
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
					if (
						fi.LastWriteTime > resultGetNewestFileDateTime
						&& fi.Name != "IFC.ini"
						)
																													   // check if file older than compare datetime
					{
						// yes
						resultGetNewestFileDateTime = fi.LastWriteTime;
						resultGetNewestFilename = fi.FullName;
					}
				}

				// Now find all the subdirectories under this directory.
				subDirs = root.GetDirectories();

				foreach (System.IO.DirectoryInfo dirInfo in subDirs)
				{
					// Resursive call for each subdirectory.
					GetNewestFileTime(dirInfo);
				}
			}

		}
	}
}

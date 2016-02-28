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
		enum hours : int { max = 12, min = 0}
		enum minutes : int { max = 59, min = 1}
		enum seconds : int { max = 59, min = 1 }

		public Form1()
		{
			InitializeComponent();

			// populate Time hour/min/second dropdowns

			// hours

			for (int i = (int)hours.min; i <= (int)hours.max; i++)
			{
				cbHour.Items.Add(i);
			}

			// minutes

			for (int i = (int)minutes.min; i <= (int)minutes.max; i++)
			{
				cbMinute.Items.Add(i);
			}

			// seconds

			for (int i = (int)seconds.min; i <= (int)seconds.max; i++)
			{
				cbSecond.Items.Add(i);
			}

			// AM/PM

			cbAMPM.Items.Add("AM");
			cbAMPM.Items.Add("PM");




		}

		private void btnSource_Click(object sender, EventArgs e)
		{
			var sourceFolder = new FolderBrowserDialog();
			sourceFolder.ShowDialog();
			lbSource.Text = sourceFolder.SelectedPath;

			ReadIniFile();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnTarget_Click(object sender, EventArgs e)
		{
			var targetFolder = new FolderBrowserDialog();
			targetFolder.ShowDialog();
			lbSource.Text = targetFolder.SelectedPath;
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
			return label.Text.Split(':')[0]
				+ ": "
				+ listBox.Lines.Count();
		}

		private void btnSaveConfig_Click(object sender, EventArgs e)
		{
			WriteIniFileKey(lbSource.Text, "Exclusions", "IgnoreMatchingDir", tbIgnoreMatchingDir);
			WriteIniFileKey(lbSource.Text, "Exclusions", "IgnoreMatchingFile", tbIgnoreMatchingFile);
			WriteIniFileKey(lbSource.Text, "Exclusions", "IgnoreContainingDir", tbIgnoreContainingDir);
			WriteIniFileKey(lbSource.Text, "Exclusions", "IgnoreContainingFile", tbIgnoreContainingFile);
		}

		private void LogEntry (string str)
		{
			AppendLine(
				tbLog, 
				DateTime.Now + " : "
					+ str
			);
		}

		private void AppendLine(RichTextBox source, string str)
		{
			if (source.Text.Length == 0)
				source.Text = str;
			else
				source.AppendText(System.Environment.NewLine + str);
		}

		private bool WriteIniFileKey(string iniPath, string section, string key, RichTextBox tb)
		{
			if (Directory.Exists(iniPath))
			{
				string iniFilename = @iniPath + @"\IFC.ini";
				IniFile ini = new IniFile(iniFilename);
				ini.IniWriteValue(
					section
					, key
					, string.Join("|", tb.Lines)
				);
				LogEntry("Wrote to config file: " + iniFilename + ", " + section + ", " + key);
				return true;
			}
			else
			{
				LogEntry("Failed to write config file, invalid path: " + iniPath);
				return false;
			}
		}

		private void ReadIniFile()
		{
			tbIgnoreMatchingDir.Clear();
			tbIgnoreMatchingFile.Clear();
			tbIgnoreContainingDir.Clear();
			tbIgnoreContainingFile.Clear();

			ReadIniFileKey(lbSource.Text, "Exclusions", "IgnoreMatchingDir", tbIgnoreMatchingDir);
			ReadIniFileKey(lbSource.Text, "Exclusions", "IgnoreMatchingFile", tbIgnoreMatchingFile);
			ReadIniFileKey(lbSource.Text, "Exclusions", "IgnoreContainingDir", tbIgnoreContainingDir);
			ReadIniFileKey(lbSource.Text, "Exclusions", "IgnoreContainingFile", tbIgnoreContainingFile);
		}


		private bool ReadIniFileKey(string iniPath, string section, string key, RichTextBox tb)
		{

			if (Directory.Exists(iniPath))
			{
				string iniFilename = @iniPath + @"\IFC.ini";
				bool iniFileExists = File.Exists(iniFilename);

				if (iniFileExists)
				{
					IniFile ini = new IniFile(iniFilename);

					string content = ini.IniReadValue(
						section
						, key
					);

					string[] contents = content.Split('|');
					foreach (string s in contents)
					{
						tb.AppendText(s + System.Environment.NewLine);
					}

					LogEntry("Read config file: " + iniFilename + ", " + section + ", " + key);
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

		private void btnGo_Click(object sender, EventArgs e)
		{
			System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(@lbSource.Text);
			WalkDirectoryTree(root);
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
					LogEntry(fi.FullName);
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

	}
}

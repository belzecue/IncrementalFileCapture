using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
			lbIgnoreMatchingDir.Text = UpdateListBoxLabel(lbIgnoreMatchingDir.Text);

		}

		private void tbIgnoreMatchingFile_Leave(object sender, EventArgs e)
		{
			tbIgnoreMatchingFile.Lines = StripBlankLines(tbIgnoreMatchingFile.Lines);
			lbIgnoreMatchingFile.Text = UpdateListBoxLabel(lbIgnoreMatchingFile.Text);
		}

		private void tbIgnoreContainingDir_Leave(object sender, EventArgs e)
		{
			tbIgnoreContainingDir.Lines = StripBlankLines(tbIgnoreContainingDir.Lines);
			lbIgnoreContainingDir.Text = UpdateListBoxLabel(lbIgnoreContainingDir.Text);

		}

		private void tbIgnoreContainingFile_Leave(object sender, EventArgs e)
		{
			tbIgnoreContainingFile.Lines = StripBlankLines(tbIgnoreContainingFile.Lines);
			lbIgnoreContainingFile.Text = UpdateListBoxLabel(lbIgnoreContainingFile.Text);
		}

		private string[] StripBlankLines (string[] strList)
		{
			// trim leading and trailing whitespace
			for (int i = 0; i < strList.Length; i++)
			{
				strList[i] = strList[i].Trim();
			}

			// flush any blank lines and make the list distinct
			return strList = strList.Where(
				s => !string.IsNullOrWhiteSpace(s)
			).Distinct().ToArray<string>();

		}

		private string UpdateListBoxLabel (string theString)
		{
			return lbIgnoreMatchingDir.Text.Split(':')[0]
				+ ": "
				+ tbIgnoreMatchingDir.Lines.Count();
		}

	}
}

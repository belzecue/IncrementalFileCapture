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

		private void tbIgnore_Leave(object sender, EventArgs e)
		{
			tbIgnore.Lines = tbIgnore.Lines.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToArray<string>();

			lbIgnoreMatching.Text =
				lbIgnoreMatching.Text.Split(':')[0]
				+ ": "
				+ tbIgnore.Lines.Count();
		}

		private void tbContaining_Leave(object sender, EventArgs e)
		{
			tbContaining.Lines = tbContaining.Lines.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToArray<string>();

			lbIgnoreContaining.Text =
				lbIgnoreContaining.Text.Split(':')[0]
				+ ": "
				+ tbContaining.Lines.Count();
		}
	}
}

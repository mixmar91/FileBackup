using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileBackup
{
	public partial class FileBackup : Form
	{
		public List<string> sourceFilePathList = new List<string>();
		public List<string> destinationFilePathList = new List<string>();
		public FileBackup()
		{
			InitializeComponent();
		}

		private void btnSelectSourcePath_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				openFileDialog.FileNames.ToList().ForEach(file =>
				{
					if (sourceFilePathList.Count > 0 && sourceFilePathList.Contains(file))
					{
						string infoMessage = ($"File {file} already exists in the source list.");
						MessageBox.Show(infoMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						sourceFilePathList.Add(file);
						sourcePathListBox.Items.Add(file);
					}
				});

				var sourceFilePathString = String.Join("\n", sourceFilePathList.ToArray());
			}
		}

		private void btnSelectDestinationPath_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				if (destinationFilePathList.Count > 0 && destinationFilePathList.Contains(folderBrowserDialog.SelectedPath))
				{
					string infoMessage = ($"Path {folderBrowserDialog.SelectedPath} already exists in the destination list.");
					MessageBox.Show(infoMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					destinationFilePathList.Add(folderBrowserDialog.SelectedPath);
					destinationPathListBox.Items.Add(folderBrowserDialog.SelectedPath);
					var destinationFilePathString = String.Join("\n", destinationFilePathList.ToArray());
				}
			}
		}

		private void btnClearSourceList_Click(object sender, EventArgs e)
		{
			sourceFilePathList = new List<string>();
			sourcePathListBox.Items.Clear();
		}

		private void btnClearDestinationList_Click(object sender, EventArgs e)
		{
			destinationFilePathList = new List<string>();
			destinationPathListBox.Items.Clear();
		}
	}
}

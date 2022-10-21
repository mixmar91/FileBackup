
namespace FileBackup
{
	partial class FileBackup
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
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.destinationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.destinationPathListBox = new System.Windows.Forms.ListBox();
			this.btnSelectDestinationPath = new System.Windows.Forms.Button();
			this.btnClearDestinationList = new System.Windows.Forms.Button();
			this.sourceLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.sourcePathListBox = new System.Windows.Forms.ListBox();
			this.btnSelectSourcePath = new System.Windows.Forms.Button();
			this.btnClearSourceList = new System.Windows.Forms.Button();
			this.btnStartBackup = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.destinationLayoutPanel.SuspendLayout();
			this.sourceLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.Multiselect = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnStartBackup, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.36633F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.63366F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 404);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.destinationLayoutPanel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.sourceLayoutPanel, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 351);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// destinationLayoutPanel
			// 
			this.destinationLayoutPanel.ColumnCount = 1;
			this.destinationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.destinationLayoutPanel.Controls.Add(this.destinationPathListBox, 0, 1);
			this.destinationLayoutPanel.Controls.Add(this.btnSelectDestinationPath, 0, 0);
			this.destinationLayoutPanel.Controls.Add(this.btnClearDestinationList, 0, 2);
			this.destinationLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destinationLayoutPanel.Location = new System.Drawing.Point(400, 3);
			this.destinationLayoutPanel.Name = "destinationLayoutPanel";
			this.destinationLayoutPanel.RowCount = 3;
			this.destinationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.destinationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.destinationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.destinationLayoutPanel.Size = new System.Drawing.Size(391, 345);
			this.destinationLayoutPanel.TabIndex = 4;
			// 
			// destinationPathListBox
			// 
			this.destinationPathListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destinationPathListBox.FormattingEnabled = true;
			this.destinationPathListBox.HorizontalScrollbar = true;
			this.destinationPathListBox.Location = new System.Drawing.Point(3, 37);
			this.destinationPathListBox.Name = "destinationPathListBox";
			this.destinationPathListBox.ScrollAlwaysVisible = true;
			this.destinationPathListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.destinationPathListBox.Size = new System.Drawing.Size(385, 270);
			this.destinationPathListBox.TabIndex = 0;
			// 
			// btnSelectDestinationPath
			// 
			this.btnSelectDestinationPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSelectDestinationPath.Location = new System.Drawing.Point(3, 3);
			this.btnSelectDestinationPath.Name = "btnSelectDestinationPath";
			this.btnSelectDestinationPath.Size = new System.Drawing.Size(385, 28);
			this.btnSelectDestinationPath.TabIndex = 1;
			this.btnSelectDestinationPath.Text = "Select Destination Path";
			this.btnSelectDestinationPath.UseVisualStyleBackColor = true;
			this.btnSelectDestinationPath.Click += new System.EventHandler(this.btnSelectDestinationPath_Click);
			// 
			// btnClearDestinationList
			// 
			this.btnClearDestinationList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClearDestinationList.Location = new System.Drawing.Point(3, 313);
			this.btnClearDestinationList.Name = "btnClearDestinationList";
			this.btnClearDestinationList.Size = new System.Drawing.Size(385, 29);
			this.btnClearDestinationList.TabIndex = 2;
			this.btnClearDestinationList.Text = "Clear Destination List";
			this.btnClearDestinationList.UseVisualStyleBackColor = true;
			this.btnClearDestinationList.Click += new System.EventHandler(this.btnClearDestinationList_Click);
			// 
			// sourceLayoutPanel
			// 
			this.sourceLayoutPanel.ColumnCount = 1;
			this.sourceLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.sourceLayoutPanel.Controls.Add(this.sourcePathListBox, 0, 1);
			this.sourceLayoutPanel.Controls.Add(this.btnSelectSourcePath, 0, 0);
			this.sourceLayoutPanel.Controls.Add(this.btnClearSourceList, 0, 2);
			this.sourceLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sourceLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.sourceLayoutPanel.Name = "sourceLayoutPanel";
			this.sourceLayoutPanel.RowCount = 3;
			this.sourceLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.sourceLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.sourceLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.sourceLayoutPanel.Size = new System.Drawing.Size(391, 345);
			this.sourceLayoutPanel.TabIndex = 2;
			// 
			// sourcePathListBox
			// 
			this.sourcePathListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sourcePathListBox.FormattingEnabled = true;
			this.sourcePathListBox.HorizontalScrollbar = true;
			this.sourcePathListBox.Location = new System.Drawing.Point(3, 37);
			this.sourcePathListBox.Name = "sourcePathListBox";
			this.sourcePathListBox.ScrollAlwaysVisible = true;
			this.sourcePathListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.sourcePathListBox.Size = new System.Drawing.Size(385, 270);
			this.sourcePathListBox.TabIndex = 0;
			// 
			// btnSelectSourcePath
			// 
			this.btnSelectSourcePath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSelectSourcePath.Location = new System.Drawing.Point(3, 3);
			this.btnSelectSourcePath.Name = "btnSelectSourcePath";
			this.btnSelectSourcePath.Size = new System.Drawing.Size(385, 28);
			this.btnSelectSourcePath.TabIndex = 1;
			this.btnSelectSourcePath.Text = "Select Source Path";
			this.btnSelectSourcePath.UseVisualStyleBackColor = true;
			this.btnSelectSourcePath.Click += new System.EventHandler(this.btnSelectSourcePath_Click);
			// 
			// btnClearSourceList
			// 
			this.btnClearSourceList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnClearSourceList.Location = new System.Drawing.Point(3, 313);
			this.btnClearSourceList.Name = "btnClearSourceList";
			this.btnClearSourceList.Size = new System.Drawing.Size(385, 29);
			this.btnClearSourceList.TabIndex = 2;
			this.btnClearSourceList.Text = "Clear Source List";
			this.btnClearSourceList.UseVisualStyleBackColor = true;
			this.btnClearSourceList.Click += new System.EventHandler(this.btnClearSourceList_Click);
			// 
			// btnStartBackup
			// 
			this.btnStartBackup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnStartBackup.Location = new System.Drawing.Point(3, 360);
			this.btnStartBackup.Name = "btnStartBackup";
			this.btnStartBackup.Size = new System.Drawing.Size(794, 41);
			this.btnStartBackup.TabIndex = 1;
			this.btnStartBackup.Text = "Start Backup";
			this.btnStartBackup.UseVisualStyleBackColor = true;
			// 
			// FileBackup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 404);
			this.Controls.Add(this.tableLayoutPanel1);
			this.HelpButton = true;
			this.KeyPreview = true;
			this.Name = "FileBackup";
			this.Text = "FileBackup";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.destinationLayoutPanel.ResumeLayout(false);
			this.sourceLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel sourceLayoutPanel;
		private System.Windows.Forms.ListBox sourcePathListBox;
		private System.Windows.Forms.Button btnSelectSourcePath;
		private System.Windows.Forms.Button btnClearSourceList;
		private System.Windows.Forms.Button btnStartBackup;
		private System.Windows.Forms.TableLayoutPanel destinationLayoutPanel;
		private System.Windows.Forms.ListBox destinationPathListBox;
		private System.Windows.Forms.Button btnSelectDestinationPath;
		private System.Windows.Forms.Button btnClearDestinationList;
	}
}


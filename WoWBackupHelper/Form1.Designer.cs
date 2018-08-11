namespace WoWBackupHelper
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxWoWFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSavePath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbBackupWTF = new System.Windows.Forms.CheckBox();
            this.cbBackupInterface = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBoxWoWFolder
            // 
            this.txtBoxWoWFolder.Enabled = false;
            this.txtBoxWoWFolder.Location = new System.Drawing.Point(4, 21);
            this.txtBoxWoWFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxWoWFolder.Name = "txtBoxWoWFolder";
            this.txtBoxWoWFolder.Size = new System.Drawing.Size(241, 20);
            this.txtBoxWoWFolder.TabIndex = 0;
            this.txtBoxWoWFolder.Text = "C:\\Programme\\jkdsjdskjd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WoW folder path";
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.Location = new System.Drawing.Point(5, 200);
            this.btnStartBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(96, 37);
            this.btnStartBackup.TabIndex = 2;
            this.btnStartBackup.Text = "Backup Now";
            this.btnStartBackup.UseVisualStyleBackColor = true;
            this.btnStartBackup.Click += new System.EventHandler(this.btnStartBackup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change path";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "Change path";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Backup destination path";
            // 
            // txtBoxSavePath
            // 
            this.txtBoxSavePath.Enabled = false;
            this.txtBoxSavePath.Location = new System.Drawing.Point(4, 59);
            this.txtBoxSavePath.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSavePath.Name = "txtBoxSavePath";
            this.txtBoxSavePath.Size = new System.Drawing.Size(241, 20);
            this.txtBoxSavePath.TabIndex = 4;
            this.txtBoxSavePath.Text = "C:\\Programme\\jkdsjdskjd";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 267);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnStartBackup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(355, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 172);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(345, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 200);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Restore selected";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.BackupName});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(352, 164);
            this.dataGridView1.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 55;
            // 
            // BackupName
            // 
            this.BackupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BackupName.HeaderText = "Type";
            this.BackupName.Name = "BackupName";
            this.BackupName.ReadOnly = true;
            this.BackupName.Width = 56;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbBackupWTF);
            this.tabPage2.Controls.Add(this.cbBackupInterface);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtBoxWoWFolder);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBoxSavePath);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(355, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbBackupWTF
            // 
            this.cbBackupWTF.AutoSize = true;
            this.cbBackupWTF.Location = new System.Drawing.Point(5, 125);
            this.cbBackupWTF.Name = "cbBackupWTF";
            this.cbBackupWTF.Size = new System.Drawing.Size(207, 17);
            this.cbBackupWTF.TabIndex = 8;
            this.cbBackupWTF.Text = "Backup WTF folder (contains settings)";
            this.cbBackupWTF.UseVisualStyleBackColor = true;
            // 
            // cbBackupInterface
            // 
            this.cbBackupInterface.AutoSize = true;
            this.cbBackupInterface.Location = new System.Drawing.Point(5, 102);
            this.cbBackupInterface.Name = "cbBackupInterface";
            this.cbBackupInterface.Size = new System.Drawing.Size(225, 17);
            this.cbBackupInterface.TabIndex = 7;
            this.cbBackupInterface.Text = "Backup Interface folder (contains Addons)";
            this.cbBackupInterface.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 278);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "WoWBackupHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBoxWoWFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartBackup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSavePath;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cbBackupWTF;
        private System.Windows.Forms.CheckBox cbBackupInterface;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackupName;
    }
}


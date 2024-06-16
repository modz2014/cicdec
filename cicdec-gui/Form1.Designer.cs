namespace CicdecWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkDumpBlocks = new System.Windows.Forms.CheckBox();
            this.chkDumpFileBlock = new System.Windows.Forms.CheckBox();
            this.chkSimulate = new System.Windows.Forms.CheckBox();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(326, 12);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 0;
            this.btnBrowseInput.Text = "Browse...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(12, 14);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(308, 20);
            this.txtInputFile.TabIndex = 1;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(326, 41);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 2;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(12, 43);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(308, 20);
            this.txtOutputDirectory.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(389, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Extraction";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkDumpBlocks
            // 
            this.chkDumpBlocks.AutoSize = true;
            this.chkDumpBlocks.Location = new System.Drawing.Point(12, 69);
            this.chkDumpBlocks.Name = "chkDumpBlocks";
            this.chkDumpBlocks.Size = new System.Drawing.Size(85, 17);
            this.chkDumpBlocks.TabIndex = 5;
            this.chkDumpBlocks.Text = "Dump Blocks";
            this.chkDumpBlocks.UseVisualStyleBackColor = true;
            // 
            // chkDumpFileBlock
            // 
            this.chkDumpFileBlock.AutoSize = true;
            this.chkDumpFileBlock.Location = new System.Drawing.Point(103, 69);
            this.chkDumpFileBlock.Name = "chkDumpFileBlock";
            this.chkDumpFileBlock.Size = new System.Drawing.Size(102, 17);
            this.chkDumpFileBlock.TabIndex = 6;
            this.chkDumpFileBlock.Text = "Dump File Block";
            this.chkDumpFileBlock.UseVisualStyleBackColor = true;
            // 
            // chkSimulate
            // 
            this.chkSimulate.AutoSize = true;
            this.chkSimulate.Location = new System.Drawing.Point(211, 69);
            this.chkSimulate.Name = "chkSimulate";
            this.chkSimulate.Size = new System.Drawing.Size(66, 17);
            this.chkSimulate.TabIndex = 7;
            this.chkSimulate.Text = "Simulate";
            this.chkSimulate.UseVisualStyleBackColor = true;
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(12, 157);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(389, 182);
            this.txtMessages.TabIndex = 8;
            this.txtMessages.Text = "";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(283, 66);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(118, 20);
            this.txtVersion.TabIndex = 9;
            this.txtVersion.Text = "Version 3.0.1";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(413, 351);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.chkSimulate);
            this.Controls.Add(this.chkDumpFileBlock);
            this.Controls.Add(this.chkDumpBlocks);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.btnBrowseInput);
            this.Name = "MainForm";
            this.Text = "Cicdec WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chkDumpBlocks;
        private System.Windows.Forms.CheckBox chkDumpFileBlock;
        private System.Windows.Forms.CheckBox chkSimulate;
        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.TextBox txtVersion;
    }
}

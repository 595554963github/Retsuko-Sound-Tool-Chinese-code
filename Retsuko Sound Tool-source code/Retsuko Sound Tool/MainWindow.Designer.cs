namespace Retsuko_Sound_Tool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.extractButton = new System.Windows.Forms.Button();
            this.changeDirectoryButton = new System.Windows.Forms.Button();
            this.directoryExtractPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changeFileButton = new System.Windows.Forms.Button();
            this.fileToExtractBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.injectButton = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.changeFileToInjectButton = new System.Windows.Forms.Button();
            this.fileToInjectMap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.changeSourceButton = new System.Windows.Forms.Button();
            this.sourceFileBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.changeMapButton = new System.Windows.Forms.Button();
            this.mapFileBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.mapSelector = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.extractButton);
            this.splitContainer1.Panel1.Controls.Add(this.changeDirectoryButton);
            this.splitContainer1.Panel1.Controls.Add(this.directoryExtractPath);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.changeFileButton);
            this.splitContainer1.Panel1.Controls.Add(this.fileToExtractBox);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.injectButton);
            this.splitContainer1.Panel2.Controls.Add(this.fileBox);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.changeFileToInjectButton);
            this.splitContainer1.Panel2.Controls.Add(this.fileToInjectMap);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.changeSourceButton);
            this.splitContainer1.Panel2.Controls.Add(this.sourceFileBox);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.changeMapButton);
            this.splitContainer1.Panel2.Controls.Add(this.mapFileBox);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(584, 311);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // extractButton
            // 
            this.extractButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extractButton.Location = new System.Drawing.Point(15, 266);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(254, 31);
            this.extractButton.TabIndex = 7;
            this.extractButton.Text = "提取!";
            this.toolTip.SetToolTip(this.extractButton, "提取文件!");
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // changeDirectoryButton
            // 
            this.changeDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeDirectoryButton.Location = new System.Drawing.Point(82, 193);
            this.changeDirectoryButton.Name = "changeDirectoryButton";
            this.changeDirectoryButton.Size = new System.Drawing.Size(126, 23);
            this.changeDirectoryButton.TabIndex = 6;
            this.changeDirectoryButton.Text = "更改目录";
            this.toolTip.SetToolTip(this.changeDirectoryButton, "所以你不必手动输入目录路径.");
            this.changeDirectoryButton.UseVisualStyleBackColor = true;
            this.changeDirectoryButton.Click += new System.EventHandler(this.changeDirectoryButton_Click);
            // 
            // directoryExtractPath
            // 
            this.directoryExtractPath.Location = new System.Drawing.Point(133, 167);
            this.directoryExtractPath.Name = "directoryExtractPath";
            this.directoryExtractPath.Size = new System.Drawing.Size(138, 20);
            this.directoryExtractPath.TabIndex = 5;
            this.toolTip.SetToolTip(this.directoryExtractPath, "应制作包含不同声音文件的文件夹的目录.");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "要提取到的目录";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeFileButton
            // 
            this.changeFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeFileButton.Location = new System.Drawing.Point(91, 92);
            this.changeFileButton.Name = "changeFileButton";
            this.changeFileButton.Size = new System.Drawing.Size(85, 23);
            this.changeFileButton.TabIndex = 3;
            this.changeFileButton.Text = "更改文件";
            this.toolTip.SetToolTip(this.changeFileButton, "所以你不必手动输入文件路径.");
            this.changeFileButton.UseVisualStyleBackColor = true;
            this.changeFileButton.Click += new System.EventHandler(this.changeFileButton_Click);
            // 
            // fileToExtractBox
            // 
            this.fileToExtractBox.Location = new System.Drawing.Point(82, 66);
            this.fileToExtractBox.Name = "fileToExtractBox";
            this.fileToExtractBox.Size = new System.Drawing.Size(189, 20);
            this.fileToExtractBox.TabIndex = 2;
            this.toolTip.SetToolTip(this.fileToExtractBox, "包含要提取的音乐/声音相关文件的文件路径和“+”生成地图.");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(0, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "要提取的文件:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "提取器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // injectButton
            // 
            this.injectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.injectButton.Location = new System.Drawing.Point(19, 267);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(116, 31);
            this.injectButton.TabIndex = 18;
            this.injectButton.Text = "注入新文件!";
            this.toolTip.SetToolTip(this.injectButton, "仅注入要在要复制的文件上注入的文件.");
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // fileBox
            // 
            this.fileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileBox.DropDownWidth = 450;
            this.fileBox.Enabled = false;
            this.fileBox.FormattingEnabled = true;
            this.fileBox.Location = new System.Drawing.Point(103, 227);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(188, 21);
            this.fileBox.TabIndex = 17;
            this.toolTip.SetToolTip(this.fileBox, "仅在注入新文件时才需要\r\n它是您想要的源文件中的文件"+"t 要替换的新文件.");
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(16, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "要替换的文件";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeFileToInjectButton
            // 
            this.changeFileToInjectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeFileToInjectButton.Location = new System.Drawing.Point(103, 195);
            this.changeFileToInjectButton.Name = "changeFileToInjectButton";
            this.changeFileToInjectButton.Size = new System.Drawing.Size(88, 23);
            this.changeFileToInjectButton.TabIndex = 15;
            this.changeFileToInjectButton.Text = "更改文件";
            this.toolTip.SetToolTip(this.changeFileToInjectButton, "所以你不必手动输入新文件的路径.");
            this.changeFileToInjectButton.UseVisualStyleBackColor = true;
            this.changeFileToInjectButton.Click += new System.EventHandler(this.changeFileToInjectButton_Click);
            // 
            // fileToInjectMap
            // 
            this.fileToInjectMap.Location = new System.Drawing.Point(86, 169);
            this.fileToInjectMap.Name = "fileToInjectMap";
            this.fileToInjectMap.Size = new System.Drawing.Size(197, 20);
            this.fileToInjectMap.TabIndex = 14;
            this.toolTip.SetToolTip(this.fileToInjectMap, "仅在注入新文件时才需要.\r\n这是您想要的新文件的路径" +
        "o 注入,以防您只想注入一个文件而不必注入所有文件" +
        " 它们.");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(16, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "要注入的文件";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeSourceButton
            // 
            this.changeSourceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeSourceButton.Location = new System.Drawing.Point(86, 128);
            this.changeSourceButton.Name = "changeSourceButton";
            this.changeSourceButton.Size = new System.Drawing.Size(121, 23);
            this.changeSourceButton.TabIndex = 12;
            this.changeSourceButton.Text = "更换源";
            this.toolTip.SetToolTip(this.changeSourceButton, "所以你不必手动输入源文件路径.");
            this.changeSourceButton.UseVisualStyleBackColor = true;
            this.changeSourceButton.Click += new System.EventHandler(this.changeSourceButton_Click);
            // 
            // sourceFileBox
            // 
            this.sourceFileBox.Location = new System.Drawing.Point(78, 102);
            this.sourceFileBox.Name = "sourceFileBox";
            this.sourceFileBox.Size = new System.Drawing.Size(205, 20);
            this.sourceFileBox.TabIndex = 11;
            this.toolTip.SetToolTip(this.sourceFileBox, resources.GetString("sourceFileBox.ToolTip"));
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "源文件";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeMapButton
            // 
            this.changeMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeMapButton.Location = new System.Drawing.Point(103, 61);
            this.changeMapButton.Name = "changeMapButton";
            this.changeMapButton.Size = new System.Drawing.Size(88, 23);
            this.changeMapButton.TabIndex = 9;
            this.changeMapButton.Text = "更换映射";
            this.toolTip.SetToolTip(this.changeMapButton, "所以你不必手动输入映射文件路径/");
            this.changeMapButton.UseVisualStyleBackColor = true;
            this.changeMapButton.Click += new System.EventHandler(this.changeMapButton_Click);
            // 
            // mapFileBox
            // 
            this.mapFileBox.Location = new System.Drawing.Point(67, 37);
            this.mapFileBox.Name = "mapFileBox";
            this.mapFileBox.Size = new System.Drawing.Size(216, 20);
            this.mapFileBox.TabIndex = 8;
            this.toolTip.SetToolTip(this.mapFileBox, "所有注入都需要功能.\r\n从源文件生成的映像文件的路径" +
        "ce file.\r\n丢失fileMap.txt将需要新的提取.");
            this.mapFileBox.TextChanged += new System.EventHandler(this.mapFileBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "映射文件";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "注入器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // fileSelector
            // 
            this.fileSelector.Filter = "File Containing WiiU/3ds Sound|*";
            this.fileSelector.RestoreDirectory = true;
            // 
            // mapSelector
            // 
            this.mapSelector.Filter = "Retsuko文件映射|*.txt";
            this.mapSelector.RestoreDirectory = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(161, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "注入所有文件!";
            this.toolTip.SetToolTip(this.button1, "注入映射文件指定的所有文件.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100000;
            this.toolTip.AutoPopDelay = 15000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 100;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Retsuko音频提取器/注入器";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileToExtractBox;
        private System.Windows.Forms.Button changeFileButton;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Button changeDirectoryButton;
        private System.Windows.Forms.TextBox directoryExtractPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog fileSelector;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button changeFileToInjectButton;
        private System.Windows.Forms.TextBox fileToInjectMap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeSourceButton;
        private System.Windows.Forms.TextBox sourceFileBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changeMapButton;
        private System.Windows.Forms.TextBox mapFileBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fileBox;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.OpenFileDialog mapSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

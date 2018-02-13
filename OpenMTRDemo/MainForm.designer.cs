namespace OpenMTRDemo
{
    partial class MainForm
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
            this.InputImageBox = new System.Windows.Forms.PictureBox();
            this.OutputImageBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metaDataLabel = new System.Windows.Forms.Label();
            this.MetaDataTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.edgeFindingBox = new System.Windows.Forms.GroupBox();
            this.CannyThreshold2Slider = new System.Windows.Forms.TrackBar();
            this.CannyThreshold1Slider = new System.Windows.Forms.TrackBar();
            this.CannyThreshold2Number = new System.Windows.Forms.NumericUpDown();
            this.CannyThreshold1Number = new System.Windows.Forms.NumericUpDown();
            this.FilterListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cannyRadio = new System.Windows.Forms.RadioButton();
            this.sobelRadio = new System.Windows.Forms.RadioButton();
            this.cannySettingsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.InputImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.edgeFindingBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Number)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.cannySettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputImageBox
            // 
            this.InputImageBox.Location = new System.Drawing.Point(12, 31);
            this.InputImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputImageBox.Name = "InputImageBox";
            this.InputImageBox.Size = new System.Drawing.Size(320, 240);
            this.InputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputImageBox.TabIndex = 0;
            this.InputImageBox.TabStop = false;
            // 
            // OutputImageBox
            // 
            this.OutputImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputImageBox.Location = new System.Drawing.Point(12, 319);
            this.OutputImageBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputImageBox.Name = "OutputImageBox";
            this.OutputImageBox.Size = new System.Drawing.Size(668, 501);
            this.OutputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputImageBox.TabIndex = 1;
            this.OutputImageBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.loadToolStripMenuItem.Text = "Open";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Enabled = false;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // metaDataLabel
            // 
            this.metaDataLabel.AutoSize = true;
            this.metaDataLabel.Location = new System.Drawing.Point(15, 286);
            this.metaDataLabel.Name = "metaDataLabel";
            this.metaDataLabel.Size = new System.Drawing.Size(86, 17);
            this.metaDataLabel.TabIndex = 1;
            this.metaDataLabel.Text = "Meter Read:";
            // 
            // MetaDataTextBox
            // 
            this.MetaDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetaDataTextBox.Location = new System.Drawing.Point(104, 286);
            this.MetaDataTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MetaDataTextBox.Name = "MetaDataTextBox";
            this.MetaDataTextBox.ReadOnly = true;
            this.MetaDataTextBox.Size = new System.Drawing.Size(227, 15);
            this.MetaDataTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.HeightTextBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.WidthTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(333, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Properties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightTextBox.Location = new System.Drawing.Point(69, 33);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.Size = new System.Drawing.Size(167, 15);
            this.HeightTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.BackColor = System.Drawing.Color.White;
            this.WidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WidthTextBox.Location = new System.Drawing.Point(69, 17);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.ReadOnly = true;
            this.WidthTextBox.Size = new System.Drawing.Size(167, 15);
            this.WidthTextBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.edgeFindingBox);
            this.tabPage1.Controls.Add(this.FilterListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(333, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // edgeFindingBox
            // 
            this.edgeFindingBox.Controls.Add(this.cannySettingsPanel);
            this.edgeFindingBox.Controls.Add(this.sobelRadio);
            this.edgeFindingBox.Controls.Add(this.cannyRadio);
            this.edgeFindingBox.Enabled = false;
            this.edgeFindingBox.Location = new System.Drawing.Point(7, 82);
            this.edgeFindingBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edgeFindingBox.Name = "edgeFindingBox";
            this.edgeFindingBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edgeFindingBox.Size = new System.Drawing.Size(317, 149);
            this.edgeFindingBox.TabIndex = 2;
            this.edgeFindingBox.TabStop = false;
            this.edgeFindingBox.Text = "Edge Finding";
            // 
            // CannyThreshold2Slider
            // 
            this.CannyThreshold2Slider.BackColor = System.Drawing.Color.White;
            this.CannyThreshold2Slider.LargeChange = 50;
            this.CannyThreshold2Slider.Location = new System.Drawing.Point(4, 36);
            this.CannyThreshold2Slider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CannyThreshold2Slider.Maximum = 255;
            this.CannyThreshold2Slider.Name = "CannyThreshold2Slider";
            this.CannyThreshold2Slider.Size = new System.Drawing.Size(244, 56);
            this.CannyThreshold2Slider.TabIndex = 5;
            this.CannyThreshold2Slider.TickFrequency = 17;
            this.CannyThreshold2Slider.Value = 150;
            this.CannyThreshold2Slider.Scroll += new System.EventHandler(this.cannyThreshold2Slider_Scroll);
            // 
            // CannyThreshold1Slider
            // 
            this.CannyThreshold1Slider.BackColor = System.Drawing.Color.White;
            this.CannyThreshold1Slider.LargeChange = 50;
            this.CannyThreshold1Slider.Location = new System.Drawing.Point(4, 4);
            this.CannyThreshold1Slider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CannyThreshold1Slider.Maximum = 255;
            this.CannyThreshold1Slider.Name = "CannyThreshold1Slider";
            this.CannyThreshold1Slider.Size = new System.Drawing.Size(244, 56);
            this.CannyThreshold1Slider.TabIndex = 4;
            this.CannyThreshold1Slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.CannyThreshold1Slider.Value = 100;
            this.CannyThreshold1Slider.Scroll += new System.EventHandler(this.cannyThreshold1Slider_Scroll);
            // 
            // CannyThreshold2Number
            // 
            this.CannyThreshold2Number.Location = new System.Drawing.Point(256, 36);
            this.CannyThreshold2Number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CannyThreshold2Number.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CannyThreshold2Number.Name = "CannyThreshold2Number";
            this.CannyThreshold2Number.Size = new System.Drawing.Size(56, 22);
            this.CannyThreshold2Number.TabIndex = 3;
            this.CannyThreshold2Number.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.CannyThreshold2Number.ValueChanged += new System.EventHandler(this.cannyThreshold2Number_ValueChanged);
            // 
            // CannyThreshold1Number
            // 
            this.CannyThreshold1Number.Location = new System.Drawing.Point(256, 4);
            this.CannyThreshold1Number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CannyThreshold1Number.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.CannyThreshold1Number.Name = "CannyThreshold1Number";
            this.CannyThreshold1Number.Size = new System.Drawing.Size(56, 22);
            this.CannyThreshold1Number.TabIndex = 1;
            this.CannyThreshold1Number.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CannyThreshold1Number.ValueChanged += new System.EventHandler(this.cannyThreshold1Number_ValueChanged);
            // 
            // FilterListBox
            // 
            this.FilterListBox.Enabled = false;
            this.FilterListBox.FormattingEnabled = true;
            this.FilterListBox.ItemHeight = 16;
            this.FilterListBox.Items.AddRange(new object[] {
            "Gaussian Blur",
            "Black and White",
            "Edge Finding"});
            this.FilterListBox.Location = new System.Drawing.Point(7, 6);
            this.FilterListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilterListBox.Name = "FilterListBox";
            this.FilterListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.FilterListBox.Size = new System.Drawing.Size(316, 68);
            this.FilterListBox.TabIndex = 0;
            this.FilterListBox.SelectedIndexChanged += new System.EventHandler(this.filterListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(339, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 272);
            this.tabControl1.TabIndex = 3;
            // 
            // cannyRadio
            // 
            this.cannyRadio.AutoSize = true;
            this.cannyRadio.Checked = true;
            this.cannyRadio.Location = new System.Drawing.Point(8, 22);
            this.cannyRadio.Name = "cannyRadio";
            this.cannyRadio.Size = new System.Drawing.Size(69, 21);
            this.cannyRadio.TabIndex = 6;
            this.cannyRadio.TabStop = true;
            this.cannyRadio.Text = "Canny";
            this.cannyRadio.UseVisualStyleBackColor = true;
            this.cannyRadio.CheckedChanged += new System.EventHandler(this.cannyRadio_CheckedChanged);
            // 
            // sobelRadio
            // 
            this.sobelRadio.AutoSize = true;
            this.sobelRadio.Location = new System.Drawing.Point(83, 22);
            this.sobelRadio.Name = "sobelRadio";
            this.sobelRadio.Size = new System.Drawing.Size(65, 21);
            this.sobelRadio.TabIndex = 7;
            this.sobelRadio.Text = "Sobel";
            this.sobelRadio.UseVisualStyleBackColor = true;
            // 
            // cannySettingsPanel
            // 
            this.cannySettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold2Slider);
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold1Slider);
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold1Number);
            this.cannySettingsPanel.Controls.Add(this.CannyThreshold2Number);
            this.cannySettingsPanel.Location = new System.Drawing.Point(1, 49);
            this.cannySettingsPanel.Name = "cannySettingsPanel";
            this.cannySettingsPanel.Size = new System.Drawing.Size(316, 93);
            this.cannySettingsPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 831);
            this.Controls.Add(this.metaDataLabel);
            this.Controls.Add(this.MetaDataTextBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OutputImageBox);
            this.Controls.Add(this.InputImageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "OpenMTR Demo";
            ((System.ComponentModel.ISupportInitialize)(this.InputImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.edgeFindingBox.ResumeLayout(false);
            this.edgeFindingBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold2Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CannyThreshold1Number)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.cannySettingsPanel.ResumeLayout(false);
            this.cannySettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InputImageBox;
        private System.Windows.Forms.PictureBox OutputImageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Label metaDataLabel;
        private System.Windows.Forms.TextBox MetaDataTextBox;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox edgeFindingBox;
        private System.Windows.Forms.TrackBar CannyThreshold2Slider;
        private System.Windows.Forms.TrackBar CannyThreshold1Slider;
        private System.Windows.Forms.NumericUpDown CannyThreshold2Number;
        private System.Windows.Forms.NumericUpDown CannyThreshold1Number;
        private System.Windows.Forms.ListBox FilterListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.RadioButton sobelRadio;
        private System.Windows.Forms.RadioButton cannyRadio;
        private System.Windows.Forms.Panel cannySettingsPanel;
    }
}


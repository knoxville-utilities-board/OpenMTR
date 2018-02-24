namespace OpenMTRDemo.Forms
{
    partial class TiledFiltersForm
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
            this.pictureBoxSource = new System.Windows.Forms.PictureBox();
            this.pictureBoxGray = new System.Windows.Forms.PictureBox();
            this.pictureBoxCanny = new System.Windows.Forms.PictureBox();
            this.pictureBoxSobel = new System.Windows.Forms.PictureBox();
            this.pictureBoxLaplace = new System.Windows.Forms.PictureBox();
            this.pictureBoxScharr = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxFiltering = new System.Windows.Forms.GroupBox();
            this.groupBoxBlur = new System.Windows.Forms.GroupBox();
            this.checkBoxEqualize = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxGuassianBlur = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPane1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPane2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPane3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPane4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPane5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPane6 = new System.Windows.Forms.PictureBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelGray = new System.Windows.Forms.Label();
            this.labelCanny = new System.Windows.Forms.Label();
            this.labelLaplace = new System.Windows.Forms.Label();
            this.labelSobel = new System.Windows.Forms.Label();
            this.labelPane1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPane6 = new System.Windows.Forms.Label();
            this.labelScharr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSobel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScharr)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxBlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSource
            // 
            this.pictureBoxSource.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSource.Name = "pictureBoxSource";
            this.pictureBoxSource.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSource.TabIndex = 5;
            this.pictureBoxSource.TabStop = false;
            this.pictureBoxSource.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxGray
            // 
            this.pictureBoxGray.Location = new System.Drawing.Point(319, 3);
            this.pictureBoxGray.Name = "pictureBoxGray";
            this.pictureBoxGray.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGray.TabIndex = 6;
            this.pictureBoxGray.TabStop = false;
            this.pictureBoxGray.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxCanny
            // 
            this.pictureBoxCanny.Location = new System.Drawing.Point(635, 3);
            this.pictureBoxCanny.Name = "pictureBoxCanny";
            this.pictureBoxCanny.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxCanny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCanny.TabIndex = 7;
            this.pictureBoxCanny.TabStop = false;
            this.pictureBoxCanny.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxSobel
            // 
            this.pictureBoxSobel.Location = new System.Drawing.Point(1267, 3);
            this.pictureBoxSobel.Name = "pictureBoxSobel";
            this.pictureBoxSobel.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxSobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSobel.TabIndex = 8;
            this.pictureBoxSobel.TabStop = false;
            this.pictureBoxSobel.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxLaplace
            // 
            this.pictureBoxLaplace.Location = new System.Drawing.Point(951, 3);
            this.pictureBoxLaplace.Name = "pictureBoxLaplace";
            this.pictureBoxLaplace.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxLaplace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLaplace.TabIndex = 9;
            this.pictureBoxLaplace.TabStop = false;
            this.pictureBoxLaplace.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxScharr
            // 
            this.pictureBoxScharr.Location = new System.Drawing.Point(1583, 3);
            this.pictureBoxScharr.Name = "pictureBoxScharr";
            this.pictureBoxScharr.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxScharr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScharr.TabIndex = 10;
            this.pictureBoxScharr.TabStop = false;
            this.pictureBoxScharr.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxSource);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxGray);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxCanny);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxLaplace);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxSobel);
            this.flowLayoutPanel1.Controls.Add(this.pictureBoxScharr);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 46);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1896, 246);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.groupBoxFiltering);
            this.panel1.Controls.Add(this.groupBoxBlur);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1896, 160);
            this.panel1.TabIndex = 12;
            // 
            // groupBoxFiltering
            // 
            this.groupBoxFiltering.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBoxFiltering.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltering.Location = new System.Drawing.Point(311, 4);
            this.groupBoxFiltering.Name = "groupBoxFiltering";
            this.groupBoxFiltering.Size = new System.Drawing.Size(1573, 153);
            this.groupBoxFiltering.TabIndex = 2;
            this.groupBoxFiltering.TabStop = false;
            this.groupBoxFiltering.Text = "Filtering";
            // 
            // groupBoxBlur
            // 
            this.groupBoxBlur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBoxBlur.Controls.Add(this.checkBoxEqualize);
            this.groupBoxBlur.Controls.Add(this.label6);
            this.groupBoxBlur.Controls.Add(this.numericUpDown2);
            this.groupBoxBlur.Controls.Add(this.label1);
            this.groupBoxBlur.Controls.Add(this.numericUpDown1);
            this.groupBoxBlur.Controls.Add(this.checkBoxGuassianBlur);
            this.groupBoxBlur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBlur.Location = new System.Drawing.Point(115, 4);
            this.groupBoxBlur.Name = "groupBoxBlur";
            this.groupBoxBlur.Size = new System.Drawing.Size(200, 153);
            this.groupBoxBlur.TabIndex = 1;
            this.groupBoxBlur.TabStop = false;
            this.groupBoxBlur.Text = "Blur";
            // 
            // checkBoxEqualize
            // 
            this.checkBoxEqualize.AutoSize = true;
            this.checkBoxEqualize.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEqualize.Location = new System.Drawing.Point(7, 38);
            this.checkBoxEqualize.Name = "checkBoxEqualize";
            this.checkBoxEqualize.Size = new System.Drawing.Size(82, 19);
            this.checkBoxEqualize.TabIndex = 5;
            this.checkBoxEqualize.Text = "Equalize";
            this.checkBoxEqualize.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Size width";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(6, 123);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size height";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 97);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkBoxGuassianBlur
            // 
            this.checkBoxGuassianBlur.AutoSize = true;
            this.checkBoxGuassianBlur.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGuassianBlur.Location = new System.Drawing.Point(7, 13);
            this.checkBoxGuassianBlur.Name = "checkBoxGuassianBlur";
            this.checkBoxGuassianBlur.Size = new System.Drawing.Size(117, 19);
            this.checkBoxGuassianBlur.TabIndex = 0;
            this.checkBoxGuassianBlur.Text = "Guassian Blur";
            this.checkBoxGuassianBlur.UseVisualStyleBackColor = true;
            this.checkBoxGuassianBlur.CheckedChanged += new System.EventHandler(this.checkBoxGuassianBlur_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxPane1);
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxPane2);
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxPane3);
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxPane4);
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxPane5);
            this.flowLayoutPanel2.Controls.Add(this.pictureBoxPane6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 303);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1896, 246);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // pictureBoxPane1
            // 
            this.pictureBoxPane1.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPane1.Name = "pictureBoxPane1";
            this.pictureBoxPane1.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxPane1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPane1.TabIndex = 5;
            this.pictureBoxPane1.TabStop = false;
            this.pictureBoxPane1.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxPane2
            // 
            this.pictureBoxPane2.Location = new System.Drawing.Point(319, 3);
            this.pictureBoxPane2.Name = "pictureBoxPane2";
            this.pictureBoxPane2.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxPane2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPane2.TabIndex = 6;
            this.pictureBoxPane2.TabStop = false;
            this.pictureBoxPane2.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxPane3
            // 
            this.pictureBoxPane3.Location = new System.Drawing.Point(635, 3);
            this.pictureBoxPane3.Name = "pictureBoxPane3";
            this.pictureBoxPane3.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxPane3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPane3.TabIndex = 7;
            this.pictureBoxPane3.TabStop = false;
            this.pictureBoxPane3.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxPane4
            // 
            this.pictureBoxPane4.Location = new System.Drawing.Point(951, 3);
            this.pictureBoxPane4.Name = "pictureBoxPane4";
            this.pictureBoxPane4.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxPane4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPane4.TabIndex = 9;
            this.pictureBoxPane4.TabStop = false;
            this.pictureBoxPane4.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxPane5
            // 
            this.pictureBoxPane5.Location = new System.Drawing.Point(1267, 3);
            this.pictureBoxPane5.Name = "pictureBoxPane5";
            this.pictureBoxPane5.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxPane5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPane5.TabIndex = 8;
            this.pictureBoxPane5.TabStop = false;
            this.pictureBoxPane5.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // pictureBoxPane6
            // 
            this.pictureBoxPane6.Location = new System.Drawing.Point(1583, 3);
            this.pictureBoxPane6.Name = "pictureBoxPane6";
            this.pictureBoxPane6.Size = new System.Drawing.Size(310, 240);
            this.pictureBoxPane6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPane6.TabIndex = 10;
            this.pictureBoxPane6.TabStop = false;
            this.pictureBoxPane6.DoubleClick += new System.EventHandler(this.Pane_DblClickHandler);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSource.Location = new System.Drawing.Point(97, 24);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(117, 19);
            this.labelSource.TabIndex = 14;
            this.labelSource.Text = "Source Image";
            // 
            // labelGray
            // 
            this.labelGray.AutoSize = true;
            this.labelGray.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGray.Location = new System.Drawing.Point(426, 24);
            this.labelGray.Name = "labelGray";
            this.labelGray.Size = new System.Drawing.Size(99, 19);
            this.labelGray.TabIndex = 15;
            this.labelGray.Text = "Gray Image";
            // 
            // labelCanny
            // 
            this.labelCanny.AutoSize = true;
            this.labelCanny.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCanny.Location = new System.Drawing.Point(730, 24);
            this.labelCanny.Name = "labelCanny";
            this.labelCanny.Size = new System.Drawing.Size(108, 19);
            this.labelCanny.TabIndex = 16;
            this.labelCanny.Text = "Canny Image";
            // 
            // labelLaplace
            // 
            this.labelLaplace.AutoSize = true;
            this.labelLaplace.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaplace.Location = new System.Drawing.Point(1035, 24);
            this.labelLaplace.Name = "labelLaplace";
            this.labelLaplace.Size = new System.Drawing.Size(144, 19);
            this.labelLaplace.TabIndex = 17;
            this.labelLaplace.Text = "Laplacian Image";
            // 
            // labelSobel
            // 
            this.labelSobel.AutoSize = true;
            this.labelSobel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobel.Location = new System.Drawing.Point(1353, 24);
            this.labelSobel.Name = "labelSobel";
            this.labelSobel.Size = new System.Drawing.Size(108, 19);
            this.labelSobel.TabIndex = 18;
            this.labelSobel.Text = "Sobel Image";
            // 
            // labelPane1
            // 
            this.labelPane1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPane1.AutoSize = true;
            this.labelPane1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPane1.Location = new System.Drawing.Point(196, 284);
            this.labelPane1.Name = "labelPane1";
            this.labelPane1.Size = new System.Drawing.Size(63, 19);
            this.labelPane1.TabIndex = 19;
            this.labelPane1.Text = "Pane 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pane 2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pane 3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1151, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Pane 4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1414, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pane 5";
            // 
            // labelPane6
            // 
            this.labelPane6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPane6.AutoSize = true;
            this.labelPane6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPane6.Location = new System.Drawing.Point(1732, 284);
            this.labelPane6.Name = "labelPane6";
            this.labelPane6.Size = new System.Drawing.Size(63, 19);
            this.labelPane6.TabIndex = 24;
            this.labelPane6.Text = "Pane 6";
            // 
            // labelScharr
            // 
            this.labelScharr.AutoSize = true;
            this.labelScharr.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScharr.Location = new System.Drawing.Point(1678, 24);
            this.labelScharr.Name = "labelScharr";
            this.labelScharr.Size = new System.Drawing.Size(117, 19);
            this.labelScharr.TabIndex = 25;
            this.labelScharr.Text = "Scharr Image";
            // 
            // TiledFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(2028, 799);
            this.Controls.Add(this.labelScharr);
            this.Controls.Add(this.labelPane6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPane1);
            this.Controls.Add(this.labelSobel);
            this.Controls.Add(this.labelLaplace);
            this.Controls.Add(this.labelCanny);
            this.Controls.Add(this.labelGray);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TiledFiltersForm";
            this.Text = "Tiled Images";
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.labelSource, 0);
            this.Controls.SetChildIndex(this.labelGray, 0);
            this.Controls.SetChildIndex(this.labelCanny, 0);
            this.Controls.SetChildIndex(this.labelLaplace, 0);
            this.Controls.SetChildIndex(this.labelSobel, 0);
            this.Controls.SetChildIndex(this.labelPane1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.labelPane6, 0);
            this.Controls.SetChildIndex(this.labelScharr, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSobel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScharr)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxBlur.ResumeLayout(false);
            this.groupBoxBlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPane6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSource;
        private System.Windows.Forms.PictureBox pictureBoxGray;
        private System.Windows.Forms.PictureBox pictureBoxCanny;
        private System.Windows.Forms.PictureBox pictureBoxSobel;
        private System.Windows.Forms.PictureBox pictureBoxLaplace;
        private System.Windows.Forms.PictureBox pictureBoxScharr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxPane1;
        private System.Windows.Forms.PictureBox pictureBoxPane2;
        private System.Windows.Forms.PictureBox pictureBoxPane3;
        private System.Windows.Forms.PictureBox pictureBoxPane4;
        private System.Windows.Forms.PictureBox pictureBoxPane5;
        private System.Windows.Forms.PictureBox pictureBoxPane6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelGray;
        private System.Windows.Forms.Label labelCanny;
        private System.Windows.Forms.Label labelLaplace;
        private System.Windows.Forms.Label labelSobel;
        private System.Windows.Forms.Label labelPane1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPane6;
        private System.Windows.Forms.Label labelScharr;
        private System.Windows.Forms.GroupBox groupBoxFiltering;
        private System.Windows.Forms.GroupBox groupBoxBlur;
        private System.Windows.Forms.CheckBox checkBoxGuassianBlur;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxEqualize;
    }
}
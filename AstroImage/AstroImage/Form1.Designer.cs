namespace AstroImage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmdOutputDirPicker = new System.Windows.Forms.Button();
            this.lblStDev = new System.Windows.Forms.Label();
            this.lblMean = new System.Windows.Forms.Label();
            this.cmdSaveCsv = new System.Windows.Forms.Button();
            this.txtMinSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSourceFilePicker = new System.Windows.Forms.Button();
            this.cmdHighlightBrs = new System.Windows.Forms.Button();
            this.txtOuputDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdSaveData = new System.Windows.Forms.Button();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtEdgeThreshold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.cmdIterate = new System.Windows.Forms.Button();
            this.cmdShowImage = new System.Windows.Forms.Button();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCentroid = new System.Windows.Forms.RadioButton();
            this.rbUpperLefftCoord = new System.Windows.Forms.RadioButton();
            this.rbRelativeBrightness = new System.Windows.Forms.RadioButton();
            this.rbAbsoluteBrightness = new System.Windows.Forms.RadioButton();
            this.rbSize = new System.Windows.Forms.RadioButton();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lbl2StDev = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1872, 1315);
            this.splitContainer1.SplitterDistance = 820;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1872, 820);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(12, 58);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1848, 750);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbl2StDev);
            this.splitContainer2.Panel1.Controls.Add(this.cmdOutputDirPicker);
            this.splitContainer2.Panel1.Controls.Add(this.lblStDev);
            this.splitContainer2.Panel1.Controls.Add(this.lblMean);
            this.splitContainer2.Panel1.Controls.Add(this.cmdSaveCsv);
            this.splitContainer2.Panel1.Controls.Add(this.txtMinSize);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.cmdSourceFilePicker);
            this.splitContainer2.Panel1.Controls.Add(this.cmdHighlightBrs);
            this.splitContainer2.Panel1.Controls.Add(this.txtOuputDir);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.cmdSaveData);
            this.splitContainer2.Panel1.Controls.Add(this.lblElapsedTime);
            this.splitContainer2.Panel1.Controls.Add(this.cmdClear);
            this.splitContainer2.Panel1.Controls.Add(this.txtEdgeThreshold);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.lblWidth);
            this.splitContainer2.Panel1.Controls.Add(this.lblHeight);
            this.splitContainer2.Panel1.Controls.Add(this.cmdIterate);
            this.splitContainer2.Panel1.Controls.Add(this.cmdShowImage);
            this.splitContainer2.Panel1.Controls.Add(this.txtSourceFile);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pbImage);
            this.splitContainer2.Size = new System.Drawing.Size(1842, 744);
            this.splitContainer2.SplitterDistance = 1451;
            this.splitContainer2.SplitterWidth = 15;
            this.splitContainer2.TabIndex = 0;
            // 
            // cmdOutputDirPicker
            // 
            this.cmdOutputDirPicker.Location = new System.Drawing.Point(827, 249);
            this.cmdOutputDirPicker.Name = "cmdOutputDirPicker";
            this.cmdOutputDirPicker.Size = new System.Drawing.Size(140, 71);
            this.cmdOutputDirPicker.TabIndex = 21;
            this.cmdOutputDirPicker.Text = "..";
            this.cmdOutputDirPicker.UseVisualStyleBackColor = true;
            // 
            // lblStDev
            // 
            this.lblStDev.AutoSize = true;
            this.lblStDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStDev.Location = new System.Drawing.Point(997, 552);
            this.lblStDev.Name = "lblStDev";
            this.lblStDev.Size = new System.Drawing.Size(237, 46);
            this.lblStDev.TabIndex = 20;
            this.lblStDev.Text = "Std Dev.:XX\r\n";
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMean.Location = new System.Drawing.Point(997, 474);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(184, 46);
            this.lblMean.TabIndex = 19;
            this.lblMean.Text = "Mean:XX";
            // 
            // cmdSaveCsv
            // 
            this.cmdSaveCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveCsv.Location = new System.Drawing.Point(745, 355);
            this.cmdSaveCsv.Name = "cmdSaveCsv";
            this.cmdSaveCsv.Size = new System.Drawing.Size(229, 89);
            this.cmdSaveCsv.TabIndex = 18;
            this.cmdSaveCsv.Text = "Save CSV";
            this.cmdSaveCsv.UseVisualStyleBackColor = true;
            this.cmdSaveCsv.Click += new System.EventHandler(this.cmdSaveCsv_Click);
            // 
            // txtMinSize
            // 
            this.txtMinSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinSize.Location = new System.Drawing.Point(1304, 134);
            this.txtMinSize.Name = "txtMinSize";
            this.txtMinSize.Size = new System.Drawing.Size(100, 53);
            this.txtMinSize.TabIndex = 17;
            this.txtMinSize.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(997, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Min Size";
            // 
            // cmdSourceFilePicker
            // 
            this.cmdSourceFilePicker.Location = new System.Drawing.Point(827, 121);
            this.cmdSourceFilePicker.Name = "cmdSourceFilePicker";
            this.cmdSourceFilePicker.Size = new System.Drawing.Size(140, 53);
            this.cmdSourceFilePicker.TabIndex = 14;
            this.cmdSourceFilePicker.Text = "...";
            this.cmdSourceFilePicker.UseVisualStyleBackColor = true;
            this.cmdSourceFilePicker.Click += new System.EventHandler(this.cmdSourceFilePicker_Click);
            // 
            // cmdHighlightBrs
            // 
            this.cmdHighlightBrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHighlightBrs.Location = new System.Drawing.Point(17, 641);
            this.cmdHighlightBrs.Name = "cmdHighlightBrs";
            this.cmdHighlightBrs.Size = new System.Drawing.Size(963, 96);
            this.cmdHighlightBrs.TabIndex = 13;
            this.cmdHighlightBrs.Text = "Highligh BRs";
            this.cmdHighlightBrs.UseVisualStyleBackColor = true;
            this.cmdHighlightBrs.Click += new System.EventHandler(this.cmdHighlightBrs_Click);
            // 
            // txtOuputDir
            // 
            this.txtOuputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOuputDir.Location = new System.Drawing.Point(330, 190);
            this.txtOuputDir.Name = "txtOuputDir";
            this.txtOuputDir.Size = new System.Drawing.Size(637, 53);
            this.txtOuputDir.TabIndex = 12;
            this.txtOuputDir.Text = "c:\\ImageResults";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ouput Directory";
            // 
            // cmdSaveData
            // 
            this.cmdSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveData.Location = new System.Drawing.Point(372, 529);
            this.cmdSaveData.Name = "cmdSaveData";
            this.cmdSaveData.Size = new System.Drawing.Size(326, 92);
            this.cmdSaveData.TabIndex = 10;
            this.cmdSaveData.Text = "Save BR Data";
            this.cmdSaveData.UseVisualStyleBackColor = true;
            this.cmdSaveData.Click += new System.EventHandler(this.cmdSaveData_Click);
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.Location = new System.Drawing.Point(373, 457);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(238, 46);
            this.lblElapsedTime.TabIndex = 9;
            this.lblElapsedTime.Text = "Time: 00 ms";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(730, 479);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(250, 142);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtEdgeThreshold
            // 
            this.txtEdgeThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdgeThreshold.Location = new System.Drawing.Point(1304, 62);
            this.txtEdgeThreshold.Name = "txtEdgeThreshold";
            this.txtEdgeThreshold.Size = new System.Drawing.Size(100, 53);
            this.txtEdgeThreshold.TabIndex = 7;
            this.txtEdgeThreshold.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(997, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edge Threshold";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(997, 380);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(214, 46);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width:XXX";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(997, 300);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(227, 46);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height:XXX";
            // 
            // cmdIterate
            // 
            this.cmdIterate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIterate.Location = new System.Drawing.Point(12, 479);
            this.cmdIterate.Name = "cmdIterate";
            this.cmdIterate.Size = new System.Drawing.Size(314, 142);
            this.cmdIterate.TabIndex = 3;
            this.cmdIterate.Text = "Detect Bounding Rects";
            this.cmdIterate.UseVisualStyleBackColor = true;
            this.cmdIterate.Click += new System.EventHandler(this.cmdIterate_Click);
            // 
            // cmdShowImage
            // 
            this.cmdShowImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdShowImage.Location = new System.Drawing.Point(17, 371);
            this.cmdShowImage.Name = "cmdShowImage";
            this.cmdShowImage.Size = new System.Drawing.Size(279, 73);
            this.cmdShowImage.TabIndex = 2;
            this.cmdShowImage.Text = "Show Image";
            this.cmdShowImage.UseVisualStyleBackColor = true;
            this.cmdShowImage.Click += new System.EventHandler(this.cmdShowImage_Click);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceFile.Location = new System.Drawing.Point(12, 62);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(962, 53);
            this.txtSourceFile.TabIndex = 1;
            this.txtSourceFile.Text = "c:\\Testimages\\2Stars-1.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source BMP";
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(372, 740);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(12, 58);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1848, 750);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCentroid);
            this.groupBox1.Controls.Add(this.rbUpperLefftCoord);
            this.groupBox1.Controls.Add(this.rbRelativeBrightness);
            this.groupBox1.Controls.Add(this.rbAbsoluteBrightness);
            this.groupBox1.Controls.Add(this.rbSize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 614);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort BRs By";
            // 
            // rbCentroid
            // 
            this.rbCentroid.AutoSize = true;
            this.rbCentroid.Location = new System.Drawing.Point(21, 381);
            this.rbCentroid.Name = "rbCentroid";
            this.rbCentroid.Size = new System.Drawing.Size(215, 50);
            this.rbCentroid.TabIndex = 4;
            this.rbCentroid.TabStop = true;
            this.rbCentroid.Text = "Centroid";
            this.rbCentroid.UseVisualStyleBackColor = true;
            // 
            // rbUpperLefftCoord
            // 
            this.rbUpperLefftCoord.AutoSize = true;
            this.rbUpperLefftCoord.Checked = true;
            this.rbUpperLefftCoord.Location = new System.Drawing.Point(21, 75);
            this.rbUpperLefftCoord.Name = "rbUpperLefftCoord";
            this.rbUpperLefftCoord.Size = new System.Drawing.Size(456, 50);
            this.rbUpperLefftCoord.TabIndex = 3;
            this.rbUpperLefftCoord.TabStop = true;
            this.rbUpperLefftCoord.Text = "Upper Left Coordinate";
            this.rbUpperLefftCoord.UseVisualStyleBackColor = true;
            // 
            // rbRelativeBrightness
            // 
            this.rbRelativeBrightness.AutoSize = true;
            this.rbRelativeBrightness.Location = new System.Drawing.Point(21, 309);
            this.rbRelativeBrightness.Name = "rbRelativeBrightness";
            this.rbRelativeBrightness.Size = new System.Drawing.Size(406, 50);
            this.rbRelativeBrightness.TabIndex = 2;
            this.rbRelativeBrightness.Text = "Relative Brightness";
            this.rbRelativeBrightness.UseVisualStyleBackColor = true;
            // 
            // rbAbsoluteBrightness
            // 
            this.rbAbsoluteBrightness.AutoSize = true;
            this.rbAbsoluteBrightness.Location = new System.Drawing.Point(21, 228);
            this.rbAbsoluteBrightness.Name = "rbAbsoluteBrightness";
            this.rbAbsoluteBrightness.Size = new System.Drawing.Size(419, 50);
            this.rbAbsoluteBrightness.TabIndex = 1;
            this.rbAbsoluteBrightness.Text = "Absolute Brightness";
            this.rbAbsoluteBrightness.UseVisualStyleBackColor = true;
            // 
            // rbSize
            // 
            this.rbSize.AutoSize = true;
            this.rbSize.Location = new System.Drawing.Point(21, 150);
            this.rbSize.Name = "rbSize";
            this.rbSize.Size = new System.Drawing.Size(142, 50);
            this.rbSize.TabIndex = 0;
            this.rbSize.Text = "Size";
            this.rbSize.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1872, 480);
            this.txtOutput.TabIndex = 0;
            // 
            // lbl2StDev
            // 
            this.lbl2StDev.AutoSize = true;
            this.lbl2StDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2StDev.Location = new System.Drawing.Point(997, 215);
            this.lbl2StDev.Name = "lbl2StDev";
            this.lbl2StDev.Size = new System.Drawing.Size(192, 46);
            this.lbl2StDev.TabIndex = 22;
            this.lbl2StDev.Text = "2X SD+M";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1315);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.ActiveForm_ResizeEnd);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button cmdShowImage;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button cmdIterate;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdgeThreshold;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.TextBox txtOuputDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdSaveData;
        private System.Windows.Forms.Button cmdHighlightBrs;
        private System.Windows.Forms.TextBox txtMinSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSourceFilePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRelativeBrightness;
        private System.Windows.Forms.RadioButton rbAbsoluteBrightness;
        private System.Windows.Forms.RadioButton rbSize;
        private System.Windows.Forms.Button cmdSaveCsv;
        private System.Windows.Forms.RadioButton rbUpperLefftCoord;
        private System.Windows.Forms.RadioButton rbCentroid;
        private System.Windows.Forms.Button cmdOutputDirPicker;
        private System.Windows.Forms.Label lblStDev;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lbl2StDev;
    }
}


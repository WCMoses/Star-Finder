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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1872, 1315);
            this.splitContainer1.SplitterDistance = 820;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
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
            this.splitContainer2.Size = new System.Drawing.Size(1872, 820);
            this.splitContainer2.SplitterDistance = 1035;
            this.splitContainer2.TabIndex = 0;
            // 
            // cmdHighlightBrs
            // 
            this.cmdHighlightBrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHighlightBrs.Location = new System.Drawing.Point(28, 604);
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
            this.txtOuputDir.Location = new System.Drawing.Point(330, 222);
            this.txtOuputDir.Name = "txtOuputDir";
            this.txtOuputDir.Size = new System.Drawing.Size(637, 53);
            this.txtOuputDir.TabIndex = 12;
            this.txtOuputDir.Text = "c:\\ImageResults";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ouput Directory";
            // 
            // cmdSaveData
            // 
            this.cmdSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSaveData.Location = new System.Drawing.Point(376, 479);
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
            this.lblElapsedTime.Location = new System.Drawing.Point(337, 430);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(393, 46);
            this.lblElapsedTime.TabIndex = 9;
            this.lblElapsedTime.Text = "Elapsed Time: 00 ms";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(759, 429);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(232, 142);
            this.cmdClear.TabIndex = 8;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtEdgeThreshold
            // 
            this.txtEdgeThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdgeThreshold.Location = new System.Drawing.Point(330, 134);
            this.txtEdgeThreshold.Name = "txtEdgeThreshold";
            this.txtEdgeThreshold.Size = new System.Drawing.Size(163, 53);
            this.txtEdgeThreshold.TabIndex = 7;
            this.txtEdgeThreshold.Text = "25";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Edge Threshold";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(624, 353);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(214, 46);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Width:XXX";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(312, 353);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(227, 46);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height:XXX";
            // 
            // cmdIterate
            // 
            this.cmdIterate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIterate.Location = new System.Drawing.Point(17, 429);
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
            this.cmdShowImage.Location = new System.Drawing.Point(17, 317);
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
            this.pbImage.Size = new System.Drawing.Size(829, 816);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1872, 491);
            this.txtOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1315);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
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
    }
}


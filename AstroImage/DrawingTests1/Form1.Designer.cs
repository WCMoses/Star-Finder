namespace DrawingTests1
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
            this.cmdDrawrects = new System.Windows.Forms.Button();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLoadImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.cmdMisc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdMisc);
            this.splitContainer1.Panel1.Controls.Add(this.cmdDrawrects);
            this.splitContainer1.Panel1.Controls.Add(this.txtSourceFile);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmdLoadImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pbImage);
            this.splitContainer1.Size = new System.Drawing.Size(1799, 1030);
            this.splitContainer1.SplitterDistance = 647;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmdDrawrects
            // 
            this.cmdDrawrects.Location = new System.Drawing.Point(163, 232);
            this.cmdDrawrects.Name = "cmdDrawrects";
            this.cmdDrawrects.Size = new System.Drawing.Size(271, 71);
            this.cmdDrawrects.TabIndex = 3;
            this.cmdDrawrects.Text = "Draw Rects";
            this.cmdDrawrects.UseVisualStyleBackColor = true;
            this.cmdDrawrects.Click += new System.EventHandler(this.cmdDrawrects_Click);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(4, 60);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(640, 44);
            this.txtSourceFile.TabIndex = 2;
            this.txtSourceFile.Text = "c:\\TestImage1.bmp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source File";
            // 
            // cmdLoadImage
            // 
            this.cmdLoadImage.Location = new System.Drawing.Point(163, 128);
            this.cmdLoadImage.Name = "cmdLoadImage";
            this.cmdLoadImage.Size = new System.Drawing.Size(271, 60);
            this.cmdLoadImage.TabIndex = 0;
            this.cmdLoadImage.Text = "Load Image";
            this.cmdLoadImage.UseVisualStyleBackColor = true;
            this.cmdLoadImage.Click += new System.EventHandler(this.cmdLoadImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1144, 1026);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // cmdMisc
            // 
            this.cmdMisc.Location = new System.Drawing.Point(393, 643);
            this.cmdMisc.Name = "cmdMisc";
            this.cmdMisc.Size = new System.Drawing.Size(171, 69);
            this.cmdMisc.TabIndex = 4;
            this.cmdMisc.Text = "button1";
            this.cmdMisc.UseVisualStyleBackColor = true;
            this.cmdMisc.Click += new System.EventHandler(this.cmdMisc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 1030);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLoadImage;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button cmdDrawrects;
        private System.Windows.Forms.Button cmdMisc;
    }
}


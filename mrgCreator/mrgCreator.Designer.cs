namespace mrgCreator
{
    partial class mrgCreator
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
            this.OpenSceneImage = new System.Windows.Forms.Button();
            this.OpenSpriteImage = new System.Windows.Forms.Button();
            this.ScenePreview = new System.Windows.Forms.PictureBox();
            this.SpritePreview = new System.Windows.Forms.PictureBox();
            this.MergeAndCompress_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MergedPreviewBox = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Matrixviewer = new System.Windows.Forms.DataGridView();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualitytrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.qualityset = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Compression_preview_box = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Merged_height_txtbx = new System.Windows.Forms.TextBox();
            this.Merged_width_txtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CreateMrg_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScenePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MergedPreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrixviewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualitytrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compression_preview_box)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenSceneImage
            // 
            this.OpenSceneImage.Location = new System.Drawing.Point(12, 12);
            this.OpenSceneImage.Name = "OpenSceneImage";
            this.OpenSceneImage.Size = new System.Drawing.Size(148, 40);
            this.OpenSceneImage.TabIndex = 0;
            this.OpenSceneImage.Text = "Open Scene Image";
            this.OpenSceneImage.UseVisualStyleBackColor = true;
            this.OpenSceneImage.Click += new System.EventHandler(this.OpenSceneImage_Click);
            // 
            // OpenSpriteImage
            // 
            this.OpenSpriteImage.Location = new System.Drawing.Point(339, 12);
            this.OpenSpriteImage.Name = "OpenSpriteImage";
            this.OpenSpriteImage.Size = new System.Drawing.Size(148, 40);
            this.OpenSpriteImage.TabIndex = 1;
            this.OpenSpriteImage.Text = "Open Sprite Image";
            this.OpenSpriteImage.UseVisualStyleBackColor = true;
            this.OpenSpriteImage.Click += new System.EventHandler(this.OpenSpriteImage_Click);
            // 
            // ScenePreview
            // 
            this.ScenePreview.Location = new System.Drawing.Point(12, 95);
            this.ScenePreview.Name = "ScenePreview";
            this.ScenePreview.Size = new System.Drawing.Size(231, 218);
            this.ScenePreview.TabIndex = 2;
            this.ScenePreview.TabStop = false;
            // 
            // SpritePreview
            // 
            this.SpritePreview.Location = new System.Drawing.Point(249, 95);
            this.SpritePreview.Name = "SpritePreview";
            this.SpritePreview.Size = new System.Drawing.Size(238, 218);
            this.SpritePreview.TabIndex = 3;
            this.SpritePreview.TabStop = false;
            // 
            // MergeAndCompress_btn
            // 
            this.MergeAndCompress_btn.Location = new System.Drawing.Point(12, 415);
            this.MergeAndCompress_btn.Name = "MergeAndCompress_btn";
            this.MergeAndCompress_btn.Size = new System.Drawing.Size(238, 40);
            this.MergeAndCompress_btn.TabIndex = 4;
            this.MergeAndCompress_btn.Text = "Merge and Compress";
            this.MergeAndCompress_btn.UseVisualStyleBackColor = true;
            this.MergeAndCompress_btn.Click += new System.EventHandler(this.MergeAndCompress_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scene Preview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sprite Preview";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1211, 501);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 7;
            // 
            // MergedPreviewBox
            // 
            this.MergedPreviewBox.Location = new System.Drawing.Point(493, 95);
            this.MergedPreviewBox.Name = "MergedPreviewBox";
            this.MergedPreviewBox.Size = new System.Drawing.Size(238, 218);
            this.MergedPreviewBox.TabIndex = 8;
            this.MergedPreviewBox.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1211, 529);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 22);
            this.textBox2.TabIndex = 9;
            // 
            // Matrixviewer
            // 
            this.Matrixviewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrixviewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.Matrixviewer.Location = new System.Drawing.Point(751, 95);
            this.Matrixviewer.Name = "Matrixviewer";
            this.Matrixviewer.RowTemplate.Height = 24;
            this.Matrixviewer.Size = new System.Drawing.Size(688, 395);
            this.Matrixviewer.TabIndex = 74;
            // 
            // Column0
            // 
            this.Column0.HeaderText = "Col0";
            this.Column0.Name = "Column0";
            this.Column0.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Col1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Col2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Col3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Col4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Col5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Col6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Col7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 50;
            // 
            // QualitytrackBar
            // 
            this.QualitytrackBar.Location = new System.Drawing.Point(12, 319);
            this.QualitytrackBar.Maximum = 90;
            this.QualitytrackBar.Minimum = 10;
            this.QualitytrackBar.Name = "QualitytrackBar";
            this.QualitytrackBar.Size = new System.Drawing.Size(238, 56);
            this.QualitytrackBar.SmallChange = 5;
            this.QualitytrackBar.TabIndex = 75;
            this.QualitytrackBar.Value = 50;
            this.QualitytrackBar.Scroll += new System.EventHandler(this.ChangeQuality);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Quality : ";
            // 
            // qualityset
            // 
            this.qualityset.Location = new System.Drawing.Point(93, 366);
            this.qualityset.Name = "qualityset";
            this.qualityset.ReadOnly = true;
            this.qualityset.Size = new System.Drawing.Size(79, 22);
            this.qualityset.TabIndex = 77;
            this.qualityset.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 78;
            this.label4.Text = "Merge result";
            // 
            // Compression_preview_box
            // 
            this.Compression_preview_box.Location = new System.Drawing.Point(493, 332);
            this.Compression_preview_box.Name = "Compression_preview_box";
            this.Compression_preview_box.Size = new System.Drawing.Size(238, 218);
            this.Compression_preview_box.TabIndex = 79;
            this.Compression_preview_box.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Compression result:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(748, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "test matrix";
            // 
            // Merged_height_txtbx
            // 
            this.Merged_height_txtbx.Location = new System.Drawing.Point(162, 468);
            this.Merged_height_txtbx.Name = "Merged_height_txtbx";
            this.Merged_height_txtbx.Size = new System.Drawing.Size(88, 22);
            this.Merged_height_txtbx.TabIndex = 82;
            // 
            // Merged_width_txtbx
            // 
            this.Merged_width_txtbx.Location = new System.Drawing.Point(162, 496);
            this.Merged_width_txtbx.Name = "Merged_width_txtbx";
            this.Merged_width_txtbx.Size = new System.Drawing.Size(88, 22);
            this.Merged_width_txtbx.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Merge width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Merge height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1092, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "zz count";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1092, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 87;
            this.label10.Text = "x * y";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1211, 557);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 22);
            this.textBox3.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1092, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 17);
            this.label11.TabIndex = 89;
            this.label11.Text = "zigzagvalue";
            // 
            // CreateMrg_btn
            // 
            this.CreateMrg_btn.Location = new System.Drawing.Point(751, 501);
            this.CreateMrg_btn.Name = "CreateMrg_btn";
            this.CreateMrg_btn.Size = new System.Drawing.Size(301, 78);
            this.CreateMrg_btn.TabIndex = 90;
            this.CreateMrg_btn.Text = "Create MRG File";
            this.CreateMrg_btn.UseVisualStyleBackColor = true;
            this.CreateMrg_btn.Click += new System.EventHandler(this.CreateMrg_btn_Click);
            // 
            // mrgCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 598);
            this.Controls.Add(this.CreateMrg_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Merged_width_txtbx);
            this.Controls.Add(this.Merged_height_txtbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Compression_preview_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qualityset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QualitytrackBar);
            this.Controls.Add(this.Matrixviewer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MergedPreviewBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MergeAndCompress_btn);
            this.Controls.Add(this.SpritePreview);
            this.Controls.Add(this.ScenePreview);
            this.Controls.Add(this.OpenSpriteImage);
            this.Controls.Add(this.OpenSceneImage);
            this.Name = "mrgCreator";
            this.Text = "mrgCreator";
            ((System.ComponentModel.ISupportInitialize)(this.ScenePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MergedPreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrixviewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualitytrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compression_preview_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenSceneImage;
        private System.Windows.Forms.Button OpenSpriteImage;
        private System.Windows.Forms.PictureBox ScenePreview;
        private System.Windows.Forms.PictureBox SpritePreview;
        private System.Windows.Forms.Button MergeAndCompress_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox MergedPreviewBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView Matrixviewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TrackBar QualitytrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qualityset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Compression_preview_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Merged_height_txtbx;
        private System.Windows.Forms.TextBox Merged_width_txtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CreateMrg_btn;
    }
}


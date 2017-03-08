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
            ((System.ComponentModel.ISupportInitialize)(this.ScenePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MergedPreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrixviewer)).BeginInit();
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
            this.MergeAndCompress_btn.Location = new System.Drawing.Point(129, 319);
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
            this.textBox1.Location = new System.Drawing.Point(15, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 22);
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
            this.textBox2.Location = new System.Drawing.Point(15, 402);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 22);
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
            this.Matrixviewer.Size = new System.Drawing.Size(532, 334);
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
            // mrgCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 441);
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
    }
}


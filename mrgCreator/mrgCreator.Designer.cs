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
            ((System.ComponentModel.ISupportInitialize)(this.ScenePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpritePreview)).BeginInit();
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
            this.MergeAndCompress_btn.Location = new System.Drawing.Point(145, 341);
            this.MergeAndCompress_btn.Name = "MergeAndCompress_btn";
            this.MergeAndCompress_btn.Size = new System.Drawing.Size(199, 40);
            this.MergeAndCompress_btn.TabIndex = 4;
            this.MergeAndCompress_btn.Text = "Merge and Compress";
            this.MergeAndCompress_btn.UseVisualStyleBackColor = true;
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
            this.textBox1.Location = new System.Drawing.Point(30, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 22);
            this.textBox1.TabIndex = 7;
            // 
            // mrgCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 443);
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
    }
}


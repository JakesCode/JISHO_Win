namespace JISHO_Win
{
    partial class JISHOWIN_DEFINITIONS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JISHOWIN_DEFINITIONS));
            this.JISHOLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.word = new System.Windows.Forms.Label();
            this.primaryEnglishDefinition = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.otherMeanings = new System.Windows.Forms.Panel();
            this.commonIcon = new System.Windows.Forms.PictureBox();
            this.commonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.similarPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.JISHOLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // JISHOLogo
            // 
            this.JISHOLogo.Image = ((System.Drawing.Image)(resources.GetObject("JISHOLogo.Image")));
            this.JISHOLogo.Location = new System.Drawing.Point(12, 12);
            this.JISHOLogo.Name = "JISHOLogo";
            this.JISHOLogo.Size = new System.Drawing.Size(128, 68);
            this.JISHOLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.JISHOLogo.TabIndex = 1;
            this.JISHOLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Mamelon", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.word.Location = new System.Drawing.Point(275, 28);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(83, 27);
            this.word.TabIndex = 3;
            this.word.Text = "Phrase";
            this.word.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // primaryEnglishDefinition
            // 
            this.primaryEnglishDefinition.AutoSize = true;
            this.primaryEnglishDefinition.Font = new System.Drawing.Font("Mamelon", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.primaryEnglishDefinition.Location = new System.Drawing.Point(232, 62);
            this.primaryEnglishDefinition.Name = "primaryEnglishDefinition";
            this.primaryEnglishDefinition.Size = new System.Drawing.Size(170, 17);
            this.primaryEnglishDefinition.TabIndex = 4;
            this.primaryEnglishDefinition.Text = "Primary English Definition";
            this.primaryEnglishDefinition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(391, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 27);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mamelon", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Other meanings....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // otherMeanings
            // 
            this.otherMeanings.Location = new System.Drawing.Point(10, 105);
            this.otherMeanings.Name = "otherMeanings";
            this.otherMeanings.Size = new System.Drawing.Size(397, 153);
            this.otherMeanings.TabIndex = 7;
            // 
            // commonIcon
            // 
            this.commonIcon.Image = ((System.Drawing.Image)(resources.GetObject("commonIcon.Image")));
            this.commonIcon.Location = new System.Drawing.Point(235, 82);
            this.commonIcon.Name = "commonIcon";
            this.commonIcon.Size = new System.Drawing.Size(21, 20);
            this.commonIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.commonIcon.TabIndex = 8;
            this.commonIcon.TabStop = false;
            this.commonIcon.Visible = false;
            // 
            // commonLabel
            // 
            this.commonLabel.AutoSize = true;
            this.commonLabel.Font = new System.Drawing.Font("Mamelon", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.commonLabel.Location = new System.Drawing.Point(260, 85);
            this.commonLabel.Name = "commonLabel";
            this.commonLabel.Size = new System.Drawing.Size(142, 15);
            this.commonLabel.TabIndex = 9;
            this.commonLabel.Text = "This is a common word.";
            this.commonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.commonLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mamelon", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Information about this word....";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Info;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info.Enabled = false;
            this.info.Font = new System.Drawing.Font("HonyaJi-Re", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.Location = new System.Drawing.Point(12, 281);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(395, 59);
            this.info.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mamelon", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Similar words to explore....";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // similarPanel
            // 
            this.similarPanel.Location = new System.Drawing.Point(12, 363);
            this.similarPanel.Name = "similarPanel";
            this.similarPanel.Size = new System.Drawing.Size(397, 153);
            this.similarPanel.TabIndex = 8;
            // 
            // JISHOWIN_DEFINITIONS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(419, 551);
            this.Controls.Add(this.similarPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commonLabel);
            this.Controls.Add(this.commonIcon);
            this.Controls.Add(this.otherMeanings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.primaryEnglishDefinition);
            this.Controls.Add(this.word);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JISHOLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JISHOWIN_DEFINITIONS";
            this.Text = "JISHOWIN_DEFINITIONS";
            this.Load += new System.EventHandler(this.JISHOWIN_DEFINITIONS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JISHOLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JISHOLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closeButton;
        public System.Windows.Forms.Label word;
        public System.Windows.Forms.Label primaryEnglishDefinition;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel otherMeanings;
        public System.Windows.Forms.Label commonLabel;
        public System.Windows.Forms.PictureBox commonIcon;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox info;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel similarPanel;
    }
}
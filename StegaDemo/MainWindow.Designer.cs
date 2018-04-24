namespace StegaDemo
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.exportButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.selectImage = new System.Windows.Forms.Button();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.selectImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.layoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.zoomControl = new System.Windows.Forms.TrackBar();
            this.zoomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.layoutPanel.SuspendLayout();
            this.layoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomControl)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(12, 12);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(390, 319);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // layoutPanel
            // 
            this.layoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel.Controls.Add(this.exportButton);
            this.layoutPanel.Controls.Add(this.importButton);
            this.layoutPanel.Controls.Add(this.selectImage);
            this.layoutPanel.Controls.Add(this.methodBox);
            this.layoutPanel.Controls.Add(this.methodLabel);
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.layoutPanel.Location = new System.Drawing.Point(408, 12);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(105, 319);
            this.layoutPanel.TabIndex = 3;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(0, 296);
            this.exportButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(105, 23);
            this.exportButton.TabIndex = 6;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(0, 268);
            this.importButton.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(105, 23);
            this.importButton.TabIndex = 5;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // selectImage
            // 
            this.selectImage.Location = new System.Drawing.Point(0, 185);
            this.selectImage.Margin = new System.Windows.Forms.Padding(0, 20, 0, 40);
            this.selectImage.Name = "selectImage";
            this.selectImage.Size = new System.Drawing.Size(105, 23);
            this.selectImage.TabIndex = 7;
            this.selectImage.Text = "Select Image";
            this.selectImage.UseVisualStyleBackColor = true;
            this.selectImage.Click += new System.EventHandler(this.selectImage_Click);
            // 
            // methodBox
            // 
            this.methodBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Location = new System.Drawing.Point(0, 144);
            this.methodBox.Margin = new System.Windows.Forms.Padding(0);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(105, 21);
            this.methodBox.TabIndex = 3;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(0, 131);
            this.methodLabel.Margin = new System.Windows.Forms.Padding(0);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(43, 13);
            this.methodLabel.TabIndex = 4;
            this.methodLabel.Text = "Method";
            // 
            // selectImageDialog
            // 
            this.selectImageDialog.Filter = "Image Files|*.png;*.bmp";
            this.selectImageDialog.RestoreDirectory = true;
            this.selectImageDialog.Title = "Select Image";
            // 
            // layoutPanel2
            // 
            this.layoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutPanel2.Controls.Add(this.zoomControl);
            this.layoutPanel2.Controls.Add(this.zoomLabel);
            this.layoutPanel2.Location = new System.Drawing.Point(12, 337);
            this.layoutPanel2.Name = "layoutPanel2";
            this.layoutPanel2.Size = new System.Drawing.Size(501, 48);
            this.layoutPanel2.TabIndex = 4;
            // 
            // zoomControl
            // 
            this.zoomControl.Location = new System.Drawing.Point(3, 3);
            this.zoomControl.Name = "zoomControl";
            this.zoomControl.Size = new System.Drawing.Size(104, 45);
            this.zoomControl.TabIndex = 0;
            this.zoomControl.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.zoomControl.Value = 5;
            // 
            // zoomLabel
            // 
            this.zoomLabel.Location = new System.Drawing.Point(113, 0);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(56, 45);
            this.zoomLabel.TabIndex = 1;
            this.zoomLabel.Text = "100%";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 397);
            this.Controls.Add(this.layoutPanel2);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.imageBox);
            this.Name = "MainWindow";
            this.Text = "StegaDemo";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.layoutPanel2.ResumeLayout(false);
            this.layoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button selectImage;
        private System.Windows.Forms.OpenFileDialog selectImageDialog;
        private System.Windows.Forms.FlowLayoutPanel layoutPanel2;
        private System.Windows.Forms.TrackBar zoomControl;
        private System.Windows.Forms.Label zoomLabel;
    }
}


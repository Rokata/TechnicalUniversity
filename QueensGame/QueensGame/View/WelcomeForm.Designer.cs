namespace QueensGame.View
{
    partial class WelcomeForm
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
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.confirmBoardButton = new System.Windows.Forms.Button();
            this.boardSizeList = new System.Windows.Forms.ComboBox();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(185, 13);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Please choose board size to proceed.";
            // 
            // confirmBoardButton
            // 
            this.confirmBoardButton.Location = new System.Drawing.Point(211, 33);
            this.confirmBoardButton.Name = "confirmBoardButton";
            this.confirmBoardButton.Size = new System.Drawing.Size(61, 23);
            this.confirmBoardButton.TabIndex = 7;
            this.confirmBoardButton.Text = "OK";
            this.confirmBoardButton.UseVisualStyleBackColor = true;
            this.confirmBoardButton.Click += new System.EventHandler(this.confirmBoardButton_Click);
            // 
            // boardSizeList
            // 
            this.boardSizeList.FormattingEnabled = true;
            this.boardSizeList.Items.AddRange(new object[] {
            "4",
            "8",
            "10",
            "16"});
            this.boardSizeList.Location = new System.Drawing.Point(70, 35);
            this.boardSizeList.Name = "boardSizeList";
            this.boardSizeList.Size = new System.Drawing.Size(127, 21);
            this.boardSizeList.TabIndex = 6;
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(12, 38);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.boardSizeLabel.TabIndex = 5;
            this.boardSizeLabel.Text = "Board size:";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.confirmBoardButton);
            this.Controls.Add(this.boardSizeList);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.descriptionLabel);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button confirmBoardButton;
        private System.Windows.Forms.ComboBox boardSizeList;
        private System.Windows.Forms.Label boardSizeLabel;
    }
}
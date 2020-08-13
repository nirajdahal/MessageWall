namespace MessageWall
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.MessageList = new System.Windows.Forms.ListBox();
            this.AddMessage = new System.Windows.Forms.Button();
            this.Messages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MessageLabel.Location = new System.Drawing.Point(154, 55);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(67, 20);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Message";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.Location = new System.Drawing.Point(227, 56);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(267, 23);
            this.MessageTextBox.TabIndex = 1;
            // 
            // MessageList
            // 
            this.MessageList.FormattingEnabled = true;
            this.MessageList.ItemHeight = 15;
            this.MessageList.Location = new System.Drawing.Point(100, 178);
            this.MessageList.Name = "MessageList";
            this.MessageList.Size = new System.Drawing.Size(551, 154);
            this.MessageList.TabIndex = 0;
            // 
            // AddMessage
            // 
            this.AddMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddMessage.Location = new System.Drawing.Point(500, 56);
            this.AddMessage.Name = "AddMessage";
            this.AddMessage.Size = new System.Drawing.Size(75, 23);
            this.AddMessage.TabIndex = 2;
            this.AddMessage.Text = "Add ";
            this.AddMessage.UseVisualStyleBackColor = true;
            this.AddMessage.Click += new System.EventHandler(this.AddMessage_Click);
            // 
            // Messages
            // 
            this.Messages.AutoSize = true;
            this.Messages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Messages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Messages.Location = new System.Drawing.Point(100, 155);
            this.Messages.Name = "Messages";
            this.Messages.Size = new System.Drawing.Size(73, 20);
            this.Messages.TabIndex = 0;
            this.Messages.Text = "Messages";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(742, 463);
            this.Controls.Add(this.Messages);
            this.Controls.Add(this.AddMessage);
            this.Controls.Add(this.MessageList);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.MessageLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.ListBox MessageList;
        private System.Windows.Forms.Label Messages;
        private System.Windows.Forms.Button AddMessage;
    }
}


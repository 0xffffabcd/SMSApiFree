namespace SMSSenderDemo
{
    partial class MainForm
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
            this.notificationTextBox = new System.Windows.Forms.TextBox();
            this.sendNotificationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationTextBox
            // 
            this.notificationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationTextBox.Location = new System.Drawing.Point(12, 25);
            this.notificationTextBox.Multiline = true;
            this.notificationTextBox.Name = "notificationTextBox";
            this.notificationTextBox.Size = new System.Drawing.Size(232, 123);
            this.notificationTextBox.TabIndex = 0;
            this.notificationTextBox.TextChanged += new System.EventHandler(this.notificationTextBox_TextChanged);
            // 
            // sendNotificationButton
            // 
            this.sendNotificationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendNotificationButton.Location = new System.Drawing.Point(250, 25);
            this.sendNotificationButton.Name = "sendNotificationButton";
            this.sendNotificationButton.Size = new System.Drawing.Size(102, 23);
            this.sendNotificationButton.TabIndex = 1;
            this.sendNotificationButton.Text = "Send Notification";
            this.sendNotificationButton.UseVisualStyleBackColor = true;
            this.sendNotificationButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notification content";
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(250, 125);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 159);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(104, 17);
            this.statusLabel.Text = "Characters: 0 / 160";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 181);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendNotificationButton);
            this.Controls.Add(this.notificationTextBox);
            this.MinimumSize = new System.Drawing.Size(380, 220);
            this.Name = "MainForm";
            this.Text = "SMS Notification demo app";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notificationTextBox;
        private System.Windows.Forms.Button sendNotificationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}


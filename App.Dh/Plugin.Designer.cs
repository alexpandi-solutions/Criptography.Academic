namespace App.Dh
{
    partial class Plugin
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
            this.SenderPlaintextTextBox = new System.Windows.Forms.TextBox();
            this.ReceiverPlaintextTextBox = new System.Windows.Forms.TextBox();
            this.SenderCiphertextTextBox = new System.Windows.Forms.TextBox();
            this.ReceiverCiphertextTextBox = new System.Windows.Forms.TextBox();
            this.SenderPlaintextProgressBar = new System.Windows.Forms.ProgressBar();
            this.ReceiverPlaintextProgressBar = new System.Windows.Forms.ProgressBar();
            this.SenderCiphertextProgressBar = new System.Windows.Forms.ProgressBar();
            this.ReceiverCiphertextProgressBar = new System.Windows.Forms.ProgressBar();
            this.SenderDecryptButton = new System.Windows.Forms.Button();
            this.ReceiverDecryptButton = new System.Windows.Forms.Button();
            this.SenderSendButton = new System.Windows.Forms.Button();
            this.ReceiverSendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearSenderCiphertextButton = new System.Windows.Forms.Button();
            this.ClearSenderPlaintextButton = new System.Windows.Forms.Button();
            this.ClearReceiverPlaintextButton = new System.Windows.Forms.Button();
            this.ClearReceiverCiphertextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SenderPlaintextTextBox
            // 
            this.SenderPlaintextTextBox.Location = new System.Drawing.Point(21, 29);
            this.SenderPlaintextTextBox.Multiline = true;
            this.SenderPlaintextTextBox.Name = "SenderPlaintextTextBox";
            this.SenderPlaintextTextBox.Size = new System.Drawing.Size(412, 187);
            this.SenderPlaintextTextBox.TabIndex = 0;
            this.SenderPlaintextTextBox.TextChanged += new System.EventHandler(this.SenderPlaintextTextBox_TextChanged);
            // 
            // ReceiverPlaintextTextBox
            // 
            this.ReceiverPlaintextTextBox.Location = new System.Drawing.Point(439, 29);
            this.ReceiverPlaintextTextBox.Multiline = true;
            this.ReceiverPlaintextTextBox.Name = "ReceiverPlaintextTextBox";
            this.ReceiverPlaintextTextBox.Size = new System.Drawing.Size(412, 187);
            this.ReceiverPlaintextTextBox.TabIndex = 1;
            this.ReceiverPlaintextTextBox.TextChanged += new System.EventHandler(this.ReceiverPlaintextTextBox_TextChanged);
            // 
            // SenderCiphertextTextBox
            // 
            this.SenderCiphertextTextBox.Location = new System.Drawing.Point(21, 267);
            this.SenderCiphertextTextBox.Multiline = true;
            this.SenderCiphertextTextBox.Name = "SenderCiphertextTextBox";
            this.SenderCiphertextTextBox.Size = new System.Drawing.Size(412, 187);
            this.SenderCiphertextTextBox.TabIndex = 2;
            this.SenderCiphertextTextBox.TextChanged += new System.EventHandler(this.SenderCiphertextTextBox_TextChanged);
            // 
            // ReceiverCiphertextTextBox
            // 
            this.ReceiverCiphertextTextBox.Location = new System.Drawing.Point(439, 267);
            this.ReceiverCiphertextTextBox.Multiline = true;
            this.ReceiverCiphertextTextBox.Name = "ReceiverCiphertextTextBox";
            this.ReceiverCiphertextTextBox.Size = new System.Drawing.Size(412, 187);
            this.ReceiverCiphertextTextBox.TabIndex = 3;
            this.ReceiverCiphertextTextBox.TextChanged += new System.EventHandler(this.ReceiverCiphertextTextBox_TextChanged);
            // 
            // SenderPlaintextProgressBar
            // 
            this.SenderPlaintextProgressBar.Location = new System.Drawing.Point(21, 222);
            this.SenderPlaintextProgressBar.Name = "SenderPlaintextProgressBar";
            this.SenderPlaintextProgressBar.Size = new System.Drawing.Size(411, 10);
            this.SenderPlaintextProgressBar.TabIndex = 4;
            // 
            // ReceiverPlaintextProgressBar
            // 
            this.ReceiverPlaintextProgressBar.Location = new System.Drawing.Point(439, 222);
            this.ReceiverPlaintextProgressBar.Name = "ReceiverPlaintextProgressBar";
            this.ReceiverPlaintextProgressBar.Size = new System.Drawing.Size(411, 10);
            this.ReceiverPlaintextProgressBar.TabIndex = 5;
            // 
            // SenderCiphertextProgressBar
            // 
            this.SenderCiphertextProgressBar.Location = new System.Drawing.Point(21, 460);
            this.SenderCiphertextProgressBar.Name = "SenderCiphertextProgressBar";
            this.SenderCiphertextProgressBar.Size = new System.Drawing.Size(411, 10);
            this.SenderCiphertextProgressBar.TabIndex = 6;
            // 
            // ReceiverCiphertextProgressBar
            // 
            this.ReceiverCiphertextProgressBar.Location = new System.Drawing.Point(440, 460);
            this.ReceiverCiphertextProgressBar.Name = "ReceiverCiphertextProgressBar";
            this.ReceiverCiphertextProgressBar.Size = new System.Drawing.Size(411, 10);
            this.ReceiverCiphertextProgressBar.TabIndex = 7;
            // 
            // SenderDecryptButton
            // 
            this.SenderDecryptButton.Location = new System.Drawing.Point(266, 476);
            this.SenderDecryptButton.Name = "SenderDecryptButton";
            this.SenderDecryptButton.Size = new System.Drawing.Size(80, 23);
            this.SenderDecryptButton.TabIndex = 9;
            this.SenderDecryptButton.Text = "Decrypt";
            this.SenderDecryptButton.UseVisualStyleBackColor = true;
            this.SenderDecryptButton.Click += new System.EventHandler(this.SenderDecryptButton_Click);
            // 
            // ReceiverDecryptButton
            // 
            this.ReceiverDecryptButton.Location = new System.Drawing.Point(685, 476);
            this.ReceiverDecryptButton.Name = "ReceiverDecryptButton";
            this.ReceiverDecryptButton.Size = new System.Drawing.Size(80, 23);
            this.ReceiverDecryptButton.TabIndex = 11;
            this.ReceiverDecryptButton.Text = "Decrypt";
            this.ReceiverDecryptButton.UseVisualStyleBackColor = true;
            this.ReceiverDecryptButton.Click += new System.EventHandler(this.ReceiverDecryptButton_Click);
            // 
            // SenderSendButton
            // 
            this.SenderSendButton.Location = new System.Drawing.Point(267, 238);
            this.SenderSendButton.Name = "SenderSendButton";
            this.SenderSendButton.Size = new System.Drawing.Size(80, 23);
            this.SenderSendButton.TabIndex = 12;
            this.SenderSendButton.Text = "Send";
            this.SenderSendButton.UseVisualStyleBackColor = true;
            this.SenderSendButton.Click += new System.EventHandler(this.SenderSendButton_Click);
            // 
            // ReceiverSendButton
            // 
            this.ReceiverSendButton.Location = new System.Drawing.Point(685, 238);
            this.ReceiverSendButton.Name = "ReceiverSendButton";
            this.ReceiverSendButton.Size = new System.Drawing.Size(80, 23);
            this.ReceiverSendButton.TabIndex = 14;
            this.ReceiverSendButton.Text = "Send";
            this.ReceiverSendButton.UseVisualStyleBackColor = true;
            this.ReceiverSendButton.Click += new System.EventHandler(this.ReceiverSendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sender Plaintext";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Receiver Plaintext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Receiver Ciphertext";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sender Ciphertext";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(107, 476);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(80, 23);
            this.ResetButton.TabIndex = 20;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(21, 476);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(80, 23);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearSenderCiphertextButton
            // 
            this.ClearSenderCiphertextButton.Location = new System.Drawing.Point(352, 476);
            this.ClearSenderCiphertextButton.Name = "ClearSenderCiphertextButton";
            this.ClearSenderCiphertextButton.Size = new System.Drawing.Size(80, 23);
            this.ClearSenderCiphertextButton.TabIndex = 21;
            this.ClearSenderCiphertextButton.Text = "Clear";
            this.ClearSenderCiphertextButton.UseVisualStyleBackColor = true;
            this.ClearSenderCiphertextButton.Click += new System.EventHandler(this.ClearSenderCiphertextButton_Click);
            // 
            // ClearSenderPlaintextButton
            // 
            this.ClearSenderPlaintextButton.Location = new System.Drawing.Point(353, 238);
            this.ClearSenderPlaintextButton.Name = "ClearSenderPlaintextButton";
            this.ClearSenderPlaintextButton.Size = new System.Drawing.Size(80, 23);
            this.ClearSenderPlaintextButton.TabIndex = 22;
            this.ClearSenderPlaintextButton.Text = "Clear";
            this.ClearSenderPlaintextButton.UseVisualStyleBackColor = true;
            this.ClearSenderPlaintextButton.Click += new System.EventHandler(this.ClearSenderPlaintextButton_Click);
            // 
            // ClearReceiverPlaintextButton
            // 
            this.ClearReceiverPlaintextButton.Location = new System.Drawing.Point(771, 238);
            this.ClearReceiverPlaintextButton.Name = "ClearReceiverPlaintextButton";
            this.ClearReceiverPlaintextButton.Size = new System.Drawing.Size(80, 23);
            this.ClearReceiverPlaintextButton.TabIndex = 23;
            this.ClearReceiverPlaintextButton.Text = "Clear";
            this.ClearReceiverPlaintextButton.UseVisualStyleBackColor = true;
            this.ClearReceiverPlaintextButton.Click += new System.EventHandler(this.ClearReceiverPlaintextButton_Click);
            // 
            // ClearReceiverCiphertextButton
            // 
            this.ClearReceiverCiphertextButton.Location = new System.Drawing.Point(771, 476);
            this.ClearReceiverCiphertextButton.Name = "ClearReceiverCiphertextButton";
            this.ClearReceiverCiphertextButton.Size = new System.Drawing.Size(80, 23);
            this.ClearReceiverCiphertextButton.TabIndex = 24;
            this.ClearReceiverCiphertextButton.Text = "Clear";
            this.ClearReceiverCiphertextButton.UseVisualStyleBackColor = true;
            this.ClearReceiverCiphertextButton.Click += new System.EventHandler(this.ClearReceiverCiphertextButton_Click);
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 510);
            this.Controls.Add(this.ClearReceiverCiphertextButton);
            this.Controls.Add(this.ClearReceiverPlaintextButton);
            this.Controls.Add(this.ClearSenderPlaintextButton);
            this.Controls.Add(this.ClearSenderCiphertextButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReceiverSendButton);
            this.Controls.Add(this.SenderSendButton);
            this.Controls.Add(this.ReceiverDecryptButton);
            this.Controls.Add(this.SenderDecryptButton);
            this.Controls.Add(this.ReceiverCiphertextProgressBar);
            this.Controls.Add(this.SenderCiphertextProgressBar);
            this.Controls.Add(this.ReceiverPlaintextProgressBar);
            this.Controls.Add(this.SenderPlaintextProgressBar);
            this.Controls.Add(this.ReceiverCiphertextTextBox);
            this.Controls.Add(this.SenderCiphertextTextBox);
            this.Controls.Add(this.ReceiverPlaintextTextBox);
            this.Controls.Add(this.SenderPlaintextTextBox);
            this.Name = "Plugin";
            this.Text = "Plugin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SenderPlaintextTextBox;
        private System.Windows.Forms.TextBox ReceiverPlaintextTextBox;
        private System.Windows.Forms.TextBox SenderCiphertextTextBox;
        private System.Windows.Forms.TextBox ReceiverCiphertextTextBox;
        private System.Windows.Forms.ProgressBar SenderPlaintextProgressBar;
        private System.Windows.Forms.ProgressBar ReceiverPlaintextProgressBar;
        private System.Windows.Forms.ProgressBar SenderCiphertextProgressBar;
        private System.Windows.Forms.ProgressBar ReceiverCiphertextProgressBar;
        private System.Windows.Forms.Button SenderDecryptButton;
        private System.Windows.Forms.Button ReceiverDecryptButton;
        private System.Windows.Forms.Button SenderSendButton;
        private System.Windows.Forms.Button ReceiverSendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearSenderCiphertextButton;
        private System.Windows.Forms.Button ClearSenderPlaintextButton;
        private System.Windows.Forms.Button ClearReceiverPlaintextButton;
        private System.Windows.Forms.Button ClearReceiverCiphertextButton;
    }
}
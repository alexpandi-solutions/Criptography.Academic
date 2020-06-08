namespace App.Rc4
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
            this.PlaintextTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.CiphertextTextBox = new System.Windows.Forms.TextBox();
            this.PlaintextProgressBar = new System.Windows.Forms.ProgressBar();
            this.KeyProgressBar = new System.Windows.Forms.ProgressBar();
            this.CiphertextProgressBar = new System.Windows.Forms.ProgressBar();
            this.ClearPlaintextButton = new System.Windows.Forms.Button();
            this.ClearCiphertextButton = new System.Windows.Forms.Button();
            this.ClearKeyButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.GenerateKeyButton = new System.Windows.Forms.Button();
            this.PlaintextLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.CiphertextLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlaintextTextBox
            // 
            this.PlaintextTextBox.Location = new System.Drawing.Point(14, 28);
            this.PlaintextTextBox.Multiline = true;
            this.PlaintextTextBox.Name = "PlaintextTextBox";
            this.PlaintextTextBox.Size = new System.Drawing.Size(252, 327);
            this.PlaintextTextBox.TabIndex = 0;
            this.PlaintextTextBox.TextChanged += new System.EventHandler(this.PlaintextTextBox_TextChanged);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(272, 28);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(252, 327);
            this.KeyTextBox.TabIndex = 0;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // CiphertextTextBox
            // 
            this.CiphertextTextBox.Location = new System.Drawing.Point(530, 28);
            this.CiphertextTextBox.Multiline = true;
            this.CiphertextTextBox.Name = "CiphertextTextBox";
            this.CiphertextTextBox.Size = new System.Drawing.Size(252, 327);
            this.CiphertextTextBox.TabIndex = 0;
            this.CiphertextTextBox.TextChanged += new System.EventHandler(this.CiphertextTextBox_TextChanged);
            // 
            // PlaintextProgressBar
            // 
            this.PlaintextProgressBar.Location = new System.Drawing.Point(14, 361);
            this.PlaintextProgressBar.Name = "PlaintextProgressBar";
            this.PlaintextProgressBar.Size = new System.Drawing.Size(252, 10);
            this.PlaintextProgressBar.TabIndex = 1;
            // 
            // KeyProgressBar
            // 
            this.KeyProgressBar.Location = new System.Drawing.Point(272, 361);
            this.KeyProgressBar.Name = "KeyProgressBar";
            this.KeyProgressBar.Size = new System.Drawing.Size(252, 10);
            this.KeyProgressBar.TabIndex = 1;
            // 
            // CiphertextProgressBar
            // 
            this.CiphertextProgressBar.Location = new System.Drawing.Point(530, 361);
            this.CiphertextProgressBar.Name = "CiphertextProgressBar";
            this.CiphertextProgressBar.Size = new System.Drawing.Size(252, 10);
            this.CiphertextProgressBar.TabIndex = 1;
            // 
            // ClearPlaintextButton
            // 
            this.ClearPlaintextButton.Location = new System.Drawing.Point(144, 377);
            this.ClearPlaintextButton.Name = "ClearPlaintextButton";
            this.ClearPlaintextButton.Size = new System.Drawing.Size(122, 28);
            this.ClearPlaintextButton.TabIndex = 2;
            this.ClearPlaintextButton.Text = "Clear Plaintext";
            this.ClearPlaintextButton.UseVisualStyleBackColor = true;
            this.ClearPlaintextButton.Click += new System.EventHandler(this.ClearPlaintextButton_Click);
            // 
            // ClearCiphertextButton
            // 
            this.ClearCiphertextButton.Location = new System.Drawing.Point(660, 377);
            this.ClearCiphertextButton.Name = "ClearCiphertextButton";
            this.ClearCiphertextButton.Size = new System.Drawing.Size(122, 28);
            this.ClearCiphertextButton.TabIndex = 2;
            this.ClearCiphertextButton.Text = "Clear Ciphertext";
            this.ClearCiphertextButton.UseVisualStyleBackColor = true;
            this.ClearCiphertextButton.Click += new System.EventHandler(this.ClearCiphertextButton_Click);
            // 
            // ClearKeyButton
            // 
            this.ClearKeyButton.Location = new System.Drawing.Point(402, 377);
            this.ClearKeyButton.Name = "ClearKeyButton";
            this.ClearKeyButton.Size = new System.Drawing.Size(122, 28);
            this.ClearKeyButton.TabIndex = 2;
            this.ClearKeyButton.Text = "Clear Key";
            this.ClearKeyButton.UseVisualStyleBackColor = true;
            this.ClearKeyButton.Click += new System.EventHandler(this.ClearKeyButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(14, 377);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(122, 28);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(530, 377);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(122, 28);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // GenerateKeyButton
            // 
            this.GenerateKeyButton.Location = new System.Drawing.Point(272, 377);
            this.GenerateKeyButton.Name = "GenerateKeyButton";
            this.GenerateKeyButton.Size = new System.Drawing.Size(122, 28);
            this.GenerateKeyButton.TabIndex = 2;
            this.GenerateKeyButton.Text = "Generate Key";
            this.GenerateKeyButton.UseVisualStyleBackColor = true;
            this.GenerateKeyButton.Click += new System.EventHandler(this.GenerateKeyButton_Click);
            // 
            // PlaintextLabel
            // 
            this.PlaintextLabel.AutoSize = true;
            this.PlaintextLabel.Location = new System.Drawing.Point(14, 10);
            this.PlaintextLabel.Name = "PlaintextLabel";
            this.PlaintextLabel.Size = new System.Drawing.Size(53, 15);
            this.PlaintextLabel.TabIndex = 3;
            this.PlaintextLabel.Text = "Plaintext";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(272, 10);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(86, 15);
            this.KeyLabel.TabIndex = 3;
            this.KeyLabel.Text = "Encryption Key";
            // 
            // CiphertextLabel
            // 
            this.CiphertextLabel.AutoSize = true;
            this.CiphertextLabel.Location = new System.Drawing.Point(530, 10);
            this.CiphertextLabel.Name = "CiphertextLabel";
            this.CiphertextLabel.Size = new System.Drawing.Size(62, 15);
            this.CiphertextLabel.TabIndex = 3;
            this.CiphertextLabel.Text = "Ciphertext";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(272, 411);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 28);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(402, 411);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(122, 28);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 451);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CiphertextLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.PlaintextLabel);
            this.Controls.Add(this.GenerateKeyButton);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ClearKeyButton);
            this.Controls.Add(this.ClearCiphertextButton);
            this.Controls.Add(this.ClearPlaintextButton);
            this.Controls.Add(this.CiphertextProgressBar);
            this.Controls.Add(this.KeyProgressBar);
            this.Controls.Add(this.PlaintextProgressBar);
            this.Controls.Add(this.CiphertextTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.PlaintextTextBox);
            this.Name = "Plugin";
            this.Text = "Rivest Cipher 4 (RC4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlaintextTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.TextBox CiphertextTextBox;
        private System.Windows.Forms.ProgressBar PlaintextProgressBar;
        private System.Windows.Forms.ProgressBar KeyProgressBar;
        private System.Windows.Forms.ProgressBar CiphertextProgressBar;
        private System.Windows.Forms.Button ClearPlaintextButton;
        private System.Windows.Forms.Button ClearCiphertextButton;
        private System.Windows.Forms.Button ClearKeyButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button GenerateKeyButton;
        private System.Windows.Forms.Label PlaintextLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label CiphertextLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
    }
}
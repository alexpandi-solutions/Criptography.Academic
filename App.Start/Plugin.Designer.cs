namespace App.Start
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
            this.AlgorithmOption = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlgorithmOption
            // 
            this.AlgorithmOption.FormattingEnabled = true;
            this.AlgorithmOption.Items.AddRange(new object[] {
            "Advanced Encryption Standard (AES)",
            "Rivest Cipher 4 (RC4)",
            "Pretty Good Privacy (PGP)",
            "Diffie Hellman (DH)"});
            this.AlgorithmOption.Location = new System.Drawing.Point(14, 30);
            this.AlgorithmOption.Name = "AlgorithmOption";
            this.AlgorithmOption.Size = new System.Drawing.Size(318, 23);
            this.AlgorithmOption.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(14, 59);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(155, 25);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ProceedButton
            // 
            this.ProceedButton.Location = new System.Drawing.Point(177, 59);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(155, 25);
            this.ProceedButton.TabIndex = 1;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(12, 12);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(188, 15);
            this.ActionLabel.TabIndex = 2;
            this.ActionLabel.Text = "Choose the encryption algorithm: ";
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 103);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AlgorithmOption);
            this.Name = "Plugin";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AlgorithmOption;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.Label ActionLabel;
    }
}
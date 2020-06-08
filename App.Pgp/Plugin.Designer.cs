namespace App.Pgp
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PublicKeyTextBox = new System.Windows.Forms.TextBox();
            this.PrivateKeyTextBox = new System.Windows.Forms.TextBox();
            this.PublicKeyLabel = new System.Windows.Forms.Label();
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.GenerateKeysButton = new System.Windows.Forms.Button();
            this.UnloadKeysButton = new System.Windows.Forms.Button();
            this.PrivateKeyProgressBar = new System.Windows.Forms.ProgressBar();
            this.PublicKeyProgressBar = new System.Windows.Forms.ProgressBar();
            this.PlaintextTextBox = new System.Windows.Forms.TextBox();
            this.PlaintextLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.UnloadPublicKeyButton = new System.Windows.Forms.Button();
            this.UnloadPrivateKeyButton = new System.Windows.Forms.Button();
            this.ClearPasswordButton = new System.Windows.Forms.Button();
            this.ClearEmailButton = new System.Windows.Forms.Button();
            this.ClearFileNameButton = new System.Windows.Forms.Button();
            this.DecryptProgressBar = new System.Windows.Forms.ProgressBar();
            this.CiphertextTextBox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptProgressBar = new System.Windows.Forms.ProgressBar();
            this.ClearPlaintextButton = new System.Windows.Forms.Button();
            this.ClearCiphertextButton = new System.Windows.Forms.Button();
            this.CiphertextLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EncryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ClearEncryptPasswordButton = new System.Windows.Forms.Button();
            this.EncryptPasswordLabel = new System.Windows.Forms.Label();
            this.DecryptPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ClearDecryptPasswordButton = new System.Windows.Forms.Button();
            this.DecryptPasswordLabel = new System.Windows.Forms.Label();
            this.LoadPublicKeyButton = new System.Windows.Forms.Button();
            this.LoadPrivateKeyButton = new System.Windows.Forms.Button();
            this.PasswordHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.EncryptPasswordHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.DecryptPasswordHiddenCheckBox = new System.Windows.Forms.CheckBox();
            this.GenerateFileNameButton = new System.Windows.Forms.Button();
            this.GenerateEmailButton = new System.Windows.Forms.Button();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.CopyPasswordButton = new System.Windows.Forms.Button();
            this.PasteEncryptionPasswordButton = new System.Windows.Forms.Button();
            this.PasteDecryptionPasswordButton = new System.Windows.Forms.Button();
            this.PrivateKeyPathTextBox = new System.Windows.Forms.TextBox();
            this.PlaintextPathTextBox = new System.Windows.Forms.TextBox();
            this.CiphertextPathTextBox = new System.Windows.Forms.TextBox();
            this.PublicKeyPathTextBox = new System.Windows.Forms.TextBox();
            this.UploadPlaintextButton = new System.Windows.Forms.Button();
            this.UploadCiphertextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(19, 87);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(241, 23);
            this.EmailTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(19, 132);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(241, 23);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(19, 69);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailLabel.TabIndex = 1;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(19, 114);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // PublicKeyTextBox
            // 
            this.PublicKeyTextBox.Location = new System.Drawing.Point(19, 190);
            this.PublicKeyTextBox.Multiline = true;
            this.PublicKeyTextBox.Name = "PublicKeyTextBox";
            this.PublicKeyTextBox.Size = new System.Drawing.Size(485, 232);
            this.PublicKeyTextBox.TabIndex = 0;
            this.PublicKeyTextBox.TextChanged += new System.EventHandler(this.PublicKeyTextBox_TextChanged);
            // 
            // PrivateKeyTextBox
            // 
            this.PrivateKeyTextBox.Location = new System.Drawing.Point(19, 502);
            this.PrivateKeyTextBox.Multiline = true;
            this.PrivateKeyTextBox.Name = "PrivateKeyTextBox";
            this.PrivateKeyTextBox.Size = new System.Drawing.Size(485, 232);
            this.PrivateKeyTextBox.TabIndex = 0;
            this.PrivateKeyTextBox.TextChanged += new System.EventHandler(this.PrivateKeyTextBox_TextChanged);
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Location = new System.Drawing.Point(19, 172);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(62, 15);
            this.PublicKeyLabel.TabIndex = 1;
            this.PublicKeyLabel.Text = "Public Key";
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Location = new System.Drawing.Point(19, 484);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(65, 15);
            this.PrivateKeyLabel.TabIndex = 1;
            this.PrivateKeyLabel.Text = "Private Key";
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FileNameTextBox.Location = new System.Drawing.Point(19, 42);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(241, 23);
            this.FileNameTextBox.TabIndex = 0;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(19, 24);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(60, 15);
            this.FileNameLabel.TabIndex = 1;
            this.FileNameLabel.Text = "File Name";
            // 
            // GenerateKeysButton
            // 
            this.GenerateKeysButton.Location = new System.Drawing.Point(266, 161);
            this.GenerateKeysButton.Name = "GenerateKeysButton";
            this.GenerateKeysButton.Size = new System.Drawing.Size(116, 23);
            this.GenerateKeysButton.TabIndex = 2;
            this.GenerateKeysButton.Text = "Generate Keys";
            this.GenerateKeysButton.UseVisualStyleBackColor = true;
            this.GenerateKeysButton.Click += new System.EventHandler(this.GenerateKeysButton_Click);
            // 
            // UnloadKeysButton
            // 
            this.UnloadKeysButton.Location = new System.Drawing.Point(387, 813);
            this.UnloadKeysButton.Name = "UnloadKeysButton";
            this.UnloadKeysButton.Size = new System.Drawing.Size(117, 23);
            this.UnloadKeysButton.TabIndex = 2;
            this.UnloadKeysButton.Text = "Unload Keys";
            this.UnloadKeysButton.UseVisualStyleBackColor = true;
            this.UnloadKeysButton.Click += new System.EventHandler(this.UnloadKeysButton_Click);
            // 
            // PrivateKeyProgressBar
            // 
            this.PrivateKeyProgressBar.Location = new System.Drawing.Point(19, 769);
            this.PrivateKeyProgressBar.Name = "PrivateKeyProgressBar";
            this.PrivateKeyProgressBar.Size = new System.Drawing.Size(485, 10);
            this.PrivateKeyProgressBar.TabIndex = 3;
            // 
            // PublicKeyProgressBar
            // 
            this.PublicKeyProgressBar.Location = new System.Drawing.Point(19, 457);
            this.PublicKeyProgressBar.Name = "PublicKeyProgressBar";
            this.PublicKeyProgressBar.Size = new System.Drawing.Size(485, 10);
            this.PublicKeyProgressBar.TabIndex = 3;
            // 
            // PlaintextTextBox
            // 
            this.PlaintextTextBox.Location = new System.Drawing.Point(510, 42);
            this.PlaintextTextBox.Multiline = true;
            this.PlaintextTextBox.Name = "PlaintextTextBox";
            this.PlaintextTextBox.Size = new System.Drawing.Size(485, 692);
            this.PlaintextTextBox.TabIndex = 0;
            this.PlaintextTextBox.TextChanged += new System.EventHandler(this.PlaintextTextBox_TextChanged);
            // 
            // PlaintextLabel
            // 
            this.PlaintextLabel.AutoSize = true;
            this.PlaintextLabel.Location = new System.Drawing.Point(510, 24);
            this.PlaintextLabel.Name = "PlaintextLabel";
            this.PlaintextLabel.Size = new System.Drawing.Size(53, 15);
            this.PlaintextLabel.TabIndex = 4;
            this.PlaintextLabel.Text = "Plaintext";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(757, 785);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(116, 23);
            this.EncryptButton.TabIndex = 2;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // UnloadPublicKeyButton
            // 
            this.UnloadPublicKeyButton.Location = new System.Drawing.Point(387, 473);
            this.UnloadPublicKeyButton.Name = "UnloadPublicKeyButton";
            this.UnloadPublicKeyButton.Size = new System.Drawing.Size(117, 23);
            this.UnloadPublicKeyButton.TabIndex = 2;
            this.UnloadPublicKeyButton.Text = "Unload Public Key";
            this.UnloadPublicKeyButton.UseVisualStyleBackColor = true;
            this.UnloadPublicKeyButton.Click += new System.EventHandler(this.UnloadPublicKeyButton_Click);
            // 
            // UnloadPrivateKeyButton
            // 
            this.UnloadPrivateKeyButton.Location = new System.Drawing.Point(387, 785);
            this.UnloadPrivateKeyButton.Name = "UnloadPrivateKeyButton";
            this.UnloadPrivateKeyButton.Size = new System.Drawing.Size(117, 23);
            this.UnloadPrivateKeyButton.TabIndex = 2;
            this.UnloadPrivateKeyButton.Text = "Unload Private Key";
            this.UnloadPrivateKeyButton.UseVisualStyleBackColor = true;
            this.UnloadPrivateKeyButton.Click += new System.EventHandler(this.UnloadPrivateKeyButton_Click);
            // 
            // ClearPasswordButton
            // 
            this.ClearPasswordButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearPasswordButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearPasswordButton.Location = new System.Drawing.Point(387, 132);
            this.ClearPasswordButton.Name = "ClearPasswordButton";
            this.ClearPasswordButton.Size = new System.Drawing.Size(117, 23);
            this.ClearPasswordButton.TabIndex = 2;
            this.ClearPasswordButton.Text = "Clear Password";
            this.ClearPasswordButton.UseVisualStyleBackColor = false;
            this.ClearPasswordButton.Click += new System.EventHandler(this.ClearPasswordButton_Click);
            // 
            // ClearEmailButton
            // 
            this.ClearEmailButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearEmailButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearEmailButton.Location = new System.Drawing.Point(387, 87);
            this.ClearEmailButton.Name = "ClearEmailButton";
            this.ClearEmailButton.Size = new System.Drawing.Size(117, 23);
            this.ClearEmailButton.TabIndex = 2;
            this.ClearEmailButton.Text = "Clear Email";
            this.ClearEmailButton.UseVisualStyleBackColor = false;
            this.ClearEmailButton.Click += new System.EventHandler(this.ClearEmailButton_Click);
            // 
            // ClearFileNameButton
            // 
            this.ClearFileNameButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearFileNameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearFileNameButton.Location = new System.Drawing.Point(387, 42);
            this.ClearFileNameButton.Name = "ClearFileNameButton";
            this.ClearFileNameButton.Size = new System.Drawing.Size(117, 23);
            this.ClearFileNameButton.TabIndex = 2;
            this.ClearFileNameButton.Text = "Drop File";
            this.ClearFileNameButton.UseVisualStyleBackColor = false;
            this.ClearFileNameButton.Click += new System.EventHandler(this.ClearFileNameButton_Click);
            // 
            // DecryptProgressBar
            // 
            this.DecryptProgressBar.Location = new System.Drawing.Point(510, 769);
            this.DecryptProgressBar.Name = "DecryptProgressBar";
            this.DecryptProgressBar.Size = new System.Drawing.Size(485, 10);
            this.DecryptProgressBar.TabIndex = 3;
            // 
            // CiphertextTextBox
            // 
            this.CiphertextTextBox.Location = new System.Drawing.Point(1001, 42);
            this.CiphertextTextBox.Multiline = true;
            this.CiphertextTextBox.Name = "CiphertextTextBox";
            this.CiphertextTextBox.Size = new System.Drawing.Size(485, 692);
            this.CiphertextTextBox.TabIndex = 0;
            this.CiphertextTextBox.TextChanged += new System.EventHandler(this.CiphertextTextBox_TextChanged);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(1248, 785);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(116, 23);
            this.DecryptButton.TabIndex = 2;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptProgressBar
            // 
            this.EncryptProgressBar.Location = new System.Drawing.Point(1001, 769);
            this.EncryptProgressBar.Name = "EncryptProgressBar";
            this.EncryptProgressBar.Size = new System.Drawing.Size(485, 10);
            this.EncryptProgressBar.TabIndex = 3;
            // 
            // ClearPlaintextButton
            // 
            this.ClearPlaintextButton.Location = new System.Drawing.Point(879, 785);
            this.ClearPlaintextButton.Name = "ClearPlaintextButton";
            this.ClearPlaintextButton.Size = new System.Drawing.Size(116, 23);
            this.ClearPlaintextButton.TabIndex = 2;
            this.ClearPlaintextButton.Text = "Clear Plaintext";
            this.ClearPlaintextButton.UseVisualStyleBackColor = true;
            this.ClearPlaintextButton.Click += new System.EventHandler(this.ClearPlaintextButton_Click);
            // 
            // ClearCiphertextButton
            // 
            this.ClearCiphertextButton.Location = new System.Drawing.Point(1370, 785);
            this.ClearCiphertextButton.Name = "ClearCiphertextButton";
            this.ClearCiphertextButton.Size = new System.Drawing.Size(116, 23);
            this.ClearCiphertextButton.TabIndex = 2;
            this.ClearCiphertextButton.Text = "Clear Ciphertext";
            this.ClearCiphertextButton.UseVisualStyleBackColor = true;
            this.ClearCiphertextButton.Click += new System.EventHandler(this.ClearCiphertextButton_Click);
            // 
            // CiphertextLabel
            // 
            this.CiphertextLabel.AutoSize = true;
            this.CiphertextLabel.Location = new System.Drawing.Point(1001, 24);
            this.CiphertextLabel.Name = "CiphertextLabel";
            this.CiphertextLabel.Size = new System.Drawing.Size(62, 15);
            this.CiphertextLabel.TabIndex = 4;
            this.CiphertextLabel.Text = "Ciphertext";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(19, 785);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(117, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(19, 813);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(117, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EncryptPasswordTextBox
            // 
            this.EncryptPasswordTextBox.Location = new System.Drawing.Point(510, 813);
            this.EncryptPasswordTextBox.Name = "EncryptPasswordTextBox";
            this.EncryptPasswordTextBox.Size = new System.Drawing.Size(241, 23);
            this.EncryptPasswordTextBox.TabIndex = 0;
            // 
            // ClearEncryptPasswordButton
            // 
            this.ClearEncryptPasswordButton.Location = new System.Drawing.Point(879, 813);
            this.ClearEncryptPasswordButton.Name = "ClearEncryptPasswordButton";
            this.ClearEncryptPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.ClearEncryptPasswordButton.TabIndex = 2;
            this.ClearEncryptPasswordButton.Text = "Clear Password";
            this.ClearEncryptPasswordButton.UseVisualStyleBackColor = true;
            this.ClearEncryptPasswordButton.Click += new System.EventHandler(this.ClearEncryptPasswordButton_Click);
            // 
            // EncryptPasswordLabel
            // 
            this.EncryptPasswordLabel.AutoSize = true;
            this.EncryptPasswordLabel.Location = new System.Drawing.Point(510, 795);
            this.EncryptPasswordLabel.Name = "EncryptPasswordLabel";
            this.EncryptPasswordLabel.Size = new System.Drawing.Size(83, 15);
            this.EncryptPasswordLabel.TabIndex = 1;
            this.EncryptPasswordLabel.Text = "Sign Password";
            // 
            // DecryptPasswordTextBox
            // 
            this.DecryptPasswordTextBox.Location = new System.Drawing.Point(1001, 813);
            this.DecryptPasswordTextBox.Name = "DecryptPasswordTextBox";
            this.DecryptPasswordTextBox.Size = new System.Drawing.Size(241, 23);
            this.DecryptPasswordTextBox.TabIndex = 0;
            // 
            // ClearDecryptPasswordButton
            // 
            this.ClearDecryptPasswordButton.Location = new System.Drawing.Point(1370, 813);
            this.ClearDecryptPasswordButton.Name = "ClearDecryptPasswordButton";
            this.ClearDecryptPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.ClearDecryptPasswordButton.TabIndex = 2;
            this.ClearDecryptPasswordButton.Text = "Clear Password";
            this.ClearDecryptPasswordButton.UseVisualStyleBackColor = true;
            this.ClearDecryptPasswordButton.Click += new System.EventHandler(this.ClearDecryptPasswordButton_Click);
            // 
            // DecryptPasswordLabel
            // 
            this.DecryptPasswordLabel.AutoSize = true;
            this.DecryptPasswordLabel.Location = new System.Drawing.Point(1001, 795);
            this.DecryptPasswordLabel.Name = "DecryptPasswordLabel";
            this.DecryptPasswordLabel.Size = new System.Drawing.Size(97, 15);
            this.DecryptPasswordLabel.TabIndex = 1;
            this.DecryptPasswordLabel.Text = "Unlock Password";
            // 
            // LoadPublicKeyButton
            // 
            this.LoadPublicKeyButton.Location = new System.Drawing.Point(266, 473);
            this.LoadPublicKeyButton.Name = "LoadPublicKeyButton";
            this.LoadPublicKeyButton.Size = new System.Drawing.Size(116, 23);
            this.LoadPublicKeyButton.TabIndex = 5;
            this.LoadPublicKeyButton.Text = "Load Public Key";
            this.LoadPublicKeyButton.UseVisualStyleBackColor = true;
            this.LoadPublicKeyButton.Click += new System.EventHandler(this.LoadPublicKeyButton_Click);
            // 
            // LoadPrivateKeyButton
            // 
            this.LoadPrivateKeyButton.Location = new System.Drawing.Point(266, 785);
            this.LoadPrivateKeyButton.Name = "LoadPrivateKeyButton";
            this.LoadPrivateKeyButton.Size = new System.Drawing.Size(116, 23);
            this.LoadPrivateKeyButton.TabIndex = 5;
            this.LoadPrivateKeyButton.Text = "Load Private Key";
            this.LoadPrivateKeyButton.UseVisualStyleBackColor = true;
            this.LoadPrivateKeyButton.Click += new System.EventHandler(this.LoadPrivateKeyButton_Click);
            // 
            // PasswordHiddenCheckBox
            // 
            this.PasswordHiddenCheckBox.AutoSize = true;
            this.PasswordHiddenCheckBox.Location = new System.Drawing.Point(82, 113);
            this.PasswordHiddenCheckBox.Name = "PasswordHiddenCheckBox";
            this.PasswordHiddenCheckBox.Size = new System.Drawing.Size(65, 19);
            this.PasswordHiddenCheckBox.TabIndex = 6;
            this.PasswordHiddenCheckBox.Text = "Hidden";
            this.PasswordHiddenCheckBox.UseVisualStyleBackColor = true;
            this.PasswordHiddenCheckBox.CheckedChanged += new System.EventHandler(this.PasswordHiddenCheckBox_CheckedChanged);
            // 
            // EncryptPasswordHiddenCheckBox
            // 
            this.EncryptPasswordHiddenCheckBox.AutoSize = true;
            this.EncryptPasswordHiddenCheckBox.Location = new System.Drawing.Point(599, 794);
            this.EncryptPasswordHiddenCheckBox.Name = "EncryptPasswordHiddenCheckBox";
            this.EncryptPasswordHiddenCheckBox.Size = new System.Drawing.Size(65, 19);
            this.EncryptPasswordHiddenCheckBox.TabIndex = 7;
            this.EncryptPasswordHiddenCheckBox.Text = "Hidden";
            this.EncryptPasswordHiddenCheckBox.UseVisualStyleBackColor = true;
            this.EncryptPasswordHiddenCheckBox.CheckedChanged += new System.EventHandler(this.EncryptPasswordHiddenCheckBox_CheckedChanged);
            // 
            // DecryptPasswordHiddenCheckBox
            // 
            this.DecryptPasswordHiddenCheckBox.AutoSize = true;
            this.DecryptPasswordHiddenCheckBox.Location = new System.Drawing.Point(1104, 794);
            this.DecryptPasswordHiddenCheckBox.Name = "DecryptPasswordHiddenCheckBox";
            this.DecryptPasswordHiddenCheckBox.Size = new System.Drawing.Size(65, 19);
            this.DecryptPasswordHiddenCheckBox.TabIndex = 8;
            this.DecryptPasswordHiddenCheckBox.Text = "Hidden";
            this.DecryptPasswordHiddenCheckBox.UseVisualStyleBackColor = true;
            this.DecryptPasswordHiddenCheckBox.CheckedChanged += new System.EventHandler(this.DecryptPasswordHiddenCheckBox_CheckedChanged);
            // 
            // GenerateFileNameButton
            // 
            this.GenerateFileNameButton.BackColor = System.Drawing.SystemColors.Control;
            this.GenerateFileNameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerateFileNameButton.Location = new System.Drawing.Point(266, 42);
            this.GenerateFileNameButton.Name = "GenerateFileNameButton";
            this.GenerateFileNameButton.Size = new System.Drawing.Size(116, 23);
            this.GenerateFileNameButton.TabIndex = 9;
            this.GenerateFileNameButton.Text = "Generate File";
            this.GenerateFileNameButton.UseVisualStyleBackColor = false;
            this.GenerateFileNameButton.Click += new System.EventHandler(this.GenerateFileNameButton_Click);
            // 
            // GenerateEmailButton
            // 
            this.GenerateEmailButton.BackColor = System.Drawing.SystemColors.Control;
            this.GenerateEmailButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerateEmailButton.Location = new System.Drawing.Point(266, 87);
            this.GenerateEmailButton.Name = "GenerateEmailButton";
            this.GenerateEmailButton.Size = new System.Drawing.Size(116, 23);
            this.GenerateEmailButton.TabIndex = 10;
            this.GenerateEmailButton.Text = "Generate Email";
            this.GenerateEmailButton.UseVisualStyleBackColor = false;
            this.GenerateEmailButton.Click += new System.EventHandler(this.GenerateEmailButton_Click);
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.BackColor = System.Drawing.SystemColors.Control;
            this.GeneratePasswordButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GeneratePasswordButton.Location = new System.Drawing.Point(266, 132);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(116, 23);
            this.GeneratePasswordButton.TabIndex = 11;
            this.GeneratePasswordButton.Text = "Generate Password";
            this.GeneratePasswordButton.UseVisualStyleBackColor = false;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // CopyPasswordButton
            // 
            this.CopyPasswordButton.Location = new System.Drawing.Point(144, 161);
            this.CopyPasswordButton.Name = "CopyPasswordButton";
            this.CopyPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.CopyPasswordButton.TabIndex = 12;
            this.CopyPasswordButton.Text = "Copy Password";
            this.CopyPasswordButton.UseVisualStyleBackColor = true;
            this.CopyPasswordButton.Click += new System.EventHandler(this.CopyPasswordButton_Click);
            // 
            // PasteEncryptionPasswordButton
            // 
            this.PasteEncryptionPasswordButton.Location = new System.Drawing.Point(757, 813);
            this.PasteEncryptionPasswordButton.Name = "PasteEncryptionPasswordButton";
            this.PasteEncryptionPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.PasteEncryptionPasswordButton.TabIndex = 12;
            this.PasteEncryptionPasswordButton.Text = "Paste Password";
            this.PasteEncryptionPasswordButton.UseVisualStyleBackColor = true;
            this.PasteEncryptionPasswordButton.Click += new System.EventHandler(this.PasteEncryptionPasswordButton_Click);
            // 
            // PasteDecryptionPasswordButton
            // 
            this.PasteDecryptionPasswordButton.Location = new System.Drawing.Point(1248, 813);
            this.PasteDecryptionPasswordButton.Name = "PasteDecryptionPasswordButton";
            this.PasteDecryptionPasswordButton.Size = new System.Drawing.Size(116, 23);
            this.PasteDecryptionPasswordButton.TabIndex = 12;
            this.PasteDecryptionPasswordButton.Text = "Paste Password";
            this.PasteDecryptionPasswordButton.UseVisualStyleBackColor = true;
            this.PasteDecryptionPasswordButton.Click += new System.EventHandler(this.PasteDecryptionPasswordButton_Click);
            // 
            // PrivateKeyPathTextBox
            // 
            this.PrivateKeyPathTextBox.Enabled = false;
            this.PrivateKeyPathTextBox.Location = new System.Drawing.Point(19, 740);
            this.PrivateKeyPathTextBox.Name = "PrivateKeyPathTextBox";
            this.PrivateKeyPathTextBox.Size = new System.Drawing.Size(485, 23);
            this.PrivateKeyPathTextBox.TabIndex = 13;
            // 
            // PlaintextPathTextBox
            // 
            this.PlaintextPathTextBox.Enabled = false;
            this.PlaintextPathTextBox.Location = new System.Drawing.Point(510, 740);
            this.PlaintextPathTextBox.Name = "PlaintextPathTextBox";
            this.PlaintextPathTextBox.Size = new System.Drawing.Size(485, 23);
            this.PlaintextPathTextBox.TabIndex = 14;
            // 
            // CiphertextPathTextBox
            // 
            this.CiphertextPathTextBox.Enabled = false;
            this.CiphertextPathTextBox.Location = new System.Drawing.Point(1001, 740);
            this.CiphertextPathTextBox.Name = "CiphertextPathTextBox";
            this.CiphertextPathTextBox.Size = new System.Drawing.Size(485, 23);
            this.CiphertextPathTextBox.TabIndex = 15;
            // 
            // PublicKeyPathTextBox
            // 
            this.PublicKeyPathTextBox.Enabled = false;
            this.PublicKeyPathTextBox.Location = new System.Drawing.Point(19, 428);
            this.PublicKeyPathTextBox.Name = "PublicKeyPathTextBox";
            this.PublicKeyPathTextBox.Size = new System.Drawing.Size(485, 23);
            this.PublicKeyPathTextBox.TabIndex = 16;
            // 
            // UploadPlaintextButton
            // 
            this.UploadPlaintextButton.BackColor = System.Drawing.SystemColors.Control;
            this.UploadPlaintextButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UploadPlaintextButton.Location = new System.Drawing.Point(879, 16);
            this.UploadPlaintextButton.Name = "UploadPlaintextButton";
            this.UploadPlaintextButton.Size = new System.Drawing.Size(116, 23);
            this.UploadPlaintextButton.TabIndex = 17;
            this.UploadPlaintextButton.Text = "Upload Plaintext";
            this.UploadPlaintextButton.UseVisualStyleBackColor = false;
            this.UploadPlaintextButton.Click += new System.EventHandler(this.UploadPlaintextButton_Click);
            // 
            // UploadCiphertextButton
            // 
            this.UploadCiphertextButton.Location = new System.Drawing.Point(1370, 16);
            this.UploadCiphertextButton.Name = "UploadCiphertextButton";
            this.UploadCiphertextButton.Size = new System.Drawing.Size(116, 23);
            this.UploadCiphertextButton.TabIndex = 18;
            this.UploadCiphertextButton.Text = "Upload Ciphertext";
            this.UploadCiphertextButton.UseVisualStyleBackColor = true;
            this.UploadCiphertextButton.Click += new System.EventHandler(this.UploadCiphertextButton_Click);
            // 
            // Plugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 855);
            this.Controls.Add(this.UploadCiphertextButton);
            this.Controls.Add(this.UploadPlaintextButton);
            this.Controls.Add(this.PublicKeyPathTextBox);
            this.Controls.Add(this.CiphertextPathTextBox);
            this.Controls.Add(this.PlaintextPathTextBox);
            this.Controls.Add(this.PrivateKeyPathTextBox);
            this.Controls.Add(this.PasteDecryptionPasswordButton);
            this.Controls.Add(this.PasteEncryptionPasswordButton);
            this.Controls.Add(this.CopyPasswordButton);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.GenerateEmailButton);
            this.Controls.Add(this.GenerateFileNameButton);
            this.Controls.Add(this.DecryptPasswordHiddenCheckBox);
            this.Controls.Add(this.EncryptPasswordHiddenCheckBox);
            this.Controls.Add(this.PasswordHiddenCheckBox);
            this.Controls.Add(this.LoadPrivateKeyButton);
            this.Controls.Add(this.LoadPublicKeyButton);
            this.Controls.Add(this.DecryptPasswordLabel);
            this.Controls.Add(this.ClearDecryptPasswordButton);
            this.Controls.Add(this.DecryptPasswordTextBox);
            this.Controls.Add(this.EncryptPasswordLabel);
            this.Controls.Add(this.ClearEncryptPasswordButton);
            this.Controls.Add(this.EncryptPasswordTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CiphertextLabel);
            this.Controls.Add(this.ClearCiphertextButton);
            this.Controls.Add(this.ClearPlaintextButton);
            this.Controls.Add(this.EncryptProgressBar);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.CiphertextTextBox);
            this.Controls.Add(this.DecryptProgressBar);
            this.Controls.Add(this.ClearFileNameButton);
            this.Controls.Add(this.ClearEmailButton);
            this.Controls.Add(this.ClearPasswordButton);
            this.Controls.Add(this.UnloadPrivateKeyButton);
            this.Controls.Add(this.UnloadPublicKeyButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.PlaintextLabel);
            this.Controls.Add(this.PlaintextTextBox);
            this.Controls.Add(this.PublicKeyProgressBar);
            this.Controls.Add(this.PrivateKeyProgressBar);
            this.Controls.Add(this.UnloadKeysButton);
            this.Controls.Add(this.GenerateKeysButton);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.PrivateKeyLabel);
            this.Controls.Add(this.PublicKeyLabel);
            this.Controls.Add(this.PrivateKeyTextBox);
            this.Controls.Add(this.PublicKeyTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "Plugin";
            this.Text = "Pretty Good Privacy (PGP)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PublicKeyTextBox;
        private System.Windows.Forms.TextBox PrivateKeyTextBox;
        private System.Windows.Forms.Label PublicKeyLabel;
        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Button GenerateKeysButton;
        private System.Windows.Forms.Button UnloadKeysButton;
        private System.Windows.Forms.ProgressBar PrivateKeyProgressBar;
        private System.Windows.Forms.ProgressBar PublicKeyProgressBar;
        private System.Windows.Forms.TextBox PlaintextTextBox;
        private System.Windows.Forms.Label PlaintextLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button UnloadPublicKeyButton;
        private System.Windows.Forms.Button UnloadPrivateKeyButton;
        private System.Windows.Forms.Button ClearPasswordButton;
        private System.Windows.Forms.Button ClearEmailButton;
        private System.Windows.Forms.Button ClearFileNameButton;
        private System.Windows.Forms.ProgressBar DecryptProgressBar;
        private System.Windows.Forms.TextBox CiphertextTextBox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.ProgressBar EncryptProgressBar;
        private System.Windows.Forms.Button ClearPlaintextButton;
        private System.Windows.Forms.Button ClearCiphertextButton;
        private System.Windows.Forms.Label CiphertextLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox EncryptPasswordTextBox;
        private System.Windows.Forms.Button ClearEncryptPasswordButton;
        private System.Windows.Forms.Label EncryptPasswordLabel;
        private System.Windows.Forms.TextBox DecryptPasswordTextBox;
        private System.Windows.Forms.Button ClearDecryptPasswordButton;
        private System.Windows.Forms.Label DecryptPasswordLabel;
        private System.Windows.Forms.Button LoadPublicKeyButton;
        private System.Windows.Forms.Button LoadPrivateKeyButton;
        private System.Windows.Forms.CheckBox PasswordHiddenCheckBox;
        private System.Windows.Forms.CheckBox EncryptPasswordHiddenCheckBox;
        private System.Windows.Forms.CheckBox DecryptPasswordHiddenCheckBox;
        private System.Windows.Forms.Button GenerateEmailButton;
        private System.Windows.Forms.Button GenerateFileNameButton;
        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.Button CopyPasswordButton;
        private System.Windows.Forms.Button PasteEncryptionPasswordButton;
        private System.Windows.Forms.Button PasteDecryptionPasswordButton;
        private System.Windows.Forms.TextBox PrivateKeyPathTextBox;
        private System.Windows.Forms.TextBox PlaintextPathTextBox;
        private System.Windows.Forms.TextBox CiphertextPathTextBox;
        private System.Windows.Forms.TextBox PublicKeyPathTextBox;
        private System.Windows.Forms.Button UploadPlaintextButton;
        private System.Windows.Forms.Button UploadCiphertextButton;
    }
}
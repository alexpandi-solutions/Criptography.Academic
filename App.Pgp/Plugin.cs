using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Algorithms;

namespace App.Pgp
{
    public partial class Plugin : Form
    {
        private readonly IPgp _algorithm = new Algorithms.Pgp();
        private string _publicKeyPath;
        private string _privateKeyPath;
        private string _plaintextPath;
        private string _ciphertextPath;

        public Plugin()
        {
            InitializeComponent();
        }

        private void ClearFileNameButton_Click(object sender, EventArgs e)
        {
            FileNameTextBox.ResetText();
        }

        private void ClearEmailButton_Click(object sender, EventArgs e)
        {
            EmailTextBox.ResetText();
        }

        private void ClearPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.ResetText();
        }

        private void ClearEncryptPasswordButton_Click(object sender, EventArgs e)
        {
            EncryptPasswordTextBox.ResetText();
        }

        private void ClearDecryptPasswordButton_Click(object sender, EventArgs e)
        {
            DecryptPasswordTextBox.ResetText();
        }

        private void UnloadPublicKeyButton_Click(object sender, EventArgs e)
        {
            PublicKeyTextBox.ResetText();
            PublicKeyPathTextBox.ResetText();
            _publicKeyPath = string.Empty;
            _algorithm.UpdatePublicKey(_publicKeyPath);
            PublicKeyProgressBar.Value = 0;
        }

        private void UnloadPrivateKeyButton_Click(object sender, EventArgs e)
        {
            PrivateKeyTextBox.ResetText();
            PrivateKeyPathTextBox.ResetText();
            _privateKeyPath = string.Empty;
            _algorithm.UpdatePrivateKey(_privateKeyPath);
            PrivateKeyProgressBar.Value = 0;
        }

        private void ClearPlaintextButton_Click(object sender, EventArgs e)
        {
            PlaintextTextBox.ResetText();
            PlaintextPathTextBox.ResetText();
            _plaintextPath = string.Empty;
            _algorithm.UpdatePlaintext(_plaintextPath);
            DecryptProgressBar.Value = 0;
        }

        private void ClearCiphertextButton_Click(object sender, EventArgs e)
        {
            CiphertextTextBox.ResetText();
            CiphertextPathTextBox.ResetText();
            _ciphertextPath = string.Empty;
            _algorithm.UpdateCiphertext(_ciphertextPath);
            EncryptProgressBar.Value = 0;
        }

        private void UnloadKeysButton_Click(object sender, EventArgs e)
        {
            UnloadPublicKeyButton_Click(this, EventArgs.Empty);
            UnloadPrivateKeyButton_Click(this, EventArgs.Empty);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearFileNameButton_Click(this, EventArgs.Empty);
            ClearEmailButton_Click(this, EventArgs.Empty);
            ClearPasswordButton_Click(this, EventArgs.Empty);
            ClearPlaintextButton_Click(this, EventArgs.Empty);
            ClearEncryptPasswordButton_Click(this, EventArgs.Empty);
            ClearCiphertextButton_Click(this, EventArgs.Empty);
            ClearDecryptPasswordButton_Click(this, EventArgs.Empty);
            UnloadKeysButton_Click(this, EventArgs.Empty);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _algorithm.Unload();
            Close();
        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            bool fileNameDoesNotExist = (string.IsNullOrEmpty(FileNameTextBox.Text) || 
                string.IsNullOrWhiteSpace(FileNameTextBox.Text));
            bool emailDoesNotExist = (string.IsNullOrEmpty(EmailTextBox.Text) || 
                string.IsNullOrWhiteSpace(EmailTextBox.Text));
            bool passwordDoesNotExist = (string.IsNullOrEmpty(PasswordTextBox.Text) || 
                string.IsNullOrWhiteSpace(PasswordTextBox.Text));

            if (fileNameDoesNotExist || emailDoesNotExist || passwordDoesNotExist)
            {
                if (fileNameDoesNotExist)
                    FileNameTextBox.BackColor = Color.Red;

                if (emailDoesNotExist)
                    EmailTextBox.BackColor = Color.Red;

                if (passwordDoesNotExist)
                    PasswordTextBox.BackColor = Color.Red;

                PublicKeyProgressBar.Value = 0;
                PrivateKeyProgressBar.Value = 0;

                UnloadKeysButton_Click(this, EventArgs.Empty);

                MessageBox.Show(
                    "Cannot generate keys! Please make sure that file name, " +
                    "email and password are present and valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                FileNameTextBox.BackColor = Color.White;
                EmailTextBox.BackColor = Color.White;
                PasswordTextBox.BackColor = Color.White;
            }
            else
            {
                _algorithm.LoadKeys(FileNameTextBox.Text);
                string result = _algorithm.GenerateKeyPair(EmailTextBox.Text, PasswordTextBox.Text);

                if (result.Length != 0)
                {
                    MessageBox.Show(
                        "Encryption failed! Reason: " + result,
                        "_algorithm Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    _publicKeyPath = "C:\\TEMP\\App.Pgp\\keys\\" +
                        FileNameTextBox.Text + "_PUBKEY.asc";
                    PublicKeyPathTextBox.Text = _publicKeyPath;
                    PublicKeyTextBox.Text = File.ReadAllText(_publicKeyPath);
                    PublicKeyProgressBar.Value = 100;

                    _privateKeyPath = "C:\\TEMP\\App.Pgp\\keys\\" +
                        FileNameTextBox.Text + "_PRVKEY.asc";
                    PrivateKeyPathTextBox.Text = _privateKeyPath;
                    PrivateKeyTextBox.Text = File.ReadAllText(_privateKeyPath);
                    PrivateKeyProgressBar.Value = 100;
                }
            }
        }

        private void PublicKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            PublicKeyTextBox.Multiline = true;
            PublicKeyTextBox.ScrollBars = ScrollBars.Vertical;
            PublicKeyTextBox.AcceptsReturn = true;
            PublicKeyTextBox.AcceptsTab = true;
            PublicKeyTextBox.WordWrap = true;

            if (PublicKeyTextBox.Text.Length != 0)
                File.WriteAllText(_publicKeyPath, PublicKeyTextBox.Text);
        }

        private void PrivateKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            PrivateKeyTextBox.Multiline = true;
            PrivateKeyTextBox.ScrollBars = ScrollBars.Vertical;
            PrivateKeyTextBox.AcceptsReturn = true;
            PrivateKeyTextBox.AcceptsTab = true;
            PrivateKeyTextBox.WordWrap = true;

            if (PrivateKeyTextBox.Text.Length != 0)
                File.WriteAllText(_privateKeyPath, PrivateKeyTextBox.Text);
        }

        private void PlaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            PlaintextTextBox.Multiline = true;
            PlaintextTextBox.ScrollBars = ScrollBars.Vertical;
            PlaintextTextBox.AcceptsReturn = true;
            PlaintextTextBox.AcceptsTab = true;
            PlaintextTextBox.WordWrap = true;

            if (PlaintextTextBox.Text.Length != 0 && _plaintextPath.Length != 0)
            {
                File.WriteAllText(_plaintextPath, PlaintextTextBox.Text);
                DecryptProgressBar.Value = 100;
            }

            if (PlaintextTextBox.Text.Length != 0 && _plaintextPath.Length == 0)
            {
                GenerateFileNameButton_Click(this, EventArgs.Empty);
                File.WriteAllText(_plaintextPath, PlaintextTextBox.Text);
                DecryptProgressBar.Value = 100;
            }
        }

        private void CiphertextTextBox_TextChanged(object sender, EventArgs e)
        {
            CiphertextTextBox.Multiline = true;
            CiphertextTextBox.ScrollBars = ScrollBars.Vertical;
            CiphertextTextBox.AcceptsReturn = true;
            CiphertextTextBox.AcceptsTab = true;
            CiphertextTextBox.WordWrap = true;

            if (CiphertextTextBox.Text.Length != 0 && _ciphertextPath.Length != 0)
                File.WriteAllText(_ciphertextPath, CiphertextTextBox.Text);
        }

        private void LoadPublicKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\TEMP\\App.Pgp\\keys\\",
                Filter = "Public Keys (.asc)|*_PUBKEY.asc",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                _publicKeyPath = filePath;
                PublicKeyPathTextBox.Text = _publicKeyPath;
                _algorithm.UpdatePublicKey(_publicKeyPath);
                PublicKeyTextBox.Text = File.ReadAllText(filePath);
                PublicKeyProgressBar.Value = 100;
            } 
        }

        private void LoadPrivateKeyButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\TEMP\\App.Pgp\\keys\\",
                Filter = "Private Keys (.asc)|*_PRVKEY.asc",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                _privateKeyPath = filePath;
                PrivateKeyPathTextBox.Text = _privateKeyPath;
                _algorithm.UpdatePrivateKey(_privateKeyPath);
                PrivateKeyTextBox.Text = File.ReadAllText(filePath);
                PrivateKeyProgressBar.Value = 100;
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            bool publicKeyDoesNotExist = (string.IsNullOrEmpty(PublicKeyTextBox.Text) || 
                string.IsNullOrWhiteSpace(PublicKeyTextBox.Text));
            bool privateKeyDoesNotExist = (string.IsNullOrEmpty(PrivateKeyTextBox.Text) || 
                string.IsNullOrWhiteSpace(PrivateKeyTextBox.Text));
            bool plaintextDoesNotExist = (string.IsNullOrEmpty(PlaintextTextBox.Text) || 
                string.IsNullOrWhiteSpace(PlaintextTextBox.Text));
            bool passwordDoesNotExist = (string.IsNullOrEmpty(EncryptPasswordTextBox.Text) || 
                string.IsNullOrWhiteSpace(EncryptPasswordTextBox.Text));

            if (publicKeyDoesNotExist || privateKeyDoesNotExist || 
                plaintextDoesNotExist || passwordDoesNotExist)
            {
                if (publicKeyDoesNotExist)
                {
                    PublicKeyTextBox.BackColor = Color.Red;
                    PublicKeyProgressBar.Value = 0;
                }

                if (privateKeyDoesNotExist)
                {
                    PrivateKeyTextBox.BackColor = Color.Red;
                    PrivateKeyProgressBar.Value = 0;
                }

                if (plaintextDoesNotExist)
                    PlaintextTextBox.BackColor = Color.Red;

                if (passwordDoesNotExist)
                    EncryptPasswordTextBox.BackColor = Color.Red;
                
                DecryptProgressBar.Value = 0;
                EncryptProgressBar.Value = 0;

                MessageBox.Show(
                    "Cannot encrypt text! Please make sure that public/private keys, " +
                    "plaintext and signing password are present and valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                PublicKeyTextBox.BackColor = Color.White;
                PrivateKeyTextBox.BackColor = Color.White;
                PlaintextTextBox.BackColor = Color.White;
                EncryptPasswordTextBox.BackColor = Color.White;
            }
            else if (EncryptPasswordTextBox.Text != PasswordTextBox.Text)
            {
                EncryptPasswordTextBox.BackColor = Color.Red;
                PasswordTextBox.BackColor = Color.Red;

                ClearCiphertextButton_Click(this, EventArgs.Empty);

                MessageBox.Show(
                    "Cannot sign the document! " +
                    "Please make sure the signing password is the same as the key-generated password.",
                    "Wrong Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                EncryptPasswordTextBox.BackColor = Color.White;
                PasswordTextBox.BackColor = Color.White;
            }
            else
            {
                File.WriteAllText(_plaintextPath, PlaintextTextBox.Text);
                
                string result = _algorithm.Encrypt(EncryptPasswordTextBox.Text);

                if (result.Length != 0)
                {
                    MessageBox.Show(
                        "Encryption failed! Reason: " + result,
                        "_algorithm Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    _ciphertextPath = "C:\\TEMP\\App.Pgp\\results\\" +
                        FileNameTextBox.Text + "_SIGNED.pgp";
                    CiphertextPathTextBox.Text = _ciphertextPath;
                    _algorithm.UpdateCiphertext(_ciphertextPath);
                    CiphertextTextBox.Text = File.ReadAllText(_ciphertextPath);
                    EncryptProgressBar.Value = 100;
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            bool publicKeyDoesNotExist = (string.IsNullOrEmpty(PublicKeyTextBox.Text) || 
                string.IsNullOrWhiteSpace(PublicKeyTextBox.Text));
            bool privateKeyDoesNotExist = (string.IsNullOrEmpty(PrivateKeyTextBox.Text) || 
                string.IsNullOrWhiteSpace(PrivateKeyTextBox.Text));
            bool ciphertextDoesNotExist = (string.IsNullOrEmpty(CiphertextTextBox.Text) || 
                string.IsNullOrWhiteSpace(CiphertextTextBox.Text));
            bool passwordDoesNotExist = (string.IsNullOrEmpty(DecryptPasswordTextBox.Text) || 
                string.IsNullOrWhiteSpace(DecryptPasswordTextBox.Text));

            if (publicKeyDoesNotExist || privateKeyDoesNotExist || 
                ciphertextDoesNotExist || passwordDoesNotExist)
            {
                if (publicKeyDoesNotExist)
                {
                    PublicKeyTextBox.BackColor = Color.Red;
                    PublicKeyProgressBar.Value = 0;
                }

                if (privateKeyDoesNotExist)
                {
                    PrivateKeyTextBox.BackColor = Color.Red;
                    PrivateKeyProgressBar.Value = 0;
                }

                if (ciphertextDoesNotExist)
                    CiphertextTextBox.BackColor = Color.Red;

                if (passwordDoesNotExist)
                    DecryptPasswordTextBox.BackColor = Color.Red;

                DecryptProgressBar.Value = 0;
                EncryptProgressBar.Value = 0;

                MessageBox.Show(
                    "Cannot decrypt text! Please make sure that public/private keys, " +
                    "ciphertext and the unlocking password are present and valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                PublicKeyTextBox.BackColor = Color.White;
                PrivateKeyTextBox.BackColor = Color.White;
                CiphertextTextBox.BackColor = Color.White;
                DecryptPasswordTextBox.BackColor = Color.White;
            }
            else if (EncryptPasswordTextBox.Text != DecryptPasswordTextBox.Text)
            {
                DecryptPasswordTextBox.BackColor = Color.Red;
                EncryptPasswordTextBox.BackColor = Color.Red;

                ClearPlaintextButton_Click(this, EventArgs.Empty);

                MessageBox.Show(
                    "Cannot unlock the document! Please make sure the unlocking " +
                    "password is the same as the signing password.",
                    "Wrong Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                EncryptPasswordTextBox.BackColor = Color.White;
                DecryptPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                string result = _algorithm.Decrypt(DecryptPasswordTextBox.Text);
                if (result.Length != 0)
                {
                    MessageBox.Show(
                        "Decryption failed! Reason: " + result,
                        "_algorithm Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    _plaintextPath = "C:\\TEMP\\App.Pgp\\results\\" +
                        FileNameTextBox.Text + "_UNSIGNED.txt";
                    PlaintextPathTextBox.Text = _plaintextPath;
                    _algorithm.UpdatePlaintext(_plaintextPath);
                    PlaintextTextBox.Text = File.ReadAllText(_plaintextPath);
                    DecryptProgressBar.Value = 100;
                }
            }
        }

        private void PasswordHiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordHiddenCheckBox.Checked)
            {
                if (PasswordTextBox.Text.Length != 0)
                {
                    string content = PasswordTextBox.Text;
                    PasswordTextBox.PasswordChar = '*';
                    PasswordTextBox.Refresh();
                    PasswordTextBox.Text = content;
                }
                else
                {
                    PasswordTextBox.PasswordChar = '*';
                }
            }
            else
            {
                if (PasswordTextBox.Text.Length != 0)
                {
                    string content = PasswordTextBox.Text;
                    PasswordTextBox.PasswordChar = '\0';
                    PasswordTextBox.Refresh();
                    PasswordTextBox.Text = content;
                }
                else
                {
                    PasswordTextBox.PasswordChar = '\0';
                }
            }
        }

        private void EncryptPasswordHiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EncryptPasswordHiddenCheckBox.Checked)
            {
                if (EncryptPasswordTextBox.Text.Length != 0)
                {
                    string content = EncryptPasswordTextBox.Text;
                    EncryptPasswordTextBox.PasswordChar = '*';
                    EncryptPasswordTextBox.Refresh();
                    EncryptPasswordTextBox.Text = content;
                }
                else
                {
                    EncryptPasswordTextBox.PasswordChar = '*';
                }
            }
            else
            {
                if (EncryptPasswordTextBox.Text.Length != 0)
                {
                    string content = EncryptPasswordTextBox.Text;
                    EncryptPasswordTextBox.PasswordChar = '\0';
                    EncryptPasswordTextBox.Refresh();
                    EncryptPasswordTextBox.Text = content;
                }
                else
                {
                    EncryptPasswordTextBox.PasswordChar = '\0';
                }
            }
        }

        private void DecryptPasswordHiddenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DecryptPasswordHiddenCheckBox.Checked)
            {
                if (DecryptPasswordTextBox.Text.Length != 0)
                {
                    string content = DecryptPasswordTextBox.Text;
                    DecryptPasswordTextBox.PasswordChar = '*';
                    DecryptPasswordTextBox.Refresh();
                    DecryptPasswordTextBox.Text = content;
                }
                else
                {
                    DecryptPasswordTextBox.PasswordChar = '*';
                }
            }
            else
            {
                if (DecryptPasswordTextBox.Text.Length != 0)
                {
                    string content = DecryptPasswordTextBox.Text;
                    DecryptPasswordTextBox.PasswordChar = '\0';
                    DecryptPasswordTextBox.Refresh();
                    DecryptPasswordTextBox.Text = content;
                }
                else
                {
                    DecryptPasswordTextBox.PasswordChar = '\0';
                }
            }
        }

        private string GenerateUniqueSequence(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GenerateFileNameButton_Click(object sender, EventArgs e)
        {
            ClearPlaintextButton_Click(this, EventArgs.Empty);
            ClearCiphertextButton_Click(this, EventArgs.Empty);

            if (FileNameTextBox.Text.Length != 0)
                ClearFileNameButton_Click(this, EventArgs.Empty);

            FileNameTextBox.Text = GenerateUniqueSequence(10);
            _algorithm.LoadInput(FileNameTextBox.Text);

            _plaintextPath = "C:\\TEMP\\App.Pgp\\inputs\\" + 
                FileNameTextBox.Text + ".txt";
            PlaintextPathTextBox.Text = _plaintextPath;
        }

        private void GenerateEmailButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text.Length != 0)
                ClearEmailButton_Click(this, EventArgs.Empty);

            EmailTextBox.Text = GenerateUniqueSequence(10) + "@APANDI.COM";
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length != 0)
                ClearPasswordButton_Click(this, EventArgs.Empty);

            PasswordTextBox.Text = "AGP=" + GenerateUniqueSequence(20);
        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length != 0)
            {
                Clipboard.SetText(PasswordTextBox.Text);
                MessageBox.Show(
                    "Password was copied to clipboard.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Could not copy password to clipboard! Please make sure password is generated before copying it.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void PasteEncryptionPasswordButton_Click(object sender, EventArgs e)
        {
            if (EncryptPasswordTextBox.Text.Length != 0)
                ClearEncryptPasswordButton_Click(this, EventArgs.Empty);

            string clipboardText = Clipboard.GetText();
            
            if (clipboardText.Contains("AGP="))
            {
                EncryptPasswordTextBox.Text = clipboardText;
                MessageBox.Show(
                    "Password retrieved from clipboard.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Could not retrieve password from clipboard! Please make sure to copy the right password.",
                    "Wrong Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void PasteDecryptionPasswordButton_Click(object sender, EventArgs e)
        {
            if (DecryptPasswordTextBox.Text.Length != 0)
                ClearDecryptPasswordButton_Click(this, EventArgs.Empty);

            string clipboardText = Clipboard.GetText();

            if (clipboardText.Contains("AGP="))
            {
                DecryptPasswordTextBox.Text = clipboardText;
                MessageBox.Show(
                    "Password retrieved from clipboard.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Could not retrieve password from clipboard! Please make sure to copy the right password.",
                    "Wrong Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void UploadPlaintextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\TEMP\\App.Pgp\\inputs\\",
                Filter = "Text Files (.txt)|*.txt",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                _plaintextPath = filePath;
                PlaintextPathTextBox.Text = _plaintextPath;
                _algorithm.UpdatePlaintext(_plaintextPath);
                PlaintextTextBox.Text = File.ReadAllText(filePath);
                ClearCiphertextButton_Click(this, EventArgs.Empty);
                EncryptProgressBar.Value = 0;
                DecryptProgressBar.Value = 100;
            }
        }

        private void UploadCiphertextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\TEMP\\App.Pgp\\results\\",
                Filter = "Signed Files (.pgp)|*_SIGNED.pgp",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                _ciphertextPath = filePath;
                CiphertextPathTextBox.Text = _ciphertextPath;
                _algorithm.UpdateCiphertext(_ciphertextPath);
                CiphertextTextBox.Text = File.ReadAllText(filePath);
                ClearPlaintextButton_Click(this, EventArgs.Empty);
                DecryptProgressBar.Value = 0;
                EncryptProgressBar.Value = 100;
            }
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App.Rc4
{
    public partial class Plugin : Form
    {
        private readonly Algorithms.IRc4 _algorithm = new Algorithms.Rc4();

        public Plugin()
        {
            InitializeComponent();
        }

        private void ClearCiphertextButton_Click(object sender, EventArgs e)
        {
            CiphertextTextBox.ResetText();
            CiphertextProgressBar.Value = 0;
        }

        private void ClearKeyButton_Click(object sender, EventArgs e)
        {
            KeyTextBox.ResetText();
            KeyProgressBar.Value = 0;
        }

        private void ClearPlaintextButton_Click(object sender, EventArgs e)
        {
            PlaintextTextBox.ResetText();
            PlaintextProgressBar.Value = 0;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearPlaintextButton_Click(this, EventArgs.Empty);
            ClearCiphertextButton_Click(this, EventArgs.Empty);
            ClearKeyButton_Click(this, EventArgs.Empty);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GenerateUniqueSequence(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "~!@#$%^&*()_+{}|//\\:?><,.;'[]*-+" +
                " ";

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e)
        {
            KeyTextBox.Text = GenerateUniqueSequence(256);
            KeyProgressBar.Value = 100;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            bool plaintextDoesNotExist = string.IsNullOrEmpty(PlaintextTextBox.Text) ||
                string.IsNullOrWhiteSpace(PlaintextTextBox.Text);
            bool keyDoesNotExist = string.IsNullOrEmpty(KeyTextBox.Text) ||
                string.IsNullOrWhiteSpace(KeyTextBox.Text);

            if (plaintextDoesNotExist || keyDoesNotExist)
            {
                if (plaintextDoesNotExist)
                {
                    PlaintextTextBox.BackColor = Color.Red;
                    PlaintextProgressBar.Value = 0;
                }

                if (keyDoesNotExist)
                {
                    KeyTextBox.BackColor = Color.Red;
                    KeyProgressBar.Value = 0;
                }

                MessageBox.Show(
                    "Cannot encrypt message! Please make sure the plaintext " +
                    "and key are present and valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                PlaintextTextBox.BackColor = Color.White;
                KeyTextBox.BackColor = Color.White;
            }
            else
            {
                string result = _algorithm.Encrypt(PlaintextTextBox.Text);

                if (result.Contains("CryptographicException"))
                {
                    PlaintextTextBox.BackColor = Color.Red;
                    KeyTextBox.BackColor = Color.Red;

                    MessageBox.Show(
                        "Cannot encrypt message! Reason: " + result,
                        "Wrong Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    PlaintextTextBox.BackColor = Color.White;
                    KeyTextBox.BackColor = Color.White;

                    ClearPlaintextButton_Click(this, EventArgs.Empty);
                    ClearKeyButton_Click(this, EventArgs.Empty);
                }
                else
                {
                    CiphertextTextBox.Text = result;
                    CiphertextProgressBar.Value = 100;
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            bool keyDoesNotExist = string.IsNullOrEmpty(KeyTextBox.Text) ||
                string.IsNullOrWhiteSpace(KeyTextBox.Text);
            bool ciphertextDoesNotExist = string.IsNullOrEmpty(CiphertextTextBox.Text) ||
                string.IsNullOrWhiteSpace(CiphertextTextBox.Text);

            if (ciphertextDoesNotExist || keyDoesNotExist)
            {
                if (ciphertextDoesNotExist)
                {
                    CiphertextTextBox.BackColor = Color.Red;
                    CiphertextProgressBar.Value = 0;
                }

                if (keyDoesNotExist)
                {
                    KeyTextBox.BackColor = Color.Red;
                    KeyProgressBar.Value = 0;
                }

                MessageBox.Show(
                    "Cannot decrypt message! Please make sure the ciphertext " +
                    "and key are present and valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                CiphertextTextBox.BackColor = Color.White;
                KeyTextBox.BackColor = Color.White;
            }
            else
            {
                string result = _algorithm.Decrypt(CiphertextTextBox.Text);

                if (result.Contains("CryptographicException"))
                {
                    CiphertextTextBox.BackColor = Color.Red;
                    KeyTextBox.BackColor = Color.Red;

                    MessageBox.Show(
                        "Cannot decrypt message! Reason: " + result,
                        "Wrong Input",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                    CiphertextTextBox.BackColor = Color.White;
                    KeyTextBox.BackColor = Color.White;

                    ClearCiphertextButton_Click(this, EventArgs.Empty);
                    ClearKeyButton_Click(this, EventArgs.Empty);
                }
                else
                {
                    PlaintextTextBox.Text = result;
                    PlaintextProgressBar.Value = 100;
                } 
            }
        }

        private void PlaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            PlaintextTextBox.Multiline = true;
            PlaintextTextBox.ScrollBars = ScrollBars.Vertical;
            PlaintextTextBox.AcceptsReturn = true;
            PlaintextTextBox.AcceptsTab = true;
            PlaintextTextBox.WordWrap = true;

            if (PlaintextTextBox.Text.Length != 0)
                PlaintextProgressBar.Value = 100;
            else
                PlaintextProgressBar.Value = 0;
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            KeyTextBox.Multiline = true;
            KeyTextBox.ScrollBars = ScrollBars.Vertical;
            KeyTextBox.AcceptsReturn = true;
            KeyTextBox.AcceptsTab = true;
            KeyTextBox.WordWrap = true;

            if (KeyTextBox.Text.Length != 0)
            {
                _algorithm.ImportKey(KeyTextBox.Text);
                KeyProgressBar.Value = 100;
            } 
            else
                KeyProgressBar.Value = 0;
        }

        private void CiphertextTextBox_TextChanged(object sender, EventArgs e)
        {
            CiphertextTextBox.Multiline = true;
            CiphertextTextBox.ScrollBars = ScrollBars.Vertical;
            CiphertextTextBox.AcceptsReturn = true;
            CiphertextTextBox.AcceptsTab = true;
            CiphertextTextBox.WordWrap = true;

            if (CiphertextTextBox.Text.Length != 0)
                CiphertextProgressBar.Value = 100;
            else
                CiphertextProgressBar.Value = 0;
        }
    }
}

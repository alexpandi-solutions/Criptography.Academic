using Effortless.Net.Encryption;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.Dh
{
    public partial class Plugin : Form
    {

        private readonly DiffieHellman _sender = new DiffieHellman();
        private readonly DiffieHellman _receiver = new DiffieHellman();
        private byte[] _senderEncryptedMessage;
        private byte[] _receiverEncryptedMessage;
        private string _senderDecryptedMessage;
        private string _receiverDecryptedMessage;

        public Plugin()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearSenderPlaintextButton_Click(object sender, EventArgs e)
        {
            SenderPlaintextTextBox.ResetText();
            SenderPlaintextProgressBar.Value = 0;
        }

        private void ClearSenderCiphertextButton_Click(object sender, EventArgs e)
        {
            SenderCiphertextTextBox.ResetText();
            SenderCiphertextProgressBar.Value = 0;
        }

        private void ClearReceiverPlaintextButton_Click(object sender, EventArgs e)
        {
            ReceiverPlaintextTextBox.ResetText();
            ReceiverPlaintextProgressBar.Value = 0;
        }

        private void ClearReceiverCiphertextButton_Click(object sender, EventArgs e)
        {
            ReceiverCiphertextTextBox.ResetText();
            ReceiverCiphertextProgressBar.Value = 0;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearSenderPlaintextButton_Click(this, EventArgs.Empty);
            ClearSenderCiphertextButton_Click(this, EventArgs.Empty);
            ClearReceiverPlaintextButton_Click(this, EventArgs.Empty);
            ClearReceiverCiphertextButton_Click(this, EventArgs.Empty);
        }

        private void SenderPlaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            SenderPlaintextTextBox.Multiline = true;
            SenderPlaintextTextBox.ScrollBars = ScrollBars.Vertical;
            SenderPlaintextTextBox.AcceptsReturn = true;
            SenderPlaintextTextBox.AcceptsTab = true;
            SenderPlaintextTextBox.WordWrap = true;

            if (SenderPlaintextTextBox.Text.Length != 0)
                SenderPlaintextProgressBar.Value = 100;
            else
                SenderPlaintextProgressBar.Value = 0;
        }

        private void SenderCiphertextTextBox_TextChanged(object sender, EventArgs e)
        {
            SenderCiphertextTextBox.Multiline = true;
            SenderCiphertextTextBox.ScrollBars = ScrollBars.Vertical;
            SenderCiphertextTextBox.AcceptsReturn = true;
            SenderCiphertextTextBox.AcceptsTab = true;
            SenderCiphertextTextBox.WordWrap = true;

            if (SenderCiphertextTextBox.Text.Length != 0)
                SenderCiphertextProgressBar.Value = 100;
            else
                SenderCiphertextProgressBar.Value = 0;
        }

        private void ReceiverPlaintextTextBox_TextChanged(object sender, EventArgs e)
        {
            ReceiverPlaintextTextBox.Multiline = true;
            ReceiverPlaintextTextBox.ScrollBars = ScrollBars.Vertical;
            ReceiverPlaintextTextBox.AcceptsReturn = true;
            ReceiverPlaintextTextBox.AcceptsTab = true;
            ReceiverPlaintextTextBox.WordWrap = true;

            if (ReceiverPlaintextTextBox.Text.Length != 0)
                ReceiverPlaintextProgressBar.Value = 100;
            else
                ReceiverPlaintextProgressBar.Value = 0;
        }

        private void ReceiverCiphertextTextBox_TextChanged(object sender, EventArgs e)
        {
            ReceiverCiphertextTextBox.Multiline = true;
            ReceiverCiphertextTextBox.ScrollBars = ScrollBars.Vertical;
            ReceiverCiphertextTextBox.AcceptsReturn = true;
            ReceiverCiphertextTextBox.AcceptsTab = true;
            ReceiverCiphertextTextBox.WordWrap = true;

            if (ReceiverCiphertextTextBox.Text.Length != 0)
                ReceiverCiphertextProgressBar.Value = 100;
            else
                ReceiverCiphertextProgressBar.Value = 0;
        }

        private void SenderSendButton_Click(object sender, EventArgs e)
        {
            if (SenderPlaintextTextBox.Text.Length == 0)
            {
                SenderPlaintextTextBox.BackColor = Color.Red;

                MessageBox.Show(
                    "Cannot send message! Please make sure the sender message is valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                SenderPlaintextTextBox.BackColor = Color.White;
            }
            else
            {
                _senderEncryptedMessage = _sender.Encrypt(_receiver, SenderPlaintextTextBox.Text);
                
                var encryptedString = new StringBuilder();
                foreach (var data in _senderEncryptedMessage)
                    encryptedString.Append(data + ", ");

                ReceiverCiphertextTextBox.Text = encryptedString.ToString();
            }
        }

        private void ReceiverDecryptButton_Click(object sender, EventArgs e)
        {
            _receiverDecryptedMessage = _receiver.Decrypt(_sender, _senderEncryptedMessage);
            ReceiverPlaintextTextBox.Text = _receiverDecryptedMessage;
        }

        private void ReceiverSendButton_Click(object sender, EventArgs e)
        {
            if (ReceiverPlaintextTextBox.Text.Length == 0)
            {
                ReceiverPlaintextTextBox.BackColor = Color.Red;

                MessageBox.Show(
                    "Cannot send message! Please make sure the receiver message is valid.",
                    "Missing Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                ReceiverPlaintextTextBox.BackColor = Color.White;
            }
            else
            {
                _receiverEncryptedMessage = _receiver.Encrypt(_sender, ReceiverPlaintextTextBox.Text);
                
                var encryptedString = new StringBuilder();
                foreach (var data in _receiverEncryptedMessage)
                    encryptedString.Append(data + ", ");
                
                SenderCiphertextTextBox.Text = encryptedString.ToString();
            }
        }

        private void SenderDecryptButton_Click(object sender, EventArgs e)
        {
            _senderDecryptedMessage = _sender.Decrypt(_receiver, _receiverEncryptedMessage);
            SenderPlaintextTextBox.Text = _senderDecryptedMessage;
        }
    }
}

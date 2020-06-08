using System;
using System.Windows.Forms;

namespace App.Start
{
    public partial class Plugin : Form
    {
        public Plugin()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (AlgorithmOption.SelectedIndex == 0)
            {
                Hide();

                Aes.Plugin app = new Aes.Plugin();
                app.ShowDialog();

                if (!app.IsAccessible)
                {
                    AlgorithmOption.ResetText();
                    Show();
                }
            }
            else if (AlgorithmOption.SelectedIndex == 1)
            {
                Hide();

                Rc4.Plugin app = new Rc4.Plugin();
                app.ShowDialog();

                if (!app.IsAccessible)
                {
                    AlgorithmOption.ResetText();
                    Show();
                }
            }
            else if (AlgorithmOption.SelectedIndex == 2)
            {
                Hide();

                Pgp.Plugin app = new Pgp.Plugin();
                app.ShowDialog();

                if (!app.IsAccessible)
                {
                    AlgorithmOption.ResetText();
                    Show();
                }
            }
            else if (AlgorithmOption.SelectedIndex == 3)
            {
                Hide();

                Dh.Plugin app = new Dh.Plugin();
                app.ShowDialog();

                if (!app.IsAccessible)
                {
                    AlgorithmOption.ResetText();
                    Show();
                }
            }
        }
    }
}

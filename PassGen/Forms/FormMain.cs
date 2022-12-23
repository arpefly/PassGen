using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PassGen.Extentions;

namespace PassGen.Forms
{
    public partial class FormMain : FormShadow
    {
        public FormMain()
        {
            InitializeComponent();
            this.FormPaint(Color.FromArgb(27, 34, 42), Color.FromArgb(27, 34, 42));
            labelHeader.MouseDown += (s, e) => { labelHeader.Capture = false; Capture = false; Message message = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero); base.WndProc(ref message); };
            length = Convert.ToUInt32(textBoxPasswordLength.Text);

            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                    Application.Exit();
                else if (e.KeyCode == Keys.P)
                    TopMost = !TopMost;
                else if (e.KeyCode == Keys.Tab)
                {
                    if (!checkBoxUseNumbers.Checked && !checkBoxUseUpperCase.Checked && !checkBoxUseLowerCase.Checked && !checkBoxUseSpecialSymbols.Checked)
                        return;

                    GeneratePassword(out string password);
                    textBoxPassword.Text = password;
                    Clipboard.Clear();
                    Clipboard.SetText(password);
                }
            };

            pictureBoxApplicationExit.Click += async (s, e) => await this.SmoothFormClosing();
            pictureBoxApplicationExit.MouseEnter += (s, e) => pictureBoxApplicationExit.BackColor = Color.FromArgb(27, 34, 42);
            pictureBoxApplicationExit.MouseLeave += (s, e) => pictureBoxApplicationExit.BackColor = Color.FromArgb(44, 57, 67);
            pictureBoxApplicationExit.Paint += (s, e) =>
            {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 173, 180)), 7, 7, 17, 17);
                e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 173, 180)), 7, 17, 17, 7);
            };

            pictureBoxMinimize.Click += async (s, e) => await this.SmoothFormClosing(false);
            pictureBoxMinimize.MouseEnter += (s, e) => pictureBoxMinimize.BackColor = Color.FromArgb(27, 34, 42);
            pictureBoxMinimize.MouseLeave += (s, e) => pictureBoxMinimize.BackColor = Color.FromArgb(44, 57, 67);
            pictureBoxMinimize.Paint += (s, e) => e.Graphics.DrawLine(new Pen(Color.FromArgb(160, 173, 180)), 7, 17, 17, 17);

            textBoxPasswordLength.MouseWheel += (s, e) =>
            {
                if (e.Delta > 0)
                    textBoxPasswordLength.Text = (++length).ToString();
                else
                    textBoxPasswordLength.Text = (--length).ToString();
            };
        }

        readonly Random R = new Random();

        uint length;
        readonly string numbers = "0123456789";
        readonly string upper = "QWERTYUIOPASDFGHJKLZXCVBNM";
        readonly string lower = "qwertyuiopasdfghjklzxcvbnm";
        readonly string special = "!#$%^&*()_+{}[]\"',./<>?|\\№;:?=-";
        string dictionary;


        private void GeneratePassword(out string password)
        {
            password = "";
            dictionary = "";

            if (checkBoxUseNumbers.Checked)
                dictionary += numbers;
            if (checkBoxUseUpperCase.Checked)
                dictionary += upper;
            if (checkBoxUseLowerCase.Checked)
                dictionary += lower;
            if (checkBoxUseSpecialSymbols.Checked)
                dictionary += special;

            for (int i = 0; i < length; i++)
            {
                password += dictionary[R.Next(0, dictionary.Length)];
            }
        }

        private void TextBoxPasswordLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        private void TextBoxPasswordLength_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordLength.Text != "")
                length = Convert.ToUInt32(textBoxPasswordLength.Text);
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            if (string.Join("", Environment.GetCommandLineArgs()).EndsWith("/genpass"))
            {
                SendKeys.Send("{TAB}");
                SendKeys.Flush();

                Application.Exit();
            }

            await this.SmoothFormAppearance();
        }
    }
}
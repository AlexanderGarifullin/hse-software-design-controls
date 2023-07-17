using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLab
{
    public partial class ColorTextBoх : TextBox
    {
        public bool IsDec = true;

        public ColorTextBoх()
        {
            InitializeComponent();
        }

        public ColorTextBoх(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (IsDec)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar > 64 || e.KeyChar < 71) && !(e.KeyChar > 96 || e.KeyChar < 103))
                    e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text == "") Text = "0";
            if (Text != "")
            {
                if (IsDec)
                {
                    Text = Regex.Replace(Text.ToString(), @"[^\d]", "", RegexOptions.IgnoreCase);
                    if (int.Parse(Text) > 255) Text = 255.ToString();
                    else Text = int.Parse(Text).ToString();
                }
                else
                {
                    Text = Regex.Replace(Text.ToString(), @"[^\da-f^A-F]", "", RegexOptions.IgnoreCase);
                    Text = Text.ToUpper();
                    if (Text.Length > 2) Text = "FF";
                    Text = Convert.ToString(Convert.ToInt32(Text, 16), 16).ToUpper();
                }
            }
            if (Focus()) SelectionStart = Text.Length;
            base.OnTextChanged(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;

namespace WinFormsControlLab
{
    public partial class ColorChange : UserControl
    {
        public ColorChange()
        {
            InitializeComponent();
        }




        public Color Color
        {
            get
            {
                return pictureBox1.BackColor;    // возвращаем значение свойства
            }
            set
            {
                pictureBox1.BackColor = value;   // устанавливаем новое значение свойства
                if (decRadioButton1.Checked)
                {
                    colorTextBoх1.Text = pictureBox1.BackColor.R.ToString();
                    colorTextBoх2.Text = pictureBox1.BackColor.G.ToString(); 
                    colorTextBoх3.Text = pictureBox1.BackColor.B.ToString(); 
                }
                else
                {
                    var text1 = ((int)pictureBox1.BackColor.R).ToString();
                    colorTextBoх1.Text = Convert.ToInt32(text1, 16).ToString();

                    var text2 = ((int)pictureBox1.BackColor.G).ToString();
                    colorTextBoх2.Text = Convert.ToInt32(text2, 16).ToString();

                    var text3 = ((int)pictureBox1.BackColor.B).ToString();
                    colorTextBoх3.Text = text3;
        
                }
            }
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // change
            decRadioButton1.Enabled = !decRadioButton1.Checked;
            hexRadioButton.Enabled = !hexRadioButton.Checked;
            colorTextBoх1.IsDec = decRadioButton1.Checked;
            colorTextBoх2.IsDec = decRadioButton1.Checked;
            colorTextBoх3.IsDec = decRadioButton1.Checked;
            // 10
            if (decRadioButton1.Checked)
            {
                colorTextBoх1.Text = Convert.ToInt32(colorTextBoх1.Text, 16).ToString();
                colorTextBoх2.Text =  Convert.ToInt32(colorTextBoх2.Text, 16).ToString();
                colorTextBoх3.Text =  Convert.ToInt32(colorTextBoх3.Text, 16).ToString();
            }
            // 16
            else
            {
                colorTextBoх1.Text = Convert.ToString(int.Parse(colorTextBoх1.Text), 16);
                colorTextBoх2.Text = Convert.ToString(int.Parse(colorTextBoх2.Text), 16);
                colorTextBoх3.Text = Convert.ToString(int.Parse(colorTextBoх3.Text), 16);
            }
        }

        private void colorTextBoх_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decRadioButton1.Checked)
                {
                    pictureBox1.BackColor = Color.FromArgb(
                        int.Parse(colorTextBoх1.Text),
                        int.Parse(colorTextBoх2.Text),
                        int.Parse(colorTextBoх3.Text)
                    );
                }
                else
                {
                    pictureBox1.BackColor = Color.FromArgb(
                        Convert.ToInt32(colorTextBoх1.Text, 16),
                        Convert.ToInt32(colorTextBoх2.Text, 16),
                        Convert.ToInt32(colorTextBoх3.Text, 16)
                    );
                }
            }
            catch (Exception) { }
        }
    }
}

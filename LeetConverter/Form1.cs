using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeetConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Convert();
        }

        private void txtNormalText_TextChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void Convert()
        {
            StringBuilder newString = new StringBuilder();

            foreach (char c in txtNormalText.Text.ToUpper())
            {
                switch (c)
                {
                    case 'A': newString.Append("4"); break;
                    case 'B': newString.Append("8"); break;
                    case 'C': newString.Append("["); break;
                    case 'D': newString.Append(")"); break;
                    case 'E': newString.Append("3"); break;
                    case 'F': newString.Append("|="); break;
                    case 'G': newString.Append("6"); break;
                    case 'H': newString.Append("#"); break;
                    case 'I': newString.Append("!"); break;
                    case 'J': newString.Append("_|"); break;
                    case 'K': newString.Append("X"); break;
                    case 'L': newString.Append("1"); break;
                    case 'M': newString.Append("|v|"); break;
                    case 'N': newString.Append("/V"); break;
                    case 'O': newString.Append("0"); break;
                    case 'P': newString.Append("9"); break;
                    case 'Q': newString.Append("(_,)"); break;
                    case 'R': newString.Append("2"); break;
                    case 'S': newString.Append("5"); break;
                    case 'T': newString.Append("7"); break;
                    case 'U': newString.Append("|_|"); break;
                    case 'V': newString.Append("\\/"); break;
                    case 'W': newString.Append("\\/\\/"); break;
                    case 'X': newString.Append("><"); break;
                    case 'Y': newString.Append("Ψ"); break;
                    case 'Z': newString.Append("%"); break;
                    default: newString.Append(c); break;
                }
            }

            txtLeetText.Text = newString.ToString();
        }
    }
}

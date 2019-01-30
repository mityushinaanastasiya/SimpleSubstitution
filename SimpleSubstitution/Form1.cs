using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSubstitution
{
    public partial class Form1 : Form
    {
        EncoderCoder encoderCoder;
        public Form1()
        {
            InitializeComponent();
            encoderCoder = new EncoderCoder();
            
            
        }

        private void codeButtonClick(object sender, EventArgs e)
        {
            encoderCoder.encrypt();
            label1.Text = "Успешно";
        }

        private void deshifrButtonClick(object sender, EventArgs e)
        {
            encoderCoder.toDecipher();
            label2.Text = "Успешно";
        }
    }
}

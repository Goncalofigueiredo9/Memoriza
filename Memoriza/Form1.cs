using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoriza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RTFFile MeuTexto = new RTFFile();
        private void Form1_Load(object sender, EventArgs e)       
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = MeuTexto.Texto;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MeuTexto.Gravar(richTextBox1.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MeuTexto.Gravar(richTextBox1.Text);
            richTextBox1.Text = MeuTexto.Eliminar();
        }
    }
}

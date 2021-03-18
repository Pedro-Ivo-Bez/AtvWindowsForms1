using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Windows_Forms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "fernando")
            {
                if (textBox2.Text == "fernando123")
                {
                  
                    MessageBox.Show("ACESSO CONCEDIDO");
                }
                else
                {
                    MessageBox.Show("ERRO! LOGIN OU SENHA INCORRETOS");
                }
            }
            else
            {
                MessageBox.Show("ERRO! LOGIN OU SENHA INCORRETOS");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

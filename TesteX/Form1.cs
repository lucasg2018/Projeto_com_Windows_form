using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Atualizar();
        }

        private void Atualizar()
        {
            hora.Text = DateTime.Now.ToString("HH:mm");
            data.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textboxNome.Text;
            try
            {
                int idade = int.Parse(textIdade.Text);
                if (nome.Length > 0 && idade > 0)
                {
                    MessageBox.Show("Nome: " + nome + "\nIdade: " + idade + "\nData de nascimento: "
                        + textNascimento.Text + "\nNúmero: " + textNumero.Text);
                }
            }
            catch
            {
                notifyIcon2.ShowBalloonTip(10, "Aviso",
                    "Informe os dados abaixo corretamente:" +
                    "\nNome, Idade, Data de Nascimento, Número ",
                    ToolTipIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textboxNome.Clear();
            textIdade.Clear();
            textNascimento.Clear();
            textNumero.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procurando por termo: " + textBusca.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmImportador frmImp = new FrmImportador();
            frmImp.MdiParent = MDISingleton.Criar();
            frmImp.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TesteX
{
    public partial class FrmImportador : Form
    {
        private string[] Linhas;
        public FrmImportador()
        {
            InitializeComponent();
        }

        private void FrmImportador_Load(object sender, EventArgs e)
        {
            string arquivo = @"C:\Users\Lucas Gabriel\Documents\C#\---Projetos---\TesteX\Texto.txt";
            Linhas = File.ReadAllLines(arquivo);
            progressBarImportar.Maximum = Linhas.Length;
            progressBarImportar.Minimum = 0;
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Linhas.Length; i++)
            {
                progressBarImportar.Value = (i + 1);
            }
            notifyIconAviso.ShowBalloonTip(10, "Aviso", "Importação concluida!", ToolTipIcon.Warning);
        }
    }
}

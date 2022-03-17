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

namespace fEditorDeTexto
{
    public partial class fMain : Form
    {

        
        public fMain()
        {
            InitializeComponent();
        }

        private void novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter cfbStreamWriter = new StreamWriter(arquivo);
                    cfbStreamWriter.Flush();
                    cfbStreamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    cfbStreamWriter.Write(this.richTextBox1.Text);
                    cfbStreamWriter.Flush();
                    cfbStreamWriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message,"Erro ao gravar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\fabio\Documents\estudos";
            openFileDialog1.Filter = "(*.txt)|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader cfbStreamReader = new StreamReader(arquivo);
                    cfbStreamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = cfbStreamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = cfbStreamReader.ReadLine();
                    }
                    cfbStreamReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na leitura: " + ex.Message, "Erro ao ler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void colar()
        {
            richTextBox1.Paste();
        }

        private void negrito()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool negrit = false;
            negrit = richTextBox1.Font.Bold;
            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;
            
            if(negrit == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }
        private void italico()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool ital = true;
            ital = richTextBox1.Font.Italic;
            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;

            if (ital == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }
        private void sublinhado()
        {
            string nomeDaFonte = null;
            float tamanhoDaFonte = 0;
            bool sub = false;
            sub = richTextBox1.Font.Underline;
            nomeDaFonte = richTextBox1.Font.Name;
            tamanhoDaFonte = richTextBox1.Font.Size;

            if (sub == false)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Underline);
            }
            else if(sub)
            {
                richTextBox1.SelectionFont = new Font(nomeDaFonte, tamanhoDaFonte, FontStyle.Regular);
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void btnColar_Click(object sender, EventArgs e)
        {
            colar();
        }

        private void btnItalico_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italico();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void btnNegrito_Click(object sender, EventArgs e)
        {
            negrito();
        }

        private void btnSublinhado_Click(object sender, EventArgs e)
        {
            sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sublinhado();
        }
    }
}

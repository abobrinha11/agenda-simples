using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_simples
{
    public partial class Form1 : Form
    {
        private contato[] listaDeContatos = new contato[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
             

            //criação de objeto.criação da instancia do objeto objcontato
            contato objcontato = new contato(txtNome.Text, txtSobrenome.Text, Txtemail.Text, txtTelefone.Text);
            lstContato.Items.Add(objcontato).ToString();
        }

        //escrever os contatos em arquivos de texto
        private void Escrever(contato contato)
        {
            //cria o objeto "StreamWriter",  que escreve informações em arquivos de texto.
            StreamWriter escrevedorDeArquivos = new StreamWriter("Contato.txt");
            escrevedorDeArquivos.WriteLine(listaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Email);

            //se tiver contatos anteriores 
            //salvar e depois escreve-lo de volta, atualizados.

            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
                escrevedorDeArquivos.WriteLine(contato.Sobrenome);
                escrevedorDeArquivos.WriteLine(contato.Telefone);
                escrevedorDeArquivos.WriteLine(contato.Email);

            }
        }

        private void lstContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
             
            contato objetocontato = new contato(txtNome.Text, 
                txtSobrenome.Text, txtTelefone.Text, Txtemail.Text);
            Escrever(objetocontato);
            Ordenar();
            Ler();
            AtualizarDisplay();
            LimparFormulario();
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
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].PrimeiroNome);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Sobrenome);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Telefone);
                escrevedorDeArquivos.WriteLine(listaDeContatos[i].Email);

            }
            escrevedorDeArquivos.Close();
        }

        private void lstContato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ler()
        {
            StreamReader leitorDeArquivos = new StreamReader("Contatos.txt");
            listaDeContatos = new contato[Convert.ToInt32(leitorDeArquivos.ReadLine())];
            // Copia os dados do arquivo de texto para o vetor listaDeContatos
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                listaDeContatos[i] = new contato();
                listaDeContatos[i].PrimeiroNome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Sobrenome = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Telefone = leitorDeArquivos.ReadLine();
                listaDeContatos[i].Email = leitorDeArquivos.ReadLine();
            }
            leitorDeArquivos.Close();
        }
        private void AtualizarDisplay()
        {
            //apagar a lista "anteiror" e gerar, ou criar uma, com
            // o conteudo da lista anterior + o conteudo novo
            lstContato.Items.Clear();
            for (int i = 0; i < listaDeContatos.Length; i++)
            {
                lstContato.Items.Add(listaDeContatos[i].ToString());
            }
        }
        private void LimparFormulario()
        {
            txtNome.Text = String.Empty;
            txtSobrenome.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            Txtemail.Text= String.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ler();
            AtualizarDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordenar();
            AtualizarDisplay();
        }

        //Aplicação prática de algoritmo "bubble sort". 
        private void Ordenar()
        {
            // variavel para guardar temporariamente o contato,enquanto
            // alteramos seu posicionamnto na lista
            contato temporario;
            bool trocar = true;
            do
            {
                trocar = false;
                for(int i = 0; 1 < (listaDeContatos.Length - 1); i++)
                {
                    if (listaDeContatos[i].PrimeiroNome.CompareTo(listaDeContatos[i + 1].PrimeiroNome) > 0 )
                    {
                        temporario = listaDeContatos[i];
                        listaDeContatos[i] = listaDeContatos[i + 1];
                        listaDeContatos[i + 1] = temporario;
                        trocar = true;
                    }

                }

            } while (trocar == true);
        }
    }
}

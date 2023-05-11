using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_simples
{
    internal class contato
    {
        /* aaaa 
         */
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        //PROPRIEDADES (GET e SET)
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }

        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Telefone 
        { 
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                    telefone = value;               

                else
                    Telefone = "00000000000";
                
            }
            
        }


        public contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-91234-5678";

        }

        public contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += "";
            saida += String.Format("{0}-{1}-{2}", 
                Telefone.Substring(0, 1), 
                Telefone.Substring(2, 4), 
                Telefone.Substring(7, 3));
            
            return saida;
        }

    }

}

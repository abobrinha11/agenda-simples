using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
        private string email;

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
        public string Email
        {
            get { return email; }
            set { email = value; }
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
            Email = "abacate@hotmail.com";

        }

        public contato(string primeiroNome, string sobrenome, string email, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            string saida = String.Empty;
            saida += String.Format("{0}, {1}, {2},", PrimeiroNome, Sobrenome, Email);
            saida += "";
            saida += String.Format("({0}-{1}-{2})", 
                Telefone.Substring(0, 2), 
                Telefone.Substring(2, 5), 
                Telefone.Substring(7, 4));
           
            saida += " ";
            //saida += String.Format("{0}", Email);
            
            return saida;
        }

    }

}

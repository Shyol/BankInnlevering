using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig5
{
    public class Kunder
    {
        private string navn;
        private string password;
        private double saldo;
        
        public Kunder(string Name, string PW)
        {
            Navn = Name;
            Password = PW;
            Saldo = 0;
        }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Password { get => password; set => password = value; }
        public string Navn { get => navn; set => navn = value; }
    }
}

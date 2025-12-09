using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hospede
    {
        public string Nome {  get; private set; }
        public string Email { get; private set; }
        public int Quarto { get; private set; }

        public Hospede(string nome, string email, int quarto) 
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public void QuartosOcupados()
        {
            Console.WriteLine($"{Quarto}: {Nome}, {Email}");
          
        }
    }
}

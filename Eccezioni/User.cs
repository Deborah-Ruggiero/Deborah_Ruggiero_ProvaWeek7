using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    class User
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public User()
        {

        }
        public User(int id, string nome, string cognome)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
        }


        public override string ToString()
        {
            return $"ID n.{Id} - Nome:{Nome}, Cognome: {Cognome}";
        }

    }
}


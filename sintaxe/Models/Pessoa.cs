using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        // Void quando retornar nada
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}
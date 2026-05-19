using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Personagem
    {
        // criar as propriedades da classe automovel
        public string Nome { get; set; }
        public string NomeObra { get; set; }
        public string TipoObra { get; set; }
        public int Ano  { get; set; }

        /*  
          private string Marca;

          public void SetMarca(string marca) {
                  Marca = marca;
          }

          public string GetMarca() {
               return Marca;
          }
         */

        // criar um constructor para a classe automovel
        public Personagem() { 
        
        }

        public Personagem(string nome)
        {
             this.Nome = nome;
        }

        public void Acelerar() {
            Console.WriteLine("Acelerando o carro");
        }
        
        public string Acelerar(string velocidade) {
            return " Acelerando o carro a " + velocidade + " KM/H";
        }

        public int Acelerar(int velocidade) {
            return velocidade + 10;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cachorro : Animal

        //metodo publico é pascal case , metodo privado camelCase
    {
        public int Idade; // simples

        private int idadePreDefinida = 2;

        public int Idade2 
        { 
            get 
            {
                return idadePreDefinida; 
            }
            set 
            {
                idadePreDefinida = value;
            }
        }
                
        //complexa posso tirar get ou set para restringir , set é recomendado tirar quando trabalho com privado

        public override void Latir()
        {
            Console.WriteLine("Au eu sou um cachorro");
        }
    }
        
    
}

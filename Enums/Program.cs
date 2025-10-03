using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        enum NotaDeReal_e //enums devem ser declarados fora do metodo main
        {
            NotaDe2 = 2, //separando os valores com virgula, o ultimo nao precisa de nada
            NotaDe5 = 5, // apenas numeros inteiros, nao pode com virula
            NotaDe10 = 10
        }
        enum NotaDaProva
        {
            Nota0 = 0,
            Nota1,
            Nota2,      //desta forma ele faz automaticamente um incremento de 1 em 1
            Nota3,
            Nota4
        }
        static void Main(string[] args)
        {
            NotaDeReal_e minhaNota = NotaDeReal_e.NotaDe10; //para usar o enum, declare uma variavel do tipo do enum e atribua um dos valores
            Console.WriteLine(minhaNota + " vale " + Convert.ToUInt32(minhaNota)); 
            NotaDaProva notaProva = NotaDaProva.Nota3; 
            Console.WriteLine(notaProva + " vale " + Convert.ToUInt32(notaProva));
            Console.ReadKey(true);
        }
    }
}

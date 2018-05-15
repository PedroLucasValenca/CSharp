using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Carro Criado, velocidade Inicial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();
            Console.WriteLine("Carro, velocidade Atual: " + c.Velocidade);
            AcelerarBastante(c);
            Console.WriteLine("Carro, velocidade Atual: " + c.Velocidade);

            Onibus o = new Onibus();
            Console.WriteLine("Onibus Criado, velocidade Atual: " + o.Velocidade);
            o.Acelerar();
            o.Acelerar();
            Console.WriteLine("Onibus, velocidade Atual: " + o.Velocidade);
            AcelerarBastante(o);
            Console.WriteLine("Onibus, velocidade Atual: " + o.Velocidade);

            Console.ReadKey();
           
        }
        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();

            }
        }
    }

    
}

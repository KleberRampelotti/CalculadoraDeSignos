using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            Console.WriteLine("Que dia você nasce?");
            dia = Console.ReadLine();

            Console.WriteLine("Que mês você nasce?");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                diaInt = Convert.ToInt32(dia);
                mesInt = Convert.ToInt32(mes);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            if (signo != null)
            {
                Console.WriteLine("Seu signo é  " + signo.nome + " " + signo.caracteristicas);                
            }

            else
            {
                Console.WriteLine("Não foi possível interpretar seu signo, tente novamente");                
            }

            Console.ReadLine();
        }
    }
}

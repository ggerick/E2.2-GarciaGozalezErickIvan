using System;

namespace factoriales
{
    	 public class Clase
    {

        public void iterativo(int sucesiones)
        {
            int resultado = 0;
            int resulviejo = 0;
            int resulnuevo = 1;
            Console.WriteLine(resulviejo);
            for (int contador = 1; contador  <= sucesiones; contador++)
            {
                resulviejo = resulnuevo;
                resulnuevo = resultado;
                resultado = resulviejo + resulnuevo;
               
                Console.WriteLine(resultado);

            }

        }

        public int recursividad(int sucesiones)
        {

            if (sucesiones == 0 || sucesiones == 1)
                return sucesiones;

            return recursividad(sucesiones - 1) + recursividad(sucesiones - 2);


        }
        
    }
    class MainClass
    {
		
        public static void Main(string[] args)
        {
            Clase kk = new Clase();
           
            Console.WriteLine("\tFibonacci con iteratividad\n");
            Console.Write("Inserta el numero a fibonaccisiar: ");
            int sucesiones = int.Parse(Console.ReadLine());
            var watch = System.Diagnostics.Stopwatch.StartNew();
            kk.iterativo(sucesiones);
            watch.Stop();
            Console.WriteLine(watch.Elapsed.ToString());
			Console.WriteLine("\tAhora con recursividad");
            watch.Start();
            Console.WriteLine(kk.recursividad(sucesiones));
            watch.Stop();
            Console.WriteLine(watch.Elapsed.ToString());

            Console.ReadKey();
        }
    }
}

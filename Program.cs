using System;

namespace separação_de_par_e_impar
{
    class Numero()
    {
       private int geraNumero()
       {
           Random gerador = new Random();
           
           int Numero = gerador.Next(0,101);

           return Numero;
       }

       public int numeros_gerados => geraNumero();

    }
    class Par()
    {
       public static void numero_par()
        {
            Numero n = new Numero();

            for (int i = 0; i< 100; i++)
            {
                int numeros = n.numeros_gerados;
                if (numeros %2 ==0)
                {
                    Console.WriteLine(numeros);
                }
            }

        
        }

        public static void numero_impar()
        {
             Numero n = new Numero();
            for (int i = 0; i< 100; i++)
            {
                int numeros = n.numeros_gerados;
                if (numeros %2 ==1)
                {
                    Console.WriteLine(numeros);
                }
        }

        }

    }
}
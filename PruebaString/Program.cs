using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PruebaString
{
    class Program
    {
        static void Main(string[] args)
        {

            //objeto a = new objeto();

           // a.nombre = "Jesus";
            //Console.WriteLine("STRING " +  a.nombre + " -  "+ a.apellido +" <--" + " --> "+ a.codigo+ " <--- "); 

           /* int[] numeros = { 8, 8, 8, 8, 8, 6, 6, 6, 6, 6, 6 };

            var lowNums = (from num in numeros
                          select num).Distinct();

            var todos = (from num in numeros
                         select num);

            Console.WriteLine(" CON  DISTINCT ");

            // Execute the query.
            foreach (int i in lowNums)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" SIN DISTINCT ");

            foreach (int i in todos)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();*/
            StringBuilder strBTextoLog = new StringBuilder();

            string limite = "Por el Norte: hasta Los Ejidos, incluyendo la Urb. Santa PorelMaría del Pinar. Por el Sur: hasta Urb. Miraflores y Av. Progreso de Castilla. Por el Este: hasta AA.HH. San Pedro y Av. Circunvalación Por el Oeste: hasta Av. Prolongación Grau Cdra. 35.";

            string l1;
            string l2;

           // strBTextoLog.AppendLine(string.Concat("MAYUSCULAS: ", "-----------------"));
          //  strBTextoLog.AppendLine(string.Concat("", limite.ToUpper()));
            //limite = limite.ToUpper();
          //  strBTextoLog.AppendLine(string.Concat("-----------------: ", "-----------------"));

            if (limite.Contains("Por el"))
            {
                

                string limFinal = string.Empty;
                l1 = limite.Substring(0, 14);
                l2= limite.Substring(14);
                l2 = l2.Replace("Por el", System.Environment.NewLine + "Por el");
                limFinal = l1 + l2;


                strBTextoLog.AppendLine(string.Concat(limFinal));
               // limite.TrimStart('\r');
               // limite.TrimStart('\n');


                 
               //  string[] limites = limite.Split('#');


            }



                            


            StreamWriter log = new StreamWriter("C:\\PruebaString\\1_Log.txt");
            log.WriteLine(strBTextoLog);
            log.Close(); 



        }
    }
}

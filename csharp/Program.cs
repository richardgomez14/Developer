using System;
using System.Collections;
using System.Collections.Generic;   
using System.Text;
using ClasesPropias; 

namespace Richard
{
    class Program
    {
        // Esta es la funcion principal del programa
        //Aqui inicia la aplicacion
        static void Main(string[] args)
        {
            //float lnArea;
            int lnBase;
            float lnAltura = 0.0f, lnResultado = 0.0f ; 
            float a; 
            float b;    
            float c;
            string lcOperacion = "";
            int lnOpcion = 0; 
            
            string lcRichard = string.Concat("Hola", " Como estas, ", "Hoy es un día maravilloso");
           
            var bebidas = new bebidas("Porlacita",250);
            Console.WriteLine($"Richard se tomó una: {bebidas.ImprimirMarca("Polarcita")} de {bebidas.SeleccionarMedida("Polarcita")}");

                     

            a = 10; 
            b = 1.16f; 
            //c = a * b ;   
            c = (3+7)*(36+4*(2+5));

            lnBase   = 8;
            lnAltura = 10;
            lnResultado = lnAltura / lnBase;
                                   
            Console.WriteLine(lcRichard);

            Console.Title = "Mi Aplicacion de C#";     
            Console.WriteLine("Que operacion desea realizar:");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Restar");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- Divir");
            
            lcOperacion = Console.ReadLine();

            lnOpcion = Convert.ToInt32(lcOperacion);

            Console.WriteLine("Indique el Valor de a:");
            lcOperacion = Console.ReadLine();
            a = Convert.ToSingle(lcOperacion);

            Console.WriteLine("Indique el Valor de b:");
            lcOperacion = Console.ReadLine();
            b = Convert.ToSingle(lcOperacion);

            switch (lnOpcion)
            {
                case 1: 
                c = a + b ;
                break;
                case 2:
                c = a - b ;
                break;
                case 3:
                c = a * b ;
                break;
                case 4:
                    if (b!=0 && b > 0)
                        {
                            c = a / b ;
                        }
                    else 
                        {
                            Console.WriteLine("El valor de B debe ser mayor a cero...!!!");
                            c = 0.0f;
                        }   
                break;

                default:
                Console.WriteLine("Opción no Válida...!!!");
                break;
            }    
            /*
            if (lnOpcion==1)
            {
                c = a + b ;        

            }
            else
            {
                if (lnOpcion ==2)
                {
                    c = a-b;
                }
                else
                {
                    if (lnOpcion==3)
                    {
                        c = a * b;
                    }
                    else 
                    {
                     if (b > 0)
                     {
                        c = a / b; 
                     }
                     else
                     {
                        Console.WriteLine("B (Divisor) debe ser mayor a cero (0)");
                        c = 0.0f;
                     }

                    }                            
                } 
           }
           */
            var richard = "Hola Richard eres un duro es c#"; 
           int[] marcos = new int[]{0,1,2,3,4,5,6,7,8,9};
           List<int> lista  = new List<int>();

           ArrayList diana = new ArrayList();

           
           Console.WriteLine($"Buen Día,\n {richard}"); 
           Console.WriteLine("El resultado de la operacion es: {0}", c);
           Console.WriteLine($"Marcos tiene un valor de: {marcos[0]}, {marcos[1]},\n,{marcos[2]}");
           Console.ReadKey(true) ;

            /*
            lnArea = lnBase * lnAltura;
            Console.Write("Richard" + " " + "\n");
            Console.WriteLine("Gomez \n\n la base del rectangulo es: {0}\n" 
              + "y la altura del rectangulo es: {1} \n"
              + "el área del rectangulo es: {2} \n" 
              + "y el resultado de la division es: {3} \n"
              + "y el resultado de c es:  {4}"
               , lnBase, lnAltura, lnArea, lnResultado,c);
               Console.WriteLine("Ingresa tu lcOperacion:");
               lcOperacion = Console.ReadLine();
               Console.WriteLine("Tu lcOperacion es: {0}",lcOperacion);
               Console.WriteLine("Ingrese el valor de a: ");
               lcOperacion = Console.ReadLine();
               c = Convert.ToInt32(lcOperacion) * lnBase;
               Console.WriteLine("El valor convertido de lcOperacion es: {0}",c);                
            */    
        }
    }
}

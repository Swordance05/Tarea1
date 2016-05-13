using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factura
{
    class Program
    {
        static String nombre = " ";
        static String telefono = " ";
        static int cantidad = 0;
        static double precio = 0;
        static double descuento = 1;
        static double varlordes = 0;
        static double iva, total = 0;
        static double neto = 0;
        static double recibir = 0;
        static double cambio = 0;
        static double totalorden = 0;
        static double descuentototal = 0;
        static Boolean terminar = false;
        static char caracter = ' ';
        static int numero = 0;
        static double subtotal = 0;
        static int[,] compra = new int[150, 2];
        static int contador = 0;
        static int[] Precios = new int[10] { 1000, 2500, 3000, 5000, 4000, 15000, 2500, 10000, 5000, 6000 };
        static string[,] Libros = new string[10, 2]{{"1-  El Señor de los anillos, Las dos torres","- fantasia"},{"2-  Alicia en el país de la Maravillas     ","- infantil"},{"3-  Cementerio de Mascotas                 ","- misterio"},{"4-  Quiero aprender                        ","- educativo"},{"5-  El poder del pensamiento Positivo      ","- superacion"},
        {"6-  Mi primer libro de matemáticas         ","- educativo"},{"7-  Las aventuras de Tom Sawyer            ","- infantil"},{"8-  El mago de Oz                          ","- fantasia"},{"9-  La zona muerta                         ","- misterio"},{"10- viaje al centro de la tierra           ","- ciencia ficcion"}};




        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre :");

            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su numero de telefono :");

            telefono = Console.ReadLine();



            while (!terminar) {

                Console.WriteLine("-----------------------------------------------------------");

                Console.WriteLine("Sistema de facturacion Libreria El Buen Lector");

                Console.WriteLine("-----------------------------------------------------------");

                for (int i = 0; i < 10; i++ ) {
                    
                    Console.WriteLine(" ");
                    
                    for (int x = 0; x < 2; x++) {

                        Console.Write(Libros[i, x]);

                        

                    }

                    
 

                }


                Console.WriteLine(" ");

                Console.WriteLine("-----------------------------------------------------------");

                Console.WriteLine("Ingrese el numero del libro que desea comprar");

                numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de libros que desea comprar");

                cantidad = int.Parse(Console.ReadLine());

                compra[contador,0] = numero;
                compra[contador, 1] = cantidad;

                contador++;

                Console.WriteLine("¿Desea comprar otro libro?(S)(N)");

                caracter = char.Parse(Console.ReadLine());

                if (caracter == 'N' || caracter == 'n')
                {

                    terminar = true;

                }
                else {

                    terminar = false;

                }
            
            }

                Console.WriteLine("resultado");

                for (int y = 0; y < contador; y++) {
                    
                    Console.WriteLine(" ");
                    subtotal = Precios[compra[y,0] - 1] * compra[y,1];
                    totalorden = totalorden + subtotal;
                    Console.WriteLine("Total orden ¢" + totalorden);

                    

                    for (int t = 0; t < 2; t++) {

                        Console.Write(compra[y, t]);
                        Console.Write(" -- ");
                        


                    }
                }

                Console.WriteLine(" ");

                Console.WriteLine("====================================================================");
                Console.WriteLine("*-*                   Libreria EL Buen Lector                 *-*   ");
                Console.WriteLine("====================================================================");
                Console.WriteLine("Factura proformar");
                Console.WriteLine("Cliente:" + nombre);
                Console.WriteLine("Telefono:" + telefono);

                Console.WriteLine("--------------------------------------------------------------------");

                Console.WriteLine("Item                                             Ctd    Precio    SubTotal      ");
                
                Console.WriteLine(" ");

                for (int j = 0; j < contador; j++) { 
                
                subtotal = Precios[compra[j,0]-1]*compra[j,1];

                Console.WriteLine(Libros[compra[j, 0] - 1, 0] + "      " + compra[j, 1] + "      ¢" + Precios[compra[j, 0] - 1] + "      ¢" + subtotal);

                Console.WriteLine("   ");

                //Console.WriteLine(Libros[compra[j, 0], 1]);

                switch (Libros[compra[j,0],1]) { 
                
                    case "- infantil":
                        //Console.WriteLine(Precios[compra[j, 0] - 1]);
                        descuento = Precios[compra[j, 0]-1] * 0.05;
                        //Console.WriteLine(descuento);

                        break;

                    case "- misterio":
                        //Console.WriteLine(Precios[compra[j, 0] - 1]);
                        descuento = Precios[compra[j, 0]-1] * 0.10;
                        //Console.WriteLine(descuento);
                        break;

                    case "- fantasia":
                        //Console.WriteLine(Precios[compra[j, 0] - 1]);
                        descuento = Precios[compra[j, 0]-1] * 0.15;
                        //Console.WriteLine(descuento);
                        break;
    
                    case "- educativo":
                        //Console.WriteLine(Precios[compra[j, 0] - 1]);
                        descuento = Precios[compra[j, 0]-1] * 0.20;
                        //Console.WriteLine(descuento);
                        break;
                    
                    default:
                        //Console.WriteLine(Precios[compra[j, 0] - 1]);
                        descuento = Precios[compra[j, 0]-1] * 0.25;
                        //Console.WriteLine(descuento);
                        break;

                        
                    }
                       
                        descuento = descuento * compra[j, 1];

                        descuentototal = descuentototal + descuento;


                       
                }

                Console.WriteLine("---------------------------------------------------------------------");

                Console.WriteLine("Total orden: " + totalorden + "¢");
                Console.WriteLine("Descuento: " + descuentototal + "¢");
                Console.WriteLine("Impuesto de venta : 13%");
                iva = totalorden * 0.13;
                Console.WriteLine("Impuesto total :" + iva);
                neto = totalorden - descuentototal + iva;
                Console.WriteLine("Precio neto :" + neto);

                Console.WriteLine("---------------------------------------------------------------------");

                Console.WriteLine(" ");

                Console.Write("Monto recibido : ¢" );
                recibir = Double.Parse(Console.ReadLine());
                //Console.WriteLine(recibir);

                cambio = recibir - neto;

                Console.WriteLine("Monto cambio : ¢" + cambio);

                Console.WriteLine("====================================================================");
                
                Console.WriteLine("Gracias por su compra");

                Console.ReadKey();
            
           

        }
    }
}


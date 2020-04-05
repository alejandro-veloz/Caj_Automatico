using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caj_Automatico
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*Para saber si quiere salir o continuar*/
            string menu = "2";
            while (menu != "1")
            {

                
                /*Valores asignados a las papeletas y otras variables para almacenar los datos*/
                int B1000 = 40, B500 = 60, B200 = 100, B100 = 100;
                int cantidad1 = B1000 * 1000, cantidad2 = B500 * 500, cantidad3 = B200 * 200, cantidad4 = B100 * 100;
                bool si;
                string CLAVE;
                int clave2;
                Console.ForegroundColor = ConsoleColor.Blue;
                 /*Para poder ingresar al programa con una clave*/
                do {
                    Console.WriteLine("                  Bienvenido                 ");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("**            CAJERO AUTOMATICO            **");
                    Console.WriteLine("**               DE LA ROSA                **");
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("Si su clave es incorrecta o ingresa letras, el programa volvera a pedirle su clave nuevamente.");
                    Console.WriteLine("---Ingrese su clave---");
                    CLAVE = Console.ReadLine();
                    si = int.TryParse(CLAVE, out clave2);
                    Console.Clear();
                } while (!si);

                
                Console.WriteLine("*********************************************");
                Console.WriteLine("**            CAJERO AUTOMATICO            **");
                Console.WriteLine("**               DE LA ROSA                **");
                Console.WriteLine("*********************************************");
                Console.WriteLine("Nuestro cajero solo contiene billetes de -->> 1,000RD$, 500RD$, 200RD$ y 100RD$ ");
                Console.WriteLine("Presione la Tecla (Enter) Para -->> Continuar ........");
                Console.ReadLine();
                Console.Clear();



                Console.WriteLine("*********************************************");
                Console.WriteLine("**            CAJERO AUTOMATICO            **");
                Console.WriteLine("**               DE LA ROSA                **");
                Console.WriteLine("*********************************************");
                Console.WriteLine("Si ingresa un monto que sea superior a la cantidad máxima, el progama se reiniciara");
                Console.WriteLine("y volvera a pedirle sus datos.");
                Console.WriteLine("La cantidad máxima es -->> 15,000RD$");
                Console.WriteLine("---Ingrese la cantidad que desea retirar---");
                int monto = int.Parse(Console.ReadLine());
                Console.Clear();

                /*Para la distribución de las papeletas*/
                Console.WriteLine("*********************************************");
                Console.WriteLine("**            CAJERO AUTOMATICO            **");
                Console.WriteLine("**               DE LA ROSA                **");
                Console.WriteLine("*********************************************");
                
                int retiro;

                if (monto > 15000)
                {

                    
                }
                if (monto <= 15000)
                {
                    Console.WriteLine("EL DINERO RETIRADO ES...");
                    if (monto >= 1000)
                    {
                        retiro = monto / 1000;
                        monto = monto - (retiro * 1000);
                        B1000 -= retiro;
                        cantidad1 = cantidad1 - (retiro * 1000);
                        Console.WriteLine("Billetes de 1,000RD$ -->> " + retiro);
                    }
                    if (monto >= 500)
                    {
                        retiro = monto / 500;
                        monto = monto - (retiro * 500);
                        B500 -= retiro;
                        cantidad2 = cantidad2 - (retiro * 500);
                        Console.WriteLine("Billetes de 500RD$ -->> " + retiro);
                    }
                    if (monto >= 200)
                    {
                        retiro = monto / 200;
                        monto = monto - (retiro * 200);

                        B200 -= retiro;
                        cantidad3 = cantidad3 - (retiro * 200);
                        Console.WriteLine("Billetes de 200RD$ -->> " + retiro);
                    }
                    if (monto >= 100)
                    {
                        retiro = monto / 100;
                        monto = monto - (retiro * 100);
                        B100 -= retiro;
                        cantidad4 = cantidad4 - (retiro * 100);
                        Console.WriteLine("Billetes de 100RD$ -->> " + retiro);
                    }

                    /*Para almacenar las papelets recibidas y las restantes*/
                    Console.WriteLine("---LA CANTIDAD DE BILLETES RESTANTES SON LAS SIGUIENTES---");
                    Console.WriteLine("Billetes de 1,000RD$ restantes -->> " + B1000);
                    Console.WriteLine("Billetes de 500RD$ restantes -->> " + B500);
                    Console.WriteLine("Billetes de 200RD$ restantes -->> " + B200);
                    Console.WriteLine("Billetes de 100RD$ restantes -->> " + B100);
                    Console.WriteLine("---EL VALOR TOTAL DE TODOS LOS BILLETES RESTANTES SON---");
                    Console.WriteLine("Valor total de todos los billetes de 1,000RD$ -->> " + cantidad1);
                    Console.WriteLine("Valor total de todos los billetes de 500RD$ -->> " + cantidad2);
                    Console.WriteLine("Valor total de todos los billetes de 200RD$ -->> " + cantidad3);
                    Console.WriteLine("Valor total de todos los billetes de 100RD$ -->> " + cantidad4);
                    Console.WriteLine("Presione la Tecla (Enter) Para -->> Continuar ........");

                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Ingrese (1) si desea salir, y si quiere continuar ingrese (2)");
                    menu = Console.ReadLine();
                    Console.Clear();


                }
            }
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;

namespace somebodyelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            string nameUser, lastName, contactNumber, city, FBprofile, email, user, password, codeAccess, passwordConfirm;
            byte age;

            #region //allenado de variables
            Console.WriteLine("Por favor, presiona ENTER cada que finalices de llenar los datos.");
            Console.WriteLine("Ingresa tu nombre");
            nameUser = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido");
            lastName = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad en dígito");
            age = Convert.ToByte(Console.ReadLine());
            #endregion

            #region//sí, entonces
            if (age >= 18)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Por favor, ingrese más datos para obtener su código");
                Console.WriteLine("Ingresa tu teléfono celular");
                contactNumber = Console.ReadLine();
                Console.WriteLine("Ingresa tu ciudad de residencia");
                city = Console.ReadLine();
                Console.WriteLine("ingresa tu perfil de Facebook");
                FBprofile = Console.ReadLine();
                Console.WriteLine("Ingrese su e-mail");
                email = Console.ReadLine();

                //solicita el acceso
                Console.WriteLine("Ingrese su nombre de usuario");
                user = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña");
                password = Console.ReadLine();
                Console.WriteLine("Confirme su contraseña");
                passwordConfirm = Console.ReadLine();

                if (password == passwordConfirm)
                {
                    // Numeros aleatorios
                    Console.WriteLine("\n");
                    Random rnd = new Random(); // Funcion de numeros aleatorios
                    codeAccess = rnd.Next(1000, 9999).ToString(); // guardamos ese numero en codeAccess ya convertido en .ToString
                    Console.WriteLine("Tu codigo de acceso es: {0}", codeAccess);
                    Console.ReadLine();
                }
                
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Solo pueden acceder personas mayores de edad");
            }
            #endregion
            Console.WriteLine("\n");
            Console.WriteLine("Saliendo");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo.");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo..");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo...");
            Thread.Sleep(1000);
        }
    }
}

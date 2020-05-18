using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO; //Agregadas Para la serializacion
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters; // Para cargar formato UML


namespace labMC6
{
    class Program
    {
       

        static void Main(string[] args)
        {
            int x= 0;
            string valor = "";


            Console.WriteLine("¿quiere utilizar un archivo para cargar a informacion de la empresa?  ");
            // Pedimos al usuario una de las opciones
            Console.WriteLine("");
            Console.WriteLine("1)SI");
            Console.WriteLine("");
            Console.WriteLine("2)no");
            valor = Console.ReadLine();
            x = Convert.ToInt32(valor);


          
            if (x == 1) //lee archivos
            {
                try 
                { 
                //deserializamos el objeto

                BinaryFormatter formateador = new BinaryFormatter();
                Stream miStream = new FileStream("empresa.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                Empresa MiEmpresa = (Empresa)formateador.Deserialize(miStream);
                    miStream.Close();

                }
                catch 
                {

                    string Nombre = "";
                    string ID = "";
                    Console.Clear();
                    Console.WriteLine("Indique nombre de la empresa");
                    Nombre = Console.ReadLine();

                    Thread.Sleep(2000);
                    Console.WriteLine("Indique Rut de la empresa");
                    ID = Console.ReadLine();
                    Thread.Sleep(2000);
                    Empresa MiEmpresa = new Empresa(Nombre, ID);
                    //se comienza la serializacion
                    BinaryFormatter formateador = new BinaryFormatter();

                    //creamos el stream que es para  ...
                    Stream miStream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                    //serializamos
                    formateador.Serialize(miStream, MiEmpresa);
                    //cerramos el stream
                    miStream.Close();
                }
                    

            if (x == 2)//guarda archivos si no existe 
            {
                string Nombre = "";
                string ID = "";
                Console.Clear();
                Console.WriteLine("Indique nombre de la empresa");
                Nombre = Console.ReadLine();

                Thread.Sleep(2000);
                Console.WriteLine("Indique Rut de la empresa");
                ID = Console.ReadLine();
                Thread.Sleep(2000);
                Empresa MiEmpresa = new Empresa(Nombre, ID);
                //se comienza la serializacion
                BinaryFormatter formateador = new BinaryFormatter();

                //creamos el stream que es para  ...
                Stream miStream = new FileStream("empresa.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                //serializamos
                formateador.Serialize(miStream, MiEmpresa);
                //cerramos el stream
                miStream.Close();

              

            }

            









        }
    }
    }
}
       
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
        //parte 3
        static void Save(List<Empresa> empresas) //creo metodo estatico para guardar los datos de la empresa en una lista
        {
            //se comienza la serializacion
            BinaryFormatter formateador = new BinaryFormatter();

            //creamos el stream que es para  ...
            Stream miStream = new FileStream("empresas.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            //serializamos
            formateador.Serialize(miStream,empresas);
            //cerramos el stream
            miStream.Close();

            //parte 3
        }
        static void Load(List<Empresa> empresas)//creo metodoo estatico para leer los datos de la lista
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("empresas.bin", FileMode.Open, FileAccess.Read, FileShare.None);
             List<Empresa>empresas1= (List<Empresa>)formateador.Deserialize(miStream);
            miStream.Close();

        }

        static void Main(string[] args)
        {
            Person person1 = new Person("34235", "maria ", "guzman  ", "encargado1");
            Person person2 = new Person("346237247", "jose", "peña", "encargado2");
            Person person3 = new Person("3648223", "pedro", "capo", "encargado3");
            Person person4 = new Person("34738238", "loreto", "mandiola", "encargado4");
            Person person5 = new Person("4367483", "sofia", "cornejo ", "personal");
            Person person6 = new Person("324523", "maria", "pesse", "personal");
            Person person7 = new Person("43232","fabian", "espinoza", "personal");
            Person person8 = new Person("47838384", "maria", "luisa", "personal");

            Person person9 = new Person("4334443", "dylan", "vera", "personal");
            Person person10 = new Person("3232334", "isidora", "catalan", "personal");
            int x = 0;
            string valor = "";
            List<Empresa> empresas = new List<Empresa>();//creamos una lista donde se guardaran todas las empresas que se creen (lisla de listas )
            List<Division> divisions = new List<Division>();
            bool exec = true;

            while (exec)
            {
                
                Console.WriteLine("¿quiere utilizar un archivo para cargar a informacion de la empresa?  ");
                // Pedimos al usuario una de las opciones
                Console.WriteLine("");
                Console.WriteLine("1)SI");
                Console.WriteLine("");
                Console.WriteLine("2)no");
                Console.WriteLine("");
                Console.WriteLine("3)Salir");
                valor = Console.ReadLine();
                x = Convert.ToInt32(valor);
                if (x == 1)
                {
                    try
                    {
                        Load(empresas);
                        Thread.Sleep(2000);
                        Console.WriteLine("Se cargaron los datos correctamente");

                        Thread.Sleep(2000);



                    }
                    catch
                    {
                        Console.WriteLine("no existe ninguna empresa creada anteriormente ");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("Cree una nueva empresa ");
                        Thread.Sleep(2000);
                        string Nombre = "";
                        string ID = "";
                        Console.Clear();
                        Console.WriteLine("Indique nombre de la empresa");
                        Nombre = Console.ReadLine();

                        Thread.Sleep(2000);
                        Console.WriteLine("Indique Rut de la empresa");
                        ID = Console.ReadLine();

                        Thread.Sleep(2000);

                        Console.WriteLine("Graciar por crear su cuenta ,se generaran los bloques ,seccion y division automaticamente");
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");


                        CreateSeccion();//llamamos al metodo que crea la seccion con el respectivo encargado de la division
                        CreateBloques();//llamamos al metodo que crea los bloques



                        Empresa empresa = new Empresa(Nombre, ID); //creo una empresa con su nombre y rut correspondiente y lo agrego a la nueva lista donde estan todas las empresas
                        empresas.Add(empresa);//agrego la empresa creada a la nueva lista de empresas
                        Save(empresas);// Procedo a la guardacion 

                    }




                }
                else if (x == 2) //opicion para agregar la lista
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
                    Console.WriteLine("Graciar por crear su cuenta ,se generaran los bloques ,seccion y division automaticamente");
                    Thread.Sleep(2000);
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");

                    Empresa empresa = new Empresa(Nombre, ID); //creo una empresa con su nombre y rut correspondiente y lo agrego a la nueva lista donde estan todas las empresas
                    empresas.Add(empresa);//agrego la empresa creada a la nueva lista de empresas
                    CreateSeccion();//llamamos al metodo que crea la seccion con el respectivo encargado de la division
                    CreateBloques();//llamamos al metodo que crea los bloques

                    Save(empresas);// Procedo a la guardacion


                }
                else if (x == 3)
                {
                    Console.WriteLine("gracias, adios");
                    exec = false;
                    break;

                }
                else { 
                    Console.WriteLine("ERROR,opcion ingresada invalida , por favor seleccione una opccion correcta");
                Thread.Sleep(2000);
                     }
            }
            //metodo para crear bloque

            void CreateBloques()
            {
                Bloque bloque1 = new Bloque("bloque1",  person5.charge, person6.charge);
                Bloque bloque2 =new Bloque("bloque2", person7.charge, person8.charge);
                divisions.Add(bloque1);
                divisions.Add(bloque2);
            }
            void CreateSeccion()
            {
                Seccion seccion1 = new Seccion("seccion1", person1.charge);
                divisions.Add(seccion1);
            }
            




            /*// esto lo habia realizado para la parte 1 y 2
             

            
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

              

           
            */
        }

            









        
    }
    
}
       
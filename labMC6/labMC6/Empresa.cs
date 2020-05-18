using System;
using System.Collections.Generic;
using System.Text;

namespace labMC6
{
    [Serializable]
    class Empresa
    {
        private string Rut;
        private string Name;
        public string rut { get => Rut; set => Rut = value; }
        public string name { get => Name; set =>Name = value; }




        public Empresa(string rut, string name)
        {
            this.rut = Rut;
            this.name = Name;


        }
        public void ShowInf()
        {
            Console.WriteLine("Nombre Empresa: " , name);
            Console.WriteLine("Rut Empresa: " , Rut);

        }
            
        
    }
}

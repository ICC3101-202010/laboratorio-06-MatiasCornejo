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

        //creo la lista divisions para la parte 2
            
        private List<Division> divisions = new List<Division>();
        public string rut { get => Rut; set => Rut = value; }
        public string name { get => Name; set =>Name = value; }
        internal List<Division> Divisions { get => divisions; set => divisions = value; }

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

using System;
using System.Collections.Generic;
using System.Text;

namespace labMC6
{
    [Serializable]
    class Person

    {
        private string LastName;
        private string NamePerson;
        private string RutPerson;
        private string Charge;
        public string lastname { get =>LastName; set => LastName = value; }
        public string nameperson { get => NamePerson; set => NamePerson = value; }
        public string rutperson { get => RutPerson; set => RutPerson = value; }
        public string charge { get => Charge; set => Charge = value; }




        public Person(string rutperson, string nameperson, string lastname, string charge)
        {
            this.rutperson = RutPerson;
            this.nameperson = NamePerson;
            this.lastname = LastName;
            this.charge = Charge;



        }

    }
}


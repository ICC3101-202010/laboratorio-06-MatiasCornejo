using System;
using System.Collections.Generic;
using System.Text;

namespace labMC6
{
    [Serializable]
    class Bloque:Division
    {
        private string nameEncargado;
        private string personal1;
        private string perosnal2;
        private string personal2;

        public Bloque()
        {
        }

        public Bloque(string nameDivision,
                       string personal1,string personal2)
        {
            
            string Personal1 = this.personal1;
            string Personal2 = this.personal2;
        }
    }
}

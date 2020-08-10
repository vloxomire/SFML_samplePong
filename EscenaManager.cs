using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    class EscenaManager
    {
        public static Escena currentEscene = null;
        public static void LoadEscena(Escena escena) 
        {
            currentEscene = escena;
            currentEscene.Init();
        }
    }
}

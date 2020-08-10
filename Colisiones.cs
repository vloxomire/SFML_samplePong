using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    class Colisiones
    {
        Barra barra;
        public Colisiones() 
        {
            barra = new Barra();
        }
        public void Update(float deltaTime,Barra a,Esfera b) 
        {
            procesarColisiones(a,b);
        }
        public void procesarColisiones(Barra a,Esfera b) 
        {
            if (a.GetRenderer().GetGlobalBounds().Intersects(b.GetRenderer().GetGlobalBounds()))
            {
                b.Xvel=-b.Xvel;
                b.Yvel=-b.Yvel;
            }
        }
    }
}

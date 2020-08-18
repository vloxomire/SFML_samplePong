using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    class JuegoFinalizado : Escena
    {
        Text label;
        public override void Init()
        {
            label = new Text("GAME OVER", new Font("font/Minecraft.ttf"));
        }

        public override void Update(float deltaTiempo)
        {
            
        }
        public override void Draw(RenderWindow ventana)
        {
            ventana.Draw(label);
        }
    }
}

using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    class Pausa : Escena
    {
        Text label1;
        public override void Init()
        {
            label1 =new Text("Pausa",(new Font("font/Minecraft.ttf")));
            label1.Origin = new Vector2f(label1.GetGlobalBounds().Width / 2,label1.GetGlobalBounds().Height/2);
            label1.Position =new Vector2f(ProgramMain.width/2,ProgramMain.heigth/2);
            //Sonido.PararMusica(Sonido.PlayMusica());
        }

        public override void Update(float deltaTiempo)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.P))
            {
                EscenaManager.LoadEscena(new GamePlay());
            }
        }
        public override void Draw(RenderWindow ventana)
        {
            ventana.Draw(label1);
        }
    }
}

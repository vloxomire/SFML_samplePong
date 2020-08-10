using SFML.Graphics;
using System;
using SFML.System;
using SFML.Window;

namespace SFML_sample
{
    class GamePlay : Escena
    {
        Esfera esfera;
        Sprite background;//FONDO
        Barra player;
        Colisiones colisiones;
        public GamePlay() 
        {
            colisiones = new Colisiones();
            player = new Barra();
            esfera = new Esfera();
        }
        public override void Draw(RenderWindow ventana)//DIBUJA
        {
            ventana.Draw(background);
            ventana.Draw(player.GetRenderer());
            ventana.Draw(esfera.GetRenderer());
        }

        public override void Init()//constructor viene a cumplir la funcion del constructor
        {
            

            Texture textura;
            textura = new Texture("Sprite/arbol.png");
            background = new Sprite(textura);
            background.Scale /= 1.8f;
        }

        public override void Update(float deltaTime)
        {
            player.Update(deltaTime);
            esfera.Update(deltaTime);
            colisiones.Update(deltaTime,player,esfera);
        }
    }
}

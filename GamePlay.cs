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
        Text labelVida,avizo;
        float angulo;
        //public Text Avizo;
        Font fuente;
        string msj;
        public int Vida;
        public GamePlay() 
        {
            Vida = 3;
            angulo = 45.0f;
            msj = "Toco fondo";
            fuente = new Font("Font/Resitta.ttf");
            labelVida = new Text("Vida:"+Vida, fuente);
            labelVida.Scale = new Vector2f(2.0f, 2.0f);
            labelVida.Position = new Vector2f(2.0f, 2.0f);
            labelVida.FillColor = Color.Red;

            avizo = new Text("dkdk",fuente);
            avizo.Scale = new Vector2f(2.0f, 2.0f);
            avizo.Position = new Vector2f(ProgramMain.width/2, ProgramMain.heigth/2);
            avizo.FillColor = Color.Red;
            avizo.Scale = new Vector2f(2.0f, 2.0f);

            player = new Barra();
            esfera = new Esfera();
        }
        public override void Draw(RenderWindow ventana)//DIBUJA
        {
            ventana.Draw(background);
            ventana.Draw(labelVida);
            ventana.Draw(player.GetRenderer());
            ventana.Draw(esfera.GetRenderer());
            ventana.Draw(avizo);
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
            if (player.GetGlobalBounds().Intersects(esfera.GetGlobalBounds())) 
            {
                esfera.OnPaddleCollision();
            }
            player.Update(deltaTime);
            TocaFondo();
            esfera.Update(deltaTime);
        }
        public void TocaFondo()
        {
            if (esfera.GetRenderer().Position.Y >= ProgramMain.heigth - esfera.GetGlobalBounds().Width/1.7 )
            {
                //Problema a veces detecta los bound otras no???
                Vida -= 1;
                labelVida.DisplayedString = "Vida:" + Vida;//Cambia texto
                esfera.GetRenderer().Rotation = -angulo;
                avizo.DisplayedString = "Toco fondo";
            }
        }
    }
}

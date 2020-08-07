using SFML.Graphics;
using System;
using SFML.System;
using SFML.Window;

namespace SFML_sample
{
    class GamePlay : Escenas
    {
        public CircleShape circulo;
        public RectangleShape rectangulo;
        public FloatRect ColisionCirculo;
        public FloatRect ColisionRectangulo;
        Texture circuloTextura, barraTexture;
        float velX = 200f;
        float velY = 200f;
        public override void Draw(RenderWindow ventana)
        {
            ventana.Draw(circulo);
            ventana.Draw(rectangulo);
        }

        public override void Init()
        {
            circulo = new CircleShape(30);
            //Textura
            //circuloTextura = new Texture("Texture\\WoodChips.PNG");
            //Circulo.Texture = circuloTextura;
            circulo.FillColor = Color.Red;
            circulo.Position = new Vector2f(0f, 0f);
            circulo.OutlineThickness = 10f;
            circulo.OutlineColor = Color.Green;
            //Colision
            ColisionCirculo = new FloatRect();
            //ColisionCirculo = Circulo.GetGlobalBounds();

            //RECTANGULO
            rectangulo = new RectangleShape(new Vector2f(150, 30));
            //Rectangulo.FillColor = Color.Blue;
            rectangulo.Position = new Vector2f(200, 550);//x/y 500bajo
            rectangulo.Origin = new Vector2f(75.0f, 15.0f);//Punto de pivote(giro), la mitad del objeto
            ColisionRectangulo = rectangulo.GetLocalBounds();
            rectangulo.OutlineThickness = 1f;
            //Textura barra
            barraTexture = new Texture("Texture\\MetalBeams.JPG");
            rectangulo.Texture = barraTexture;
        }

        public override void Update(float deltaTiempo)
        {
            //CheckPad
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                if (rectangulo.Position.X >= 0.0f + rectangulo.GetGlobalBounds().Width / 2.0f)
                {
                    rectangulo.Position += new Vector2f(-200f * time.AsSeconds(), 0.0f);
                }
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                if (rectangulo.Position.X <= ProgramMain.width - rectangulo.GetGlobalBounds().Width / 2.0f)
                {
                    rectangulo.Position += new Vector2f(200f * time.AsSeconds(), 0.0f);
                }
            }
            //CHEQUEO ESFERA
            if (circulo.Position.X > ProgramMain.width - circulo.GetGlobalBounds().Width || circulo.Position.X < 0.0f)
            {
                velX = -velX;
            }
            if (circulo.Position.Y > ProgramMain.width - circulo.GetGlobalBounds().Width || circulo.Position.Y < 0.0f)
            {
                velY = -velY;
            }
            circulo.Position += new Vector2f(velX, velY) * time.AsSeconds();
            //Colision
            if (circulo.GetGlobalBounds().Intersects(rectangulo.GetGlobalBounds()))
            {
                circulo.Position += new Vector2f(0.0f, -11100f * time.AsSeconds());
                //figura.Circulo.Position += new Vector2f(100f * time.AsSeconds(), 0.0f);
                while (circulo.Position.Y == 0.0f - circulo.GetGlobalBounds().Height / 2.0f)
                {
                    break;
                }
            }
        }
    }
}

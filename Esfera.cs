using System;
using SFML.Graphics;
using SFML.System;

namespace SFML_sample
{
    class Esfera : GameObject
    {
        Sprite renderer;//SPRITE??REFERENCIAS, QUE ES , Q HACE
        public float Xvel = 100.0f;//VELOCIDAD EN X
        public float Yvel = 100.0f;//VEL EN Y
        float xVel;
        float yVel;
        public Esfera()
        {
            this.xVel = Xvel;
            this.yVel = Yvel;
            Texture tex = new Texture("Sprite/craneo.png");
            renderer = new Sprite(tex);
            //renderer.Scale *=2.0f;
            renderer.Scale = new Vector2f(0.08f, 0.08f);
            renderer.Origin = new Vector2f(330.0f, 413.0f);//PROPIEDADES-DETALLE-LA MITAD DEL VALOR
            renderer.Position = new Vector2f(500, 100);
        }
        public override void Update(float deltaTime)
        {
            renderer.Rotation += 5;//ERROR CAMINA POR LA PARED, CON EL GIRO
            if (renderer.Position.X > ProgramMain.width - renderer.GetGlobalBounds().Width / 2.0f || renderer.Position.X < 0.0f + renderer.GetGlobalBounds().Width / 2.0f)
            {
                xVel = -xVel;
            }
            if (renderer.Position.Y > ProgramMain.heigth - renderer.GetGlobalBounds().Height / 2.0f || renderer.Position.Y < 0.0f + renderer.GetGlobalBounds().Height / 2.0f)
            {
                yVel = -yVel;
            }
            renderer.Position += new Vector2f(xVel, yVel) * deltaTime;
        }
        public override Sprite GetRenderer()
        {
            return renderer;
        }
    }
}

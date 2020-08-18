using System;
using SFML.Graphics;
using SFML.System;
using SFML.Audio;

namespace SFML_sample
{
    class Esfera : GameObject
    {
        float velX = 180.0f;//VELOCIDAD EN X
        float velY = 180.0f;//VEL EN Y
        public Esfera(Texture tex, float x, float y) : base(tex, x, y)
        {
            //renderer.Scale *=2.0f;
            renderer.Scale = new Vector2f(0.40f,0.45f);//70x87
            renderer.Origin = new Vector2f(renderer.GetGlobalBounds().Width,renderer.GetGlobalBounds().Height);//PROPIEDADES-DETALLE-LA MITAD DEL VALOR
        }
        public override void Update(float deltaTime)
        {
            if (!IsActive())
            {
                return;
            }
            if (renderer.Position.X > ProgramMain.width - renderer.GetGlobalBounds().Width / 2.0f || renderer.Position.X < 0.0f + renderer.GetGlobalBounds().Width / 2.0f)
            {
                velX = -velX;
                Sonido.PlaySonido(0);
            }
            if (renderer.Position.Y > ProgramMain.heigth - renderer.GetGlobalBounds().Height / 2.0f||renderer.Position.Y < 0.0f + renderer.GetGlobalBounds().Height / 2.0f)
            {
                velY = -velY;
                Sonido.PlaySonido(0);
            }
            renderer.Position += new Vector2f(velX, velY) * deltaTime;
        }
        public void OnPaddleCollision(COLLISION_DIRECTION dir)
        {
            switch (dir)
            {
                case COLLISION_DIRECTION.LEFT:
                case COLLISION_DIRECTION.RIGHT:
                    velX = -velX;
                    Sonido.PlaySonido(1);
                    break;
                case COLLISION_DIRECTION.TOP:
                case COLLISION_DIRECTION.BOT:
                    velY = -velY;
                    Sonido.PlaySonido(1);
                    break;
            }
        }  
    }
}

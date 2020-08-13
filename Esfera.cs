using System;
using SFML.Graphics;
using SFML.System;

namespace SFML_sample
{
    class Esfera : GameObject
    {
        float velX = 175.0f;//VELOCIDAD EN X
        float velY = 175.0f;//VEL EN Y
  
        public Esfera(Texture tex,float x,float y):base(tex,x,y)
        {
            //renderer.Scale *=2.0f;
            renderer.Scale = new Vector2f(0.08f, 0.08f);
            renderer.Origin = new Vector2f(330.0f, 413.0f);//PROPIEDADES-DETALLE-LA MITAD DEL VALOR
        }
        public override void Update(float deltaTime)
        {
            if (renderer.Position.X > ProgramMain.width - renderer.GetGlobalBounds().Width / 2.0f || renderer.Position.X < 0.0f + renderer.GetGlobalBounds().Width / 2.0f)
            {
                velX = -velX;
            }
            if (renderer.Position.Y > ProgramMain.heigth - renderer.GetGlobalBounds().Height / 2.0f||renderer.Position.Y < 0.0f + renderer.GetGlobalBounds().Height / 2.0f)
            {
                velY = -velY;
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
                    break;
                case COLLISION_DIRECTION.TOP:
                case COLLISION_DIRECTION.BOT:
                    velY = -velY;
                    break;
            }
        }  
    }
}

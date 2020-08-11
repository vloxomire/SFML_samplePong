using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace SFML_sample
{
    class Barra:GameObject
    {
        Sprite renderer;
        float barraVelocidad = 300.0f;
        public Barra() 
        {
            Texture tex = new Texture("Sprite/barra.png");
            renderer = new Sprite(tex);

            renderer.Position = new Vector2f(200,500);
            renderer.Origin = new Vector2f(321.0f, 85.0f);//643x171
            renderer.Scale = new Vector2f(0.30f,0.30f);
        }
        public override void Update(float deltaTime)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.A))
            {
                if (renderer.Position.X >= 0.0f + renderer.GetGlobalBounds().Width / 2.0f)
                {
                    renderer.Position += new Vector2f(-barraVelocidad * deltaTime, 0.0f);
                    //background.Position += new Vector2f(+30 * deltaTime, 0.0f);//Mover el fondo con el player
                }
            }
            if (Keyboard.IsKeyPressed(Keyboard.Key.D))
            {
                if (renderer.Position.X <= ProgramMain.width - renderer.GetGlobalBounds().Width / 2.0f)
                {
                    renderer.Position += new Vector2f(barraVelocidad * deltaTime, 0.0f);
                    //background.Position += new Vector2f(-30 * deltaTime, 0.0f);
                }
            }
        }
        public override Sprite GetRenderer()
        {
            return renderer;
        }

        public override FloatRect GetGlobalBounds()
        {
            return renderer.GetGlobalBounds();
        }
    }
}

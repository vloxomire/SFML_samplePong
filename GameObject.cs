using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace SFML_sample
{
    abstract class GameObject
    {
        protected Sprite renderer;
        public GameObject(Texture tex) 
        {
            renderer=new Sprite(tex);
        }
        public GameObject(Texture tex,float x, float y)
        {
            renderer = new Sprite(tex);
            renderer.Position = new Vector2f(x, y);
        }
        public abstract void Update(float deltaTime);
        public Sprite GetRenderer() 
        {
            return renderer;
        }
        public FloatRect GetGlobalBounds() 
        {
            return renderer.GetGlobalBounds();
        }
    }
}

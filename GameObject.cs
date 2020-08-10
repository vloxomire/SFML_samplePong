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
        public abstract void Update(float deltaTime);
        
        public abstract Sprite GetRenderer();
        
    }
}

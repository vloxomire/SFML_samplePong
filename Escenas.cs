using SFML.Graphics;

namespace SFML_sample
{
    abstract class Escenas
    {
        //Iniciaalizo la escena.
        public abstract void Init();
        //Compruebo input y updateo las posiciones.
        public abstract void Update(float deltaTiempo);
        //Dibujo los objetos correspondientes de la escena.
        public abstract void Draw(RenderWindow ventana);
    }
}

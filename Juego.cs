using System;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Audio;

namespace SFML_sample
{
    class Juego
    {
        private string gameName;
        public Juego(string gameName) 
        {
            this.gameName = gameName;
        }
        public void Run(RenderWindow window,Clock clock)
        {
            window.SetTitle(gameName);
            //PARA QUE INICIALIZE
            EscenaManager.LoadEscena(new Menu());//Carga la escena Menu
            //Sonido.PlaySonido();
            
            //El loop de juego - mientras la ventana este abierta
            while (window.IsOpen)
            {
                Time time = clock.Restart();

                //Verificamos si se triggereo algun evento
                window.DispatchEvents();

                Escena escena = EscenaManager.currentEscene;
                //INPUT
                escena.Update(time.AsSeconds());

                //BORRA LA PANTALLA
                window.Clear(Color.Black);

                //DIBUJAR
                escena.Draw(window);

                //MUESTRO LA PANTALLA
                window.Display();
            }
        }
    }
}

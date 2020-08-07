using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.Window;
using SFML.Graphics;
using SFML.System;

namespace SFML_sample
{
    class ProgramMain
    {
        public static uint width = 800;
        public static uint heigth = 600;
        enum Escenas { Menu, Juego }
        static void Main()
        {
            const string windowTitle = "Test";

            Escenas escena = Escenas.Juego;
            Clock clock = new Clock();

            //Creamos la  ventana,pasando el videomode y el titulo
            VideoMode videoMode = new VideoMode(width, heigth);
            RenderWindow win = new RenderWindow(videoMode, windowTitle);
            win.SetFramerateLimit(60);

            //Suscribirsee a eventos para registrar acciones
            win.Closed += OnWindowClosed;
            win.KeyPressed += OnKeyPressed;

            //El loop de juego - mientras la ventana este abierta
            while (win.IsOpen)
            {
                Time time = clock.Restart();

                //Verificamos si se triggereo algun evento
                win.DispatchEvents();
                //INPUT
                switch (escena)
                {
                    case Escenas.Juego:

                        break;
                }
                //BORRA LA PANTALLA
                win.Clear(Color.Black);
                //DIBUJAR LOS OBJETOS
                switch (escena)
                {
                    case Escenas.Juego:

                        break;
                }
                win.Display();
            }
        }
        private static void OnWindowClosed(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            window.Close();
        }
        private static void OnKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.Escape)
            {
                Window window = (Window)sender;
                window.Close();
            }
        }
    }
}

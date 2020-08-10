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
        static void Main()
        {
            const string windowTitle = "Test";

            Clock clock = new Clock();

            //Creamos un videomode para definir el ancho x alto de nuestra ventana
            VideoMode videoMode = new VideoMode(width, heigth);

            //Creamos la ventana´pasando el videomode y el titulo
            RenderWindow win = new RenderWindow(videoMode, windowTitle);
            win.SetFramerateLimit(60);

            //Suscribirsee a eventos para registrar acciones
            win.Closed += OnWindowClosed;
            win.KeyPressed += OnKeyPressed;

            Juego pong = new Juego("Pong");
            pong.Run(win,clock);
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

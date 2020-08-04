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
        enum escenas { Menu, Juego }
        static void Main() 
        {
            const uint width =800;
            const uint heigth = 600;
            const string windowTitle = "Test";

            VideoMode videoMode = new VideoMode(800,600);
            Clock clock = new Clock();

            //Creamos la  ventana,pasando el videomode y el titulo
            RenderWindow win = new RenderWindow(videoMode,windowTitle);
            win.SetFramerateLimit(60);

            //Creamos una figura
            CircleShape circulo = new CircleShape(50);
            circulo.FillColor=Color.Red;
            circulo.Position=new Vector2f(200,500);

            RectangleShape rectangulo = new RectangleShape(new SFML.System.Vector2f(100,50));
            rectangulo.FillColor = Color.Blue;
            rectangulo.Position = new Vector2f(200, 500);
            rectangulo.Origin = new Vector2f(50.0f,25.0f);

            //Suscribirsee a eventos para registrar acciones
            win.Closed += OnWindowClosed;
            win.KeyPressed += OnKeyPressed;

            //El loop de juego - mientras la ventana este abierta
            while (win.IsOpen)
            {
                Time time = clock.Restart();

                //Verificamos si se triggereo algun evento
                win.DispatchEvents();

                switch (escenas) 
                {
                    case escenas.Menu:
                        break;
                    case escenas.Juego:
                        break;
                }
                //INPUT
                win.Clear(Color.Black);
                win.Draw(circulo);
                win.Draw(rectangulo);
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
            if (e.Code==Keyboard.Key.Escape)
            {
                Window window= (Window)sender;
                window.Close();
            }
        }
    }
}

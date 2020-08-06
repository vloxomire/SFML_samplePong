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
        enum Escenas { Menu, Juego }
        static void Main()
        {
            const uint width = 800;
            const uint heigth = 600;
            const string windowTitle = "Test";

            Escenas escena = Escenas.Juego;

            MenuJuego menuJuego = new MenuJuego();
            Figuras figura = new Figuras();
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
                    case Escenas.Menu:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
                        {
                            escena = Escenas.Juego;

                        }
                        break;
                    case Escenas.Juego:
                        if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                        {
                            if (figura.Rectangulo.Position.X >= 0.0f + figura.Rectangulo.GetGlobalBounds().Width / 2.0f)
                            {
                                figura.Rectangulo.Position += new Vector2f(-200f * time.AsSeconds(), 0.0f);
                            }
                        }
                        if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                        {
                            if (figura.Rectangulo.Position.X <= width - figura.Rectangulo.GetGlobalBounds().Width / 2.0f)
                            {
                                figura.Rectangulo.Position += new Vector2f(200f * time.AsSeconds(), 0.0f);
                            }
                        }
                        //Movimiento circulo
                        figura.Circulo.Position += new Vector2f(0.0f, 100f * time.AsSeconds());

                        //Colision
                        if (figura.Circulo.GetGlobalBounds().Intersects(figura.Rectangulo.GetGlobalBounds()))
                        {
                            figura.Circulo.Position += new Vector2f(0.0f, -11100f * time.AsSeconds());
                            //figura.Circulo.Position += new Vector2f(100f * time.AsSeconds(), 0.0f);
                            while (figura.Circulo.Position.Y == 0.0f - figura.Circulo.GetGlobalBounds().Height / 2.0f)
                            {
                                break;
                            }
                        }
                        break;
                }
                //BORRA LA PANTALLA
                win.Clear(Color.Black);
                //DIBUJAR LOS OBJETOS
                switch (escena)
                {
                    case Escenas.Menu:
                        win.Draw(menuJuego.Texto);
                        break;
                    case Escenas.Juego:
                        win.Draw(figura.Circulo);
                        win.Draw(figura.Rectangulo);
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

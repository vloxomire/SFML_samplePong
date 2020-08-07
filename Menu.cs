using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System;


namespace SFML_sample
{
    class Menu : Escenas
    {
        Text menuLbl;
        public override void Draw(RenderWindow ventana)
        {
            ventana.Draw(menuLbl);
        }

        public override void Init()
        {
            //definimos una fuente, la cargamos de la carpeta de recursos
            //(creada en bin, donde esta el .exe)
            Font fuente = new Font("Font/BloodThirst.ttf");//Fuente
            menuLbl= new Text("Bienvenido al menu", fuente);
            menuLbl.FillColor = Color.Green;
            menuLbl.Style = Text.Styles.Bold | Text.Styles.Regular;
            menuLbl.Origin = new Vector2f(menuLbl.GetGlobalBounds().Width / 2.0f, menuLbl.GetGlobalBounds().Height / 2.0f);
            menuLbl.Position = new Vector2f(105f, 105f);
            menuLbl.Scale = new Vector2f(0.6f, 1.5f);
        }
        public override void Update(float deltaTiempo)
        {
            if (Keyboard.IsKeyPressed(Keyboard.Key.Enter))
            {
                //escena = Escenas.Juego;
            }
        }
    }


}
}

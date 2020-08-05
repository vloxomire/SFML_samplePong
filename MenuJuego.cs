using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    class MenuJuego
    {
        //definimos una fuente, la cargamos de la carpeta de recursos
        //(creada en bin, donde esta el .exe)
        private Font fuente;
        public Text Texto;
        public MenuJuego() 
        {
           //seteamos el pivot en el centro del objeto, obteniendo sus bounds / 2
            fuente = new Font("Font/BloodThirst.ttf");//Fuente
            Texto = new Text("Bienvenido al menu",fuente);
            Texto.FillColor=Color.Red;
            Texto.Style = Text.Styles.Bold|Text.Styles.Regular;
            Texto.Origin = new Vector2f(Texto.GetGlobalBounds().Width/2.0f,Texto.GetGlobalBounds().Height/2.0f);
            Texto.Position=new Vector2f(105f,105f);
            Texto.Scale = new Vector2f(0.6f,1.5f);
        }
    }
}

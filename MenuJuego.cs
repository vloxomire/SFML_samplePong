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
        private Font fuente;
        public Text Texto;
        public MenuJuego() 
        {
            fuente = new Font("Font/BloodThirst.ttf");//Fuente
            Texto = new Text("Bienvenido al menu",fuente);
            Texto.FillColor=Color.Red;
            Texto.Style = Text.Styles.Bold|Text.Styles.StrikeThrough;
            Texto.Position=new Vector2f(105f,105f);
            Texto.Scale = new Vector2f(2f,2f);
        }
    }
}

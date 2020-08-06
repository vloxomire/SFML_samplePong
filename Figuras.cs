using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace SFML_sample
{
    class Figuras
    {
        public CircleShape Circulo;
        public RectangleShape Rectangulo;
        public FloatRect ColisionCirculo;
        public FloatRect ColisionRectangulo;
        Texture circuloTextura,barraTexture;
        public Figuras() 
        {
            Circulo = new CircleShape(30);
            //Textura
            //circuloTextura = new Texture("Texture\\WoodChips.PNG");
            //Circulo.Texture = circuloTextura;
            Circulo.FillColor = Color.Red;
            Circulo.Position = new Vector2f(0f, 0f);
            Circulo.OutlineThickness = 10f;
            Circulo.OutlineColor = Color.Green;
            //Colision
            ColisionCirculo = new FloatRect();
            //ColisionCirculo = Circulo.GetGlobalBounds();
            
            //RECTANGULO
            Rectangulo = new RectangleShape(new Vector2f(150, 30));
            //Rectangulo.FillColor = Color.Blue;
            Rectangulo.Position = new Vector2f(200, 550);//x/y 500bajo
            Rectangulo.Origin = new Vector2f(75.0f, 15.0f);//Punto de pivote(giro), la mitad del objeto
            ColisionRectangulo = Rectangulo.GetLocalBounds();
            Rectangulo.OutlineThickness = 1f;
            //Textura barra
            barraTexture = new Texture("Texture\\MetalBeams.JPG");
            Rectangulo.Texture = barraTexture;
        }
    }
}

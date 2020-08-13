using SFML.Audio;
using SFML.System;
using System;

namespace SFML_sample
{
    static class Sonido
    {
        public static void PlaySonido() 
        {
            var buffer = new SoundBuffer("musica/canario.wav");
            var sonido = new Sound(buffer);
            sonido.Play();
        }
        public static void PlayMusica() 
        {
            var musica = new Music("music/orquesta.ogg");
            musica.Play();
        }
    }
}

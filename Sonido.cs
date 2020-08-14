using SFML.Audio;
using SFML.System;
using System;

namespace SFML_sample
{
    public static String[] ubicacion = new String[] { "sfx/canario.wav", "sfx/clash.wav" };
    static class Sonido
    {
        public static void PlaySonido(String ubicacion)
        {
            var buffer = new SoundBuffer(ubicacion);
            var sonido = new Sound(buffer);

            sonido.Play();
        }
        public static void PlayMusica() 
        {
            var musica = new Music("sfx/orquesta.ogg");
            musica.Play();
        }
    }
}

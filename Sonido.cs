using SFML.Audio;
using SFML.System;
using System;

namespace SFML_sample
{
    static class Sonido
    {
        public static String[] ubicacion = new String[] { "sfx/hit.wav", "sfx/clash.wav" };
        public static void PlaySonido(int x)
        {
            var buffer = new SoundBuffer(ubicacion[x]);
            var sonido = new Sound(buffer);
            sonido.Play();
        }
        public static Music PlayMusica() 
        {
            var musica = new Music("sfx/orquesta.ogg");
            musica.Volume = 5;
            musica.Play();
            return musica;
        }
        public static void PararMusica(Music m) 
        {
            m.Pause();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Configuracion
    {
        public static Color ColorMenuLateral;
        public static Color ColorEncabezadoVentana;
        public static Color ColorEncimaBotones;

        public static Color ColorBlack;
        public static Color ColorWhite;


        static Configuracion()
        {
            ColorMenuLateral = Color.FromArgb(6, 18, 27);
            ColorEncabezadoVentana = Color.FromArgb(4, 12, 18);
            ColorEncimaBotones = Color.FromArgb(139, 183, 240);

            ColorBlack = Color.Black;
            ColorWhite = Color.White;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CSDemoGDI
{
    class DemosVisualesGDI
    {
        Bitmap imagen;
        PictureBox pic;
        Font fuente;
        Graphics g;
        int numero;
        Point posTexto;
        public DemosVisualesGDI(PictureBox pantalla)
        {
            fuente = new Font("Courier New", 10);
            posTexto = new Point(10, 10);
            pic = pantalla;
            imagen = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(imagen);
            numero = 0;
        }
        public void mostrar()
        {
            pic.Image = imagen;
        }
        public void contar()
        {
            g.Clear(Color.Black);
            g.DrawString("El numero es: " + numero, fuente, Brushes.White, posTexto);
            numero++;
            if (numero > 1000)
            {
                numero = 0;
            }
            mostrar();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CSDemoGDI
{
    class DemosVisualesGDI
    {
        TextoVisual tVisual;
        Bitmap imagen;
        PictureBox pic;
        Font fuente;
        Graphics g;
        int numero;
        //Point posTexto;
        public DemosVisualesGDI(PictureBox pantalla)
        {
            fuente = new Font("Courier New", 10);
            //posTexto = new Point(10, 10);
            numero = 0;
            tVisual = new TextoVisual(10, 10, "El numero es: " + numero);
            pic = pantalla;
            imagen = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(imagen);
        }
        public void mostrar()
        {
            pic.Image = imagen;
        }
        public void contar()
        {
            g.Clear(Color.Black);
            //g.DrawString("El numero es: " + numero, fuente, Brushes.White, posTexto);
            tVisual.setTexto("El numero es: " + numero);
            tVisual.pintar(g, fuente, Brushes.White);
            numero++;
            if (numero > 1000)
            {
                numero = 0;
            }
            mostrar();
        }

    }
}

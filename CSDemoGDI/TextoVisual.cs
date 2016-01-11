using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace CSDemoGDI
{
    class TextoVisual
    {
        private Point _pos;
        private string _texto;
        public TextoVisual(int x, int y, string unTexto)
        {
            _pos = new Point(x, y);
            _texto = unTexto;
        }
        public void setTexto(string valor)
        {
            _texto = valor;
        }
        public string getTexto()
        {
            return _texto;
        }
        public void pintar(Graphics g,Font unaFuente,Brush unColor)
        {
            g.DrawString(_texto, unaFuente, unColor, _pos);
        }
    }
}

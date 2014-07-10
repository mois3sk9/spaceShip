using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
    class Nave
    {
        private Texture2D textura;
        public Vector2 pocision;

        public Nave(Texture2D textura)
        {
            this.textura = textura;
        }

        public void actualizar()
        { 
            
        }

        public void dibujar(SpriteBatch sb)
        {
            sb.Begin();
            sb.Draw(textura, pocision, Color.White);
            sb.End();
        }

    }
}

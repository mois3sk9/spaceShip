using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WindowsGame1
{
    class Pista
    {
        private Texture2D textura;
        public Vector2 pocision;

        public Vector2 Pocision
        {
            get { return pocision; }
            set { pocision = value; }
        }

        public Pista()
        { 
            
        }
        public Pista(Texture2D textura)
        {
            this.textura = textura;
        }
        public Pista(Texture2D textura, Vector2 pocision)
        {
            this.textura = textura;
            this.pocision = pocision;
        }

        public void dibujar(SpriteBatch sb)
        {
            sb.Begin();
            sb.Draw(textura,pocision,Color.White);
            sb.End();
        }
    }

    class PistasGroup
    {
        Texture2D textura = null;
        List<Pista> pistas = new List<Pista>();
        public int pocicionesPista = 165;
        public PistasGroup(Texture2D textura)
        {
            this.textura = textura;
            pistas.Add(new Pista(this.textura));
            pistas.Add(new Pista(this.textura));
            pistas.Add(new Pista(this.textura));
        }
        public void actualizar()
        {
            int i =1;
            foreach (Pista p in pistas)
            {
                
                p.pocision.X = pocicionesPista * i;
                p.pocision.Y = 0;
                i++;
            }
        }

        public void dibujar(SpriteBatch sb)
        {
            foreach (Pista p in pistas)
            {
                p.dibujar(sb);
            }
        }

        
    }
}

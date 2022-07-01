using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra_HW_05
{
    public class Color
    {
        private int r;
        public int R 
        {
            get { return r; }
            set { r = value; }
        }

        private int g;
        public int G 
        {
            get { return g; }
            set { g = value; }
        }

        private int b;
        public int B 
        {
            get { return b; }
            set { b = value; }
        }

        private int alpha;
        public int Alpha 
        {
            get { return alpha; }
            set { alpha = value; }
        }
        public Color(int r, int g, int b, int alpha = 255) 
        {
            R = r;
            G = g;  
            B = b;
            Alpha = alpha;
        }
        public int avgColor(int r, int g, int b) 
        {
            return ((r + g + b) / 3);
        }
    }
    public class Ball
    {
        public int size { get; set; }
        public Color cball { get; set; }
        private int numThrown = 0;

        public Ball(int size1, Color cball1)
        {
            size = size1;
            cball = cball1;
        }

        public void popped()
        {
            size = 0;
        }

        public void throwBall()
        {
            if (size != 0) 
            {
                numThrown++;
            }
        }

        public int timesThrown() 
        {
            return numThrown;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Calc
    {

        public int calculatD(int[,] equation)
        {

           return  (((equation[0, 0] * equation[1, 1] * equation[2, 2]) + (equation[0, 1] * equation[1, 2] * equation[2, 0]) + (equation[0, 2] * equation[1, 0] * equation[2, 1])) - (equation[2, 0] * equation[1, 1]*equation[0,2])-(equation[2,1] * equation[1,2] * equation[0,0])-(equation[2,2] * equation[1,0] * equation[0,1]));


        }


       public int calculateDx(int[,] equation)
        {
            return (((equation[0, 3] * equation[1, 1] * equation[2, 2]) + (equation[0, 1] * equation[1, 2] * equation[2, 3]) + (equation[0, 2] * equation[1, 3] * equation[2, 1])) - (equation[2, 3] * equation[1, 1] * equation[0, 2]) - (equation[2, 1] * equation[1, 2] * equation[0, 3]) - (equation[2, 2] * equation[1, 3] * equation[0, 1]));
        }
        public int calculateDy(int[,] equation)
        {
            return (((equation[0, 0] * equation[1, 3] * equation[2, 2]) + (equation[0, 3] * equation[1, 2] * equation[2, 0]) + (equation[0, 2] * equation[1, 0] * equation[2, 3])) - (equation[2, 0] * equation[1, 3] * equation[0, 2]) - (equation[2, 3] * equation[1, 2] * equation[0, 0]) - (equation[2, 2] * equation[1, 0] * equation[0, 3]));
        }

        public int calculateDz(int[,] equation)
        {
            return (((equation[0, 0] * equation[1, 1] * equation[2, 3]) + (equation[0, 1] * equation[1, 3] * equation[2, 0]) + (equation[0, 3] * equation[1, 0] * equation[2, 1])) - (equation[2, 0] * equation[1, 1] * equation[0, 3]) - (equation[2, 1] * equation[1, 3] * equation[0, 0]) - (equation[2, 3] * equation[1, 0] * equation[0, 1]));
        }



        public String xfinder(int deltax, int delta)
        {
            char signy = '+';
            char signd = '+';
            String result = "";
            char sign;
            int factor = 0;

            if (deltax < 0)
            {
                signy = '-';
                deltax = Math.Abs(deltax);
            }
            if (delta < 0)
            {
                signd = '-';
                delta = Math.Abs(delta);
            }
            if (signd == signy)
            {
                sign = '+';
            }
            else
                sign = '-';

            factor = gcd(deltax, delta);
            if (factor == delta)
            {

                result = String.Format("{0}{1}", sign == '+' ? ' ' : sign, deltax / factor);
            }

            else if (factor > 0 )
            {
                result = String.Format("{0}{1}/{2}", sign == '+' ? ' ' : sign, deltax / factor, delta / factor);
            }
            else 
            {
                result = String.Format("{0}{1}/{2}", sign == '+' ? ' ' : sign, deltax , delta);
            }
          

            return result;
        }

        public String yfinder(int deltay, int delta)
        {
            char signy = '+';
            char signd = '+';
            String result = "";
            char sign ;
            int factor = 0;

            if(deltay<0)
            {
                signy = '-';
                deltay = Math.Abs(deltay);
            }
            if(delta<0)
            {
                signd = '-';
                delta = Math.Abs(delta);
            }
            if (signd == signy)
            {
                sign = '+';
            }
            else
                sign = '-';
            factor = gcd(deltay, delta);
           if(factor==delta)
            {

                result = String.Format("{0}{1}", sign == '+' ? ' ' : sign, deltay / factor);
            }

           else if (factor > 0)
            {
                result = String.Format("{0}{1}/{2}", sign == '+' ? ' ': sign,deltay / factor, delta / factor);
            }
            else
            {
                result = String.Format("{0}{1}/{2}", sign == '+' ? ' ' : sign, deltay , delta);
            }
            
          

            return result;
        }

        public String zfinder(int deltaz, int delta)
        {
            char signy = '+';
            char signd = '+';
            String result = "";
            char sign;
            int factor = 0;

            if (deltaz < 0)
            {
                signy = '-';
                deltaz = Math.Abs(deltaz);
            }
            if (delta < 0)
            {
                signd = '-';
                delta = Math.Abs(delta);
            }
            if (signd == signy)
            {
                sign = '+';
            }
            else
                sign = '-';
            factor =gcd(deltaz, delta);
            if (factor == delta)
            {

                result = String.Format("{0}{1}", sign == '+' ? ' ' : sign, deltaz / factor);
            }

            else if (factor > 0 )
            {
                
                result = String.Format("{0}{1}/{2}", sign == '+' ? ' ' : sign, deltaz / factor, delta / factor);
            }
            else 
            {
                result = String.Format("{0}{1}/{2}", sign == '+' ? ' ' : sign, deltaz, delta);
            }
          

            return result;
        }

        public int gcd(int x,int y)
        {
            return (y == 0) ? x : gcd(y,x % y);
        }
       
    }
}

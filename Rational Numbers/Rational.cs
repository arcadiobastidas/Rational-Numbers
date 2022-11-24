using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Numbers
{
    public class Rational
    {
        //setting up properties for Rational Class
        private int numerator { get; set; }
        private int denominator { get; set; }

        //Initializing Defualt Constructor

        public Rational()
        {
            this.numerator = 0;
            this.denominator = 1; //Denominator default is 1 since dividing by 0 is undefined.
        }

        //Parameter Constructor
        public Rational(int numerator, int denominator)
        {
            int CommonDivisor = CalculateFractionReducer(numerator, denominator);

            this.numerator = numerator / CommonDivisor;
            this.denominator = denominator / CommonDivisor;

        }

       
        //recursive method to calculate minimun common divisor to reduce a fraction
        static int CalculateFractionReducer(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            return CalculateFractionReducer(denominator, numerator % denominator);

        }

       
        //Sum of rational numbers
        public Rational Sum(Rational obj)
        {
            return new Rational((numerator + obj.numerator), (denominator +obj.denominator));
        }

        //Substract Rational Numbes
        public Rational Substract(Rational obj)
        {
            return new Rational(numerator - obj.numerator, denominator - obj.denominator);
        }
        
        //Multiply Rational Numbers
        public Rational Multiply(Rational obj)
        {
            return new Rational(numerator * obj.numerator, denominator * obj.denominator); 
        }


        //Divider Rational Numbers
        public Rational Division(Rational obj)
        {
            int ReciprocalNumerator = obj.denominator;
            int ReciprocalDenominator = obj.numerator;

            return new Rational(numerator * ReciprocalNumerator, denominator * ReciprocalDenominator);
        }


        public override string ToString()
        {
            return string.Format("({0} / {1})", numerator, denominator);
        }


    }
}

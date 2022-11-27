namespace Rational_Numbers
{
    public class Rational
    {
        //setting up properties for Rational Class
        private int numerator { get; set; }

        //assignment as field for practice purposes
        private int denominator;

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
        private static int CalculateFractionReducer(int numerator, int denominator)
        {
            if (denominator == 0)
                return numerator;
            return CalculateFractionReducer(denominator, numerator % denominator);
        }

        //Sum of rational numbers
        public Rational Sum(Rational obj)
        {
            if (obj.denominator == denominator)
            {
                return new Rational((numerator + obj.numerator), (denominator));
            }

            //calculating values if denominators are not equal
            int commonDenominator = obj.denominator * this.denominator;
            int calculatedNumerator1 = obj.numerator * this.denominator;
            int calculatedNumerator2 = this.numerator * obj.denominator;

            return new Rational(calculatedNumerator1 + calculatedNumerator2, commonDenominator);
        }

        //Substract Rational Numbers
        public Rational Substract(Rational obj)
        {
            if (obj.denominator == denominator)
            {
                return new Rational((numerator - obj.numerator), (denominator));
            }

            //calculating values if denominators are not equal
            int commonDenominator = obj.denominator * this.denominator;
            int calculatedNumerator1 = this.numerator * obj.denominator;
            int calculatedNumerator2 = obj.numerator * this.denominator;

            return new Rational(calculatedNumerator1 - calculatedNumerator2, commonDenominator);
        }

        //Multiply Rational Numbers
        public Rational Multiply(Rational obj)
        {
            if (obj.denominator == 0 || denominator == 0)
            {
                throw new DivideByZeroException("Can't divide by 0");
            }
            else
            {
                return new Rational(numerator * obj.numerator, denominator * obj.denominator);
            }
        }

        //Divider Rational Numbers
        public Rational Division(Rational obj)
        {
            int ReciprocalNumerator = obj.denominator;
            int ReciprocalDenominator = obj.numerator;

            return new Rational(numerator * ReciprocalNumerator, denominator * ReciprocalDenominator);
        }

        //Display Result as floating point

        public float ResolveEquation(int precision)
        {
            float castedNumerator = numerator;
            float castedDenominator = denominator;
            float equationResult = castedNumerator / castedDenominator;
            Console.Write("Result after dividing: ");
            return ((float)Math.Round(equationResult, precision));
        }

        //Ask user for object information
        public void Ask()
        {
            try
            {
                Console.Write("Enter numerator =  ");
                numerator = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator =  ");
                denominator = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Numerator and denominator must be numbers!!\n");
                Ask();
            }
            finally
            {
                if (denominator == 0)
                {
                    Console.WriteLine("Denominator can't be 0!!\n");
                    Ask();
                }
            }
        }

        //format output
        public override string ToString()
        {
            return string.Format("({0} / {1})", numerator, denominator);
        }
    }
}
// https://www.dotnetperls.com/divide - Used to figure out why my division was returning 0.

public class Fraction
{
        private int _imNumerator;
        private int _imDenominator;
        public Fraction()
        {
            _imNumerator = 1;
            _imDenominator =1;
        }
        public Fraction(int tempInt)
        {
            _imNumerator = tempInt;
            _imDenominator = 1;
        }
        public Fraction(int tempIntOne, int tempIntTwo)
        {
            _imNumerator = tempIntOne;
            _imDenominator = tempIntTwo;
        }

        public string toString()
        {
            return _imNumerator + "/" + _imDenominator;
        }

        public float toValue()
        {
            return (float)_imNumerator / _imDenominator;
        }


}
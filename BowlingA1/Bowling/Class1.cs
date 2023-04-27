namespace Bowling
{
    public class Class1
    {
        public int Foo()
        {
            return 0;
        }
    }

    public enum PreviousShot { normal, spare, strike }

    public class Round
    {
        public int FirstShot, SecondShot, Total;

        public PreviousShot previousShot;
        public int CalculateScore()
        {
            if (previousShot == PreviousShot.strike)
            {
                return 2 * FirstShot + 2 * SecondShot;
            }
            if (previousShot == PreviousShot.spare)
            {
                return FirstShot * 2 + SecondShot;
            }
            return Total = FirstShot + SecondShot;
        }
    }
}
namespace Bowling.Tests
{
    public class UnitTest1
    {
        /*
         * Round
         *  FirstShot
         *  SecondShot
         *  
         *  TotalScore
         *  
         *  CalculateScore(previousRound)
         *  
         *  enum shotType: normal, spare, strike
         *  
         *  
         */
        
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(0,1,1)]
        [InlineData(9,1,10)]
        public void CalculateScore_NormalScore_NoModifiersApplied(int firstShot, int secondShot, int total)
        {
            Round round = new Round
            {
                FirstShot = firstShot,
                SecondShot = secondShot
            };

            round.CalculateScore().Should().Be(total);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(2, 0, 4)]
        [InlineData(9, 1, 19)]
        public void CalculateScore_Spare_FirstShotModifierApplied(int firstShot, int secondShot, int total)
        {
            Round round = new Round
            {
                FirstShot = firstShot,
                SecondShot = secondShot,
                previousShot = PreviousShot.spare
            };

            round.CalculateScore().Should().Be(total);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 2)]
        [InlineData(2, 0, 4)]
        [InlineData(9, 1, 20)]
        public void CalculateScore_Strike_BothShotsDoubled(int firstShot, int secondShot, int total)
        {
            Round round = new Round
            {
                FirstShot = firstShot,
                SecondShot = secondShot,
                previousShot = PreviousShot.strike
            };

            round.CalculateScore().Should().Be(total);
        }
    }
}
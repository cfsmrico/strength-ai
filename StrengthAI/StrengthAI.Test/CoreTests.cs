using StrengthAI.Core;
using static StrengthAI.Core.TDEE;

namespace StrengthAI.Test
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void One()
        {
            var input = new InputSet
            {
                Age = 42,
                ActivityLevel = ActivityLevel.ModeratelyActive,
                BodyWeight = 200,
                HeightInCentimeters = 181,
                BodyFatPercentage = 14
            };

            var output = TDEE.GetEstimate(input);
            Assert.IsTrue(output == 3802);
        }

        public void Two()
        {
            var input = new InputSet
            {
                Age = 42,
                ActivityLevel = ActivityLevel.ModeratelyActive,
                BodyWeight = 188,
                HeightInCentimeters = 181,
                BodyFatPercentage = 12
            };

            var output = TDEE.GetEstimate(input);
            Assert.IsTrue(output == 3683);
        }

        public void Three()
        {
            var input = new InputSet
            {
                Age = 43,
                ActivityLevel = ActivityLevel.Average,
                BodyWeight = 200,
                HeightInCentimeters = 181,
                BodyFatPercentage = 15
            };

            var output = TDEE.GetEstimate(input);
            Assert.IsTrue(output == 3257);
        }
    }
}
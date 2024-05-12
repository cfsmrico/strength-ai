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
    }
}
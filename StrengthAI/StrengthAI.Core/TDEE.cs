
namespace StrengthAI.Core
{
    public class TDEE
    {
        public enum Unit
        {
            Imperial = 0,
            Metric = 1
        }

        public enum Sex
        {
            Male = 0,
            Female = 1
        }

        public enum ActivityLevel
        {
            ExtremelyInactive = 0,
            Sedentary = 1,
            Average = 2,
            ModeratelyActive = 3,
            VigorouslyActive = 4,
            ExtremelyActive = 5
        }

        public class InputSet
        {
            public Unit Unit { get; set; }

            public Sex Sex {  get; set; }
            
            public ushort Age { get; set; }

            public ActivityLevel ActivityLevel {  get; set; }

            public double BodyWeight { get; set; }

            public double HeightInCentimeters { get; set; }

            public ushort BodyFatPercentage { get; set; }
        }

        public static ushort GetEstimate(InputSet inputSet)
        {
            if (inputSet is null)
            {
                throw new ArgumentNullException(nameof(inputSet));
            }

            return 2500;
        }
    }
}

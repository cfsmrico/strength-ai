
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

        public static double GetEstimate(InputSet inputSet)
        {
            if (inputSet is null)
            {
                throw new ArgumentNullException(nameof(inputSet));
            }

            if (inputSet.Unit == Unit.Imperial)
            {
                inputSet.BodyWeight = inputSet.BodyWeight / 2.205;
                inputSet.Unit = Unit.Metric;
            }

            double estimate;

            if (inputSet.Sex.Equals(Sex.Male))
            {
                estimate = 88.362 + (13.397 * inputSet.BodyWeight) + (4.799 * inputSet.HeightInCentimeters) - (5.677 * inputSet.Age);
            }
            else
            {
                estimate = 447.593 + (9.247 * inputSet.BodyWeight) + (3.098 * inputSet.HeightInCentimeters) - (4.33 * inputSet.Age);
            }

            return estimate;
        }
    }
}

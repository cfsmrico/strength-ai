namespace StrengthAI.Core.Calculators
{
    /// <summary>
    /// Basal Metabolic Rate Calculator
    /// </summary>
    public interface IBasalMetabolicRate
    {
        public class BMRInputSet
        {
            public enum Sex
            {
                Male = 0,
                Female = 1
            }

            public class InputSet
            {
                public Sex Sex { get; set; }

                public double AgeInYears { get; set; }

                public double BodyWeightInKilograms { get; set; }

                public double HeightInCentimeters { get; set; }

                public double BodyFatPercentage { get; set; }
            }
        }
    }
}

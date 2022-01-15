using System;

namespace NeuralNetwork
{
    public class Constants
    {
        private const double ExpectedResult = 1;
        private const double E = 0.7; // learning speed
        private const double A = 0.3; // moment
        public static readonly Random rand = new();

        public static double GetOutputDelta(double actual)
        {
            return (ExpectedResult - actual) * ((ExpectedResult - actual) * actual);
        }

        public static double GetHiddenDelta(double actual, double weight, double beforeDelta)
        {
            return ((1 - actual) * actual) * (weight * beforeDelta);
        }

        public static double GetGradient(double actual, double prevDelta)
        {
            return actual * prevDelta;
        }

        public static double GetNewWeight(double weight, double gradient, double prevDelta)
        {
            return weight + (E * gradient + prevDelta * A);
        }
    }
}
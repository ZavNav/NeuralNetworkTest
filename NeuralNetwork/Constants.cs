namespace NeuralNetwork
{
    public class Constants
    {
        public static double result = 1;
        public static double E = 0.7; // learning speed
        public static double A = 0.3; // moment

        public static double OutputDelta(double expected, double actual)
        {
            return (expected - actual) * ((expected - actual) * actual);
        }

        // public static double HiddenDelta()
        // {
        //     
        // }
    }
}
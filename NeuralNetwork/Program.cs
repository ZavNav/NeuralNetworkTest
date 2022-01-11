using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //var firstNum = decimal.Parse(Console.ReadLine());
            //var secondNum = decimal.Parse(Console.ReadLine());

            var network = new Network(1, 1, 0);

            const int expectedResult = 1;
            var results = new List<double>();

            for (var i = 0; i < 5; i++)
            {
                results.Add(network.StartNetwork());
                var mse = GetMse(expectedResult, results.ToArray());//mean squared error
                Console.WriteLine($"Result: {results.Last()}, MSE: {mse}");
            }
            Console.WriteLine(network.StartNetwork());
        }

        private static double GetMse(double expectedResult, params double[] results)
        {
            var sum = results.Sum(result => Math.Pow(expectedResult - result, 2));
            return sum / results.Length;
        }
    }
}
using System;
// add activation function to neuron
namespace NeuralNetwork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //var firstNum = decimal.Parse(Console.ReadLine());
            //var secondNum = decimal.Parse(Console.ReadLine());

            var network = new Network(1, 1, 0);
            Console.WriteLine(network.StartNetwork());
        }
    }
}
using System.Collections.Generic;

namespace NeuralNetwork
{
    public enum NeuronType
    {
        input,
        hidden,
        output
    }
    public class Neuron
    {
        private NeuronType NeuronType;
        
        public List<double> inputs { get; set; }
        private double output { get; set; }
        private readonly double weight;

        public Neuron(double weight, NeuronType neuronType = NeuronType.hidden)
        {
            NeuronType = neuronType;
            this.weight = weight;
        }
        
        public double ActivateNeuron()
        {
            foreach (var input in inputs)
            {
                output += input * weight;
            }

            return output;
        }
    }
}
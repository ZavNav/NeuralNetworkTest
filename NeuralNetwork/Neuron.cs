using System;
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
        private List<double> weights;
        //private double weight;
        private double prevDelta = 0;
        private double beforeDelta = 0;

        public Neuron(NeuronType neuronType = NeuronType.hidden)
        {
            NeuronType = neuronType;
            //this.weight = weight;
        }

        public void InitiateWeights(int weightsCount)
        {
            weights = new();
            for (var i = 0; i < weightsCount; i++)
            {
                weights.Add(Constants.rand.NextDouble());
            }
        }
        public double ActivateNeuron()
        {
            foreach (var input in inputs)
            {
                output += 1 / (1 + Math.Pow(Math.E, -(input * weight)));
            }
            return output;
        }

        public double Backpropagation()
        {
            var delta = NeuronType == NeuronType.output 
                ? Constants.GetOutputDelta(output) 
                : Constants.GetHiddenDelta(output, weight, beforeDelta);
            prevDelta = delta;
            
            if (NeuronType != NeuronType.output)
            {
                List<double> gradients = new();
                foreach (var weight in weights)
                {
                    gradients.Add(Constants.GetGradient(output, beforeDelta));
                }

                weights = new();
                foreach (var gradient in gradients)
                {
                    weights.Add(Constants.GetNewWeight(weight, gradient, prevDelta));
                }
                //var gradient = Constants.GetGradient(output, beforeDelta);
                //weight = Constants.GetNewWeight(weight, gradient, prevDelta);
            }
            
            return delta;
        }
    }
}
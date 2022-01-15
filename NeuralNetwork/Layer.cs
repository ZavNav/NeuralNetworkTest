using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    
    public class Layer
    {
        public readonly List<Neuron> Neurons = new();
        private readonly List<double> Outputs = new();
        public List<double> Inputs = new();

        public readonly bool isInput = false;
        
        
        public Layer(int neuronsCount, NeuronType layerType = NeuronType.hidden, params double[] inputs)
        {
            for (var i = 0; i < neuronsCount; i++)
            {
                Neurons.Add(new Neuron(layerType));
            }

            if (layerType != NeuronType.input) return;
            isInput = true;
            Inputs = inputs.ToList();
            // foreach (var neuron in Neurons)
            // {
            //     neuron.inputs = inputs.ToList();
            // }
        }

        public void InitiateWeights(int weightsCount)
        {
            foreach (var neuron in Neurons)
            {
                neuron.InitiateWeights(weightsCount);
            }
        }
        public List<double> StartLayerWork()
        {
            foreach (var neuron in Neurons)
            {
                neuron.inputs = Inputs;
                Outputs.Add(neuron.ActivateNeuron());
            }

            return Outputs;
        }
    }
}
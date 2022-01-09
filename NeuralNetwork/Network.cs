using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Network
    {
        private readonly List<Layer> Layers = new();

        public Network(int hiddenLayersCount, params double[] inputs)
        {
            Layers.Add(new Layer(inputs.Length, NeuronType.input, inputs));
            Layers.Add(new Layer(hiddenLayersCount));
            Layers.Add(new Layer(1, NeuronType.output));
        }

        public double StartNetwork()
        {
            var outputs = new List<double>();
            foreach (var layer in Layers)
            {
                if (!layer.isInput) layer.Inputs = outputs;
                outputs = layer.StartLayerWork();
            }

            return outputs[0];
        }
    }
}
namespace HopfieldNetwork2
{
    public class Network
    {        
        Neuron[] nrn = new Neuron[9];
        public int[] output = new int[9];
        public Network(int[] n1, int[] n2, int[] n3, int[] n4, int[] n5, int[] n6, int[] n7, int[] n8, int[] n9)
        {
            nrn[0] = new Neuron(n1);
            nrn[1] = new Neuron(n2);
            nrn[2] = new Neuron(n3);
            nrn[3] = new Neuron(n4);
            nrn[4] = new Neuron(n5);
            nrn[5] = new Neuron(n6);
            nrn[6] = new Neuron(n7);
            nrn[7] = new Neuron(n8);
            nrn[8] = new Neuron(n9);
        }
        
        public int Threshold(int n)
        {
            if (n >= 0)
                return 1;
            else
                return -1;
        }
        
        public void Activation(int[] pattern)
        {
            for (int i = 0; i < 9; i++)
            {             
                nrn[i].activation = nrn[i].Act(9, pattern);
                output[i] = Threshold(nrn[i].activation);
            }
        }        
    }
}

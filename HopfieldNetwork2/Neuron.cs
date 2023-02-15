using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNetwork2
{
    public class Neuron
    {
        public int activation;
        public int[] weight = new int[9];

        public Neuron(){ }
        
        public Neuron(int[] j)
        {
            for (int i = 0; i < j.Length; i++)
            {
                this.weight[i] = j[i] + i;
            }
        }

        public int Act(int m, int[] x) 
        {
            int a = 0;

            for (int i = 0; i < m; i++)
            {
                a += x[i] * weight[i];
            }
            
            return a;
        }
    }
}

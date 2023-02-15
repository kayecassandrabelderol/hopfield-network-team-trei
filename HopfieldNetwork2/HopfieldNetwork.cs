using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldNetwork2
{
    public class HopfieldNetwork
    {
        Network h1;
        int[] input = new int[9];
        int[] plus = new int[9] { -1, 1, -1, 1, 1, 1, -1, 1, -1 };
        int[] minus = new int[9] {-1, -1, -1, 1, 1, 1, -1, -1, -1 };
        int[] wt1 = { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
        int[] wt2 = { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
        int[] wt3 = { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
        int[] wt4 = { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
        int[] wt5 = { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
        int[] wt6 = { 2, 0, -2, 2, 2, 0, -2, 2, -2 };
        int[] wt7 = { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
        int[] wt8 = { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
        int[] wt9 = { 2, 0, 2, -2, -2, -2, 2, 0, 0 };


        public HopfieldNetwork(int[] input)
        {
            for(int i = 0; i< 9; i++)
            {
                this.input[i] = input[i];
            }
            
            h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);
        }

        public int CheckPattern()
        {
            h1.Activation(input);
            int n = 0;
            int p = 0;
            for (int i = 0; i < 9; i++) 
            {
                if (h1.output[i] == plus[i])
                    p++;

                else if (h1.output[i] == minus[i])
                    n++;
            }

            if (p > n)
                return 1;

            else if (p < 2 || n < 2)
                return 2;

            else
                return 0;
        }
    }
}

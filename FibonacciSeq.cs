using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Antra_HW_05
{
    public class FibonacciSeq
    {
        public static int[] fib(int len, [Optional] List<int> seq) 
        {
            if (seq is null)
            {
                seq = new List<int>();
                seq.Add(1);
                seq.Add(1);
                return fib(len - 2, seq);
            }
            else 
            {
                if (len == 0)
                {
                    int[] fibseq = new int[seq.Count];
                    for (int i = 0; i < seq.Count; i++)
                    {
                        fibseq[i] = seq[i];
                    }
                    return fibseq;
                }
                else 
                {
                    seq.Add(seq[seq.Count - 1] + seq[seq.Count - 2]);
                    return fib(len - 1, seq);
                }
            }
        }
        public static int fibLoc(int index) 
        {
            int[] fibseq = fib(index);
            return fibseq[index-1];
        }
    }
}

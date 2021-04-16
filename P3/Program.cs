using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Thread[] thread = new Thread[n];
            test ob = new test();
            for (int i=0; i<n; i++)
            {
                //thread[i] = new Thread(ob.Welcome);
                var tmp = i;
                thread[i] = new Thread(()=>ob.set(tmp));
                thread[i].Name = String.Format("Thread: {0}", i + 1);
            }
            foreach(var t in thread)
            {
                t.Start();
            }
            foreach(var t in thread)
            {
                t.Join();
            }
            foreach(int x in ob.array)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
        public class test
        {
            public double[] array = new double[10];
            public void set(int idx)
            {
                Thread.Sleep(500);
                double x = Math.Pow(idx + 1, 2.0f);
                array[idx] = x;
            }
            public void Welcome()
            {
                lock (this)
                {
                    Console.WriteLine("Sup\t" + Thread.CurrentThread.Name);
                    for (int i = 0; i < 10; i++)
                        Console.Write(i + 1 + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}

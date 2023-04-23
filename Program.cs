using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = Encoding.UTF8;           
            StopWatch time = new StopWatch();
            time.Start();        
            Selectionsort();            
            time.Stop();
            double Elapsed= time.GetElapsedTime();
            Console.WriteLine("Thời gian thực thi thuật toán sắp xếp chọn: " + Elapsed.ToString("0") + "ms");
            Console.ReadLine();           
        }
        static void Selectionsort()
        {
            Random rand = new Random();
            int[] List = new int[100000];
            for(int i = 0; i < List.Length; i++)
            {
                List[i] = rand.Next();
            }
            for (int i = 0; i < List.Length - 1 - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < List.Length; j++)
                {
                    if (List[j] < List[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = List[i];
                List[i] = List[minIndex];
                List[minIndex] = temp;
            }            
        }       
    }
}

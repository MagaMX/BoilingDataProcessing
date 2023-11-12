using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilingDataProcessingWF
{
    internal class Solver
    {
        #region PRIVATE

        private List<string> voltage = new List<string>(), protocol_time = new List<string>(), excel_time = new List<string>();
        private List<double> dT = new List<double>(), q = new List<double>();
        private int N;

        #endregion

        #region PUBLIC
        public Solver(){}

        public Solver(List<string> voltage, List<string> protocol_time, List<string> excel_time, List<double> dT, List<double> q, int N)
        {
            setData(voltage, protocol_time, excel_time, dT, q, N);
        }

        // return dT_out, q_out
        public (List<double>, List<double>) Solve()
        {
            List<int> index = new();

            for (int i = 0; i < protocol_time.Count; i++)
            {
                for (int j = 0; j < excel_time.Count; j++)
                {
                    if (protocol_time[i] == excel_time[j])
                    {
                        index.Add(j);
                        break;
                    }
                }
            }
            index.RemoveAt(0);//Удаляем первое значение индекса, значение теплового потока для 1 времени начинаем высчитывать со 2 значения времени

            //Поиск максимального значения КТП перед кризисом
            index.Add(q.IndexOf(q.Max()));

            //int N = 30; //Осреднение по 30-ти точкам (30 секунд)
            List<double> dT_out = new();
            List<double> q_out = new();

            foreach (int elem in index)
            {
                double mean_dT = 0;
                double mean_q = 0;
                for (int i = elem; i > (elem - N); i--)
                {
                    mean_dT += dT[i];
                    mean_q += q[i];
                }
                dT_out.Add(Math.Round(mean_dT / N, 2));
                q_out.Add(Math.Round(mean_q / N, 0));
            }
            return (dT_out, q_out);
        }

        public void setData(List<string> voltage, List<string> protocol_time, List<string> excel_time, List<double> dT, List<double> q, int N)
        {
            this.voltage = voltage;
            this.protocol_time = protocol_time;
            this.excel_time = excel_time;
            this.dT = dT;
            this.q = q;
            this.N = N;
        }

        #endregion
    }
}

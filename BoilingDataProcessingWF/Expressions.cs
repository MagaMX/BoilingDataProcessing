using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilingDataProcessingWF
{
    internal class Expressions
    {
        #region PRIVATE

        List<double> yagov_curve_res;
        double yagov_chf_res, kutateldze_chf_res;

        #endregion

        #region PUBLIC

        double[] lyambda = new[] {0.06178972, 0.057285861, 0.054392757, 0.052289392, 0.050391281};
        double[] t_sat = new[] {61.0, 84.04, 98.84, 109.6, 119.31};
        double[] nu = new[] {3.06 * 10E-7, 2.39*10E-7, 2.11*10E-7, 1.91*10E-7, 1.78 * 10E-7};
        double[] mu = new[] { 0.000434979, 0.000322079, 0.000277258, 0.000246316, 0.000225629 };
        double[] sigma = new[] {10.06 * 10E-3, 7.82 * 10E-3, 6.55 * 10E-3, 5.9 * 10E-3, 5.4 * 10E-3};
        double[] r = new[] {112000.0, 106244.0, 100488.0, 94800.0, 89000.0};
        double[] rho_vapour = new[] {9.4, 19.3, 28.74, 38.4, 48.0};
        double[] rho_liquid = new[] {1421.5, 1347.61, 1314.02, 1289.61, 1267.58};
        double g = 9.8;
        
        public void YagovCurve(int pressure)
        {
            int[] delta_T = new int[30];
            double[] result = new double[30];

            double B = (r[pressure] / sigma[pressure]) * Math.Pow((Math.Pow(nu[pressure] * rho_vapour[pressure], 3)) / (lyambda[pressure] * t_sat[pressure]), 0.5);

            for (int i = 0; i < 30; i++)
            {
                delta_T[i] = i + 1;
                result[i] = (3.43 * 10E-4) * ((Math.Pow(lyambda[pressure], 2) * Math.Pow(delta_T[i], 3)) / (nu[pressure] * sigma[pressure] * t_sat[pressure])) * (1 + Math.Sqrt(1 + 800 * B) + 400 * B);
                yagov_curve_res.Add(result[i]);
            }
        }

        public double YagovCHF(int pressure)
        {
            kutateldze_chf_res = 0.14 * r[pressure] * Math.Sqrt(rho_vapour[pressure]) * Math.Pow(sigma[pressure] * g * (rho_liquid[pressure] - rho_vapour[pressure]), 0.25);
            return kutateldze_chf_res;
        }

        public double KutateladzeCHF(int pressure)
        {
            yagov_chf_res = 0.06 * Math.Pow(rho_vapour[pressure], 0.6) * Math.Pow(sigma[pressure], 0.6) * Math.Pow((g  * (rho_liquid[pressure] - rho_vapour[pressure])) / mu[pressure], 0.2);
            return yagov_chf_res;
        }
        int debil = 0;
        #endregion
    }
}

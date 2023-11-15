using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AvaevaPD.Sprint4.TaskReview.V18.Lib
{
    public class DataService : ISprint4Task7V18
    {
        public int Calculate(int n, int m, string value)
        {
			int[,] mtrx = new int[n, m];

			int index = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
				}
			}

			int count = 1;
			for (int i = 0; i < n; ++i)
			{
				for (int j = 0; j < m; ++j)
				{
					if (mtrx[i, j] % 2 == 0)
					{
						count *= mtrx[i, j];
					}
				}
			}
			return count;
		}
    }
}

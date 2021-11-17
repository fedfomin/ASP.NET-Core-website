using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Utility
{
    public class PaginationUtility
    {
        public static List<int> PaginationArray(int actualPage, int maxPage)
        {
            if (maxPage < 13)
            {
                return Enumerable.Range(0, 13).ToList();
            }
            else if (actualPage + 2 <= 8)
            {
                List<int> arr1 = Enumerable.Range(0, 9).ToList();
                List<int> arr2 = Enumerable.Range(maxPage - 2, 3).ToList();
                arr1.Add(-1);
                arr1 = arr1.Concat(arr2).ToList();
                return arr1;
            }
            else if (actualPage - 2 >= maxPage - 8)
            {
                List<int> arr1 = Enumerable.Range(0, 3).ToList();
                List<int> arr2 = Enumerable.Range(maxPage - 8, 9).ToList();
                arr1.Add(-1);
                arr1 = arr1.Concat(arr2).ToList();
                return arr1;
            }
            else
            {
                List<int> arr1 = Enumerable.Range(0, 3).ToList();
                List<int> arr2 = Enumerable.Range(actualPage - 2, 5).ToList();
                List<int> arr3 = Enumerable.Range(maxPage - 2, 3).ToList();
                arr1.Add(actualPage - 2 == 4 ? 4 : -1);
                arr2.Add(actualPage + 4 == maxPage - 2 ? maxPage - 1 : -1);
                arr1 = arr1.Concat(arr2).ToList();
                arr1 = arr1.Concat(arr3).ToList();
                return arr1;
            }
        }
    }
}

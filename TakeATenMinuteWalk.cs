using System.Collections.Generic;
using System.Linq;
using System;
//[2, 4, 0, 100, 4, 11, 2602, 36]
//Should return: 11 (the only odd number)

//[160, 3, 1719, 19, 11, 13, -21]
//Should return: 160 (the only even number)
public class Kata
{
    public static int Find(int[] integers)
    {
        //int even = 0;
        //int odd = 0;
        //int lastNumber;
        //foreach (var integer in integers)
        //{
        //    lastNumber = integer;
        //    check = integer % 2 == 0;
        //    switch (integer % 2)
        //    {
        //        case 0:
        //            even++;
        //            break;
        //        default:
        //            odd++;
        //            break;
        //    }
        //}
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();
        foreach (var integer in integers)
        {
            (integer % 2 == 0) ? evens.Add(integer) : odds.Add(integer);
            if (evens.Count > odds.Count && odds.Count == 1) return odds.First();
            if (odds.Count > evens.Count && evens.Count == 1) return evens.First();
        }
    }
}
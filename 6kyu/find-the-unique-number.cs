/*
    There is an array with some numbers. All numbers are equal except for one. Try to find it!

    findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
    findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
    It’s guaranteed that array contains at least 3 numbers.

    The tests contain some very huge arrays, so think about performance.

*/

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    List<int> numberResult = numbers.ToList();
    
    numberResult.Sort();
    
    return (numberResult[0] < numberResult[1]) ?numberResult[0] : numberResult[numberResult.Count - 1] ;
    
  }
}
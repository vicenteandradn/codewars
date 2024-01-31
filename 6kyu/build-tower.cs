/*
    Build Tower
    Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

    For example, a tower with 3 floors looks like this:
*/

using System;
using System.Collections.Generic;

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    List<string> tower = new List<string>(nFloors);

    for(var i = 1; i <= nFloors; i++)
    {
        var star = new string('*', (i * 2 - 1));
        var space = new string(' ', nFloors - i);
        tower.Add($"{space}{star}{space}");
    }
    
    return tower.ToArray();
  }
}
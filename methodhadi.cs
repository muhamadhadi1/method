using System;

namespace dedemethod
{
  public class Numbers
  {
    public int FindMinimum(int number1, int number2)
    {
      int min;
      if (number1 < number2)
      {
          min = number1;
      }
      else
      {
        min = number2;
      }
      return min;
    }
    public int FindMinimum(int number1, int number2, int number3)
    {
      int min;
      if (number1 < number2)
      {
        min = number1;
      }
      else
      {
        min = number2;
      }
      if (min < number3)
      {
        min = min;
      }
      else
      {
        min = number3;
      }

      return min;
    }
    public int FindMaximum(int number1, int number2)
    {
      int max;
      if (number1 > number2)
      {
        max = number1;
      }
      else
      {
        max = number2;
      }
      return max;
    }
    public int FindMaximum(int number1, int number2, int number3)
    {
      int max;
      if (number1 > number2)
      {
        max = number1;
      }
      else
      {
        max = number2;
      }
      if (max > number3)
      {
        max = max;
      }
      else
      {
        max = number3;
      }
      return max;
    }
  }

  class program
  {
    static void Main(string[] args)
    {
      Numbers number = new Numbers();

      Console.WriteLine("Minimum #1 : {0}", number.FindMinimum(3,1));
      Console.WriteLine("Minimum #2 : {0}", number.FindMinimum(3,2,4));
      Console.WriteLine();
      Console.WriteLine("Maximum #1 : {0}", number.FindMaximum(3,1));
      Console.WriteLine("Maximum #2 : {0}", number.FindMaximum(3,2,4));

      Console.ReadKey();
    }
  }
}

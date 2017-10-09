using System;

class Numbers
{
  static void Main()
  {
    Console.WriteLine("Insert a number");
    string stringNum1 = Console.ReadLine();

    int yourNum = int.Parse(stringNum1);

    if (yourNum >= 0)
    {
      int yourNumAdd = yourNum + 1;
      Console.WriteLine("your No." + yourNumAdd);
    }
    else
    {
      int yourNumMinus = yourNum - 1;
      Console.WriteLine("your No." + yourNumMinus);

    }
  }
}

using System;

public class Program {

  public static void Main(string[] args) {
    string A = Console.ReadLine();
    string B = Console.ReadLine();
    double a = double.Parse(A);
    double b = double.Parse(B);

    double m = (a * 3.5 + b * 7.5) / 11;

    Console.WriteLine ($"MÉDIA = {m:0.00000}");
  }
}
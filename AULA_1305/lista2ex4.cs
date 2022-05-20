using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a base e a altura do retângulo");
     string b = Console.ReadLine();
     string a = Console.ReadLine();
     double b1 = double.Parse(b);
     double a1 = double.Parse(a);

    double ar = b1 * a1;
    
    Console.WriteLine($"Área = {ar:0.00}");

    double pe = 2 * (b1 + a1);
    
    Console.WriteLine($"Perímetro = {pe:0.00}");

    double di = ((b1 * b1) + (a1 * a1)) / 5;

    Console.WriteLine($"Diagonal = {di:0.00}");  
  }
}
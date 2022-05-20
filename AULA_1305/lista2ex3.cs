using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    string a = Console.ReadLine();
    int p = int.Parse(a);

    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    string b = Console.ReadLine();    
    int s = int.Parse(b);
    
    int m = (p * 2 + s * 3) / 5;
    
    Console.WriteLine("Média parcial = " + m);
  }
}
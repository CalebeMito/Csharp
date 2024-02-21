    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int total = 0, gradeCounter = 0, gradeValue;

        Console.WriteLine("Digite uma nota ou -1 para sair: ");
        gradeValue = int.Parse(Console.ReadLine());

        while (gradeValue != -1)
        {
            total += gradeValue;
            gradeCounter++;
            Console.WriteLine("Digite a próxima nota ou -1 para sair:");
            gradeValue = int.Parse(Console.ReadLine());
        }

        if (gradeCounter != 0)
        {
            double average = (double)total / gradeCounter;
            Console.WriteLine("A média da classe: {0}", average);
        }
    }
}

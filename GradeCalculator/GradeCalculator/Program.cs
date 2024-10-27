using System;

namespace GradeCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Findal grade calculator");
            Console.WriteLine("Current grade?");
            int grade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What grade would you like in the class? ");
            int desiredGrade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Final Exam Weight? ");
            float weight = float.Parse(Console.ReadLine())/100;

            float score = finalFormula(desiredGrade, weight, grade);
            Console.WriteLine("You need a grade of {0}",score);
        }

        public static float finalFormula(int target, float weight, int current){
            return (target - ((1 - weight) * current)) / weight;
        }

        
    }
}

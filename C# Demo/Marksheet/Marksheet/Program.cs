namespace Marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".............Marksheet in C#.................\n\n");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your enrollment number: ");
            string enroll = Console.ReadLine();

            Console.WriteLine("Enter standard in which you study: ");
            string std = Console.ReadLine();

            Console.WriteLine("Enter Maths marks (0-100): ");
            int maths = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Physics marks (0-100): ");
            int phy = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Chemistry marks (0-100): ");
            int chem = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter English marks (0-100): ");
            int eng = int.Parse(Console.ReadLine());

            int obtainMarks = maths + phy + chem + eng;

            Console.WriteLine("Obtain marks from 400 is: {0}",obtainMarks);

            float percentage = obtainMarks / 4f;

            Console.WriteLine("Percentage : {0}",percentage);

            if(percentage >= 80) {
                Console.WriteLine("Distinction Grade");
            }
            else if(percentage >= 70)
            {
                Console.WriteLine("A Grade");
            }
            else if(percentage >= 60)
            {
                Console.WriteLine("B Grade");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("C Grade");
            }
            else if(percentage >= 40)
            {
                Console.WriteLine("D Grade");
            }
            else
            {
                Console.WriteLine("You fail ..... Need Improvement!!");
            }

            if(percentage > 33) {
                Console.WriteLine("Congratulations .... You have passed the exam!!!😍😍");
            }

            Console.WriteLine("\n\n.............Vd's University.................");
        }
    }
}
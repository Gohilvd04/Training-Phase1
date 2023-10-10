namespace Indexers_In_CSharp
{


    class Employee {
        #region private members
        private int[] age = new int[3];
        #endregion

        /// <summary>
        /// It uses to set the list elements like array 
        /// when we create an object of a class we can use that object as indexer e.g. emp[0] = 5;
        /// </summary>
        /// <param name="index"></param>
        /// <returns> value </returns>
        public int this[int index]
        {
            set
            {
                if (index >=0 && index < age.Length)
                {
                    if (value > 0)
                    {
                        age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative!!!!!!");
                    }
                }
                else { Console.WriteLine("Index out of bound....."); }
            }
            get 
            { 
                return age[index];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            //employee[0] = -10;
            Console.WriteLine(emp[0]);
        }
    }
}
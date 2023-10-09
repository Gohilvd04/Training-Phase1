namespace Operator_Overloading
{

    class NewClass
    {
        public string str;
        public int num;

        public static NewClass operator +(NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.str = obj1.str + obj2.str;
            obj3.num = obj1.num + obj2.num;

            return obj3;
        }

        //public static NewClass operator ++(NewClass obj)
        //{
        //    NewClass obj3 = new NewClass();
        //    obj3.num = obj.num+1;
        //    obj3.str = obj.str + obj3.num;

        //    return obj3;
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass
            {
                str = "Vishal ",
                num = 1
            };
            NewClass obj2 = new NewClass
            {
                str = "Gohil",
                num = 2
            };

            NewClass obj3 = new NewClass();

            obj3 = obj1 + obj2;
            //obj3++;

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);


        }
    }
}
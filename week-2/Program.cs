namespace week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LonelyInteger();
            gradingStudents();
        }       
        
        static void LonelyInteger()
        {
            List<int> a = new List<int> { 1, 2,3,4,3,2,1 };


            for (int i = 0; i < a.Count(); i++)
            {
                bool chechdouble = false;

                for (int j = 0; j < a.Count(); j++)
                {
                    if (i != j && a[i] == a[j])
                    {
                        chechdouble = true;
                        break;
                    }
                }

                if (!chechdouble)
                {
                    Console.WriteLine(a[i]);
                }
            }


            //bool checkdouble = false;
            //for (int i = 0; i < a.Count(); i++)
            //{
            //    for (int j = 0; j < a.Count(); j++)
            //    {
            //        if (i != j && a[i] == a[j])
            //        {
            //            checkdouble = true;
            //            break;
            //        }

            //        if (!checkdouble)
            //        {
            //            Console.WriteLine(a[i]);

            //        }
            //    }
            //}
        }

        static void gradingStudents()
        {
            List<int> grades = new List<int> { 52, 48, 47, 83, 37, 38 };

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    continue;
                }
                if (grades[i] % 5 >= 3)
                {
                    int temp = 5 - (grades[i] % 5);
                    grades[i] += temp;
                }
            }

            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}
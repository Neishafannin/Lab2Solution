namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person.SumOfAllAges = 0;

            //==========================================================//
            //   Refer to part 1 on the class. (variables declared      //
            //   and spouse referenced to the p1).                      //
            //==========================================================// 
             
            Person P1 = new Person();  
            P1.Spouse = new Person();
            P1.Spouse.Spouse = P1;


            System.Console.Write("Enter Your First Name                : ");                      //============================================//
            P1.FirstName = System.Console.ReadLine();                                             //  In this section I am asking the user      //
            System.Console.Write("Enter Your Last Name                 : ");                      //  to provide me with their name, spouses    //
            P1.LastName = System.Console.ReadLine();                                              //  name. and etc. then commanding that       //
            System.Console.Write("Enter Your Age                       : ");                      //  info to be printed to the console         //
            P1.Age = int.Parse(System.Console.ReadLine());                                        //  window.                                   //
            Person.SumOfAllAges += P1.Age;                                                        //============================================//
            System.Console.Write("Enter Your Spouse's Name             : ");
            P1.Spouse.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Spouse's Age              : ");
            P1.Spouse.Age = int.Parse(System.Console.ReadLine());

            //==========================================================//
            //   Refer to part 2 on the class (sumOfAllAges) and see    //
            //   see other variable declarations here on the main       // 
            //   program declaring the SumOfAllAges here I'm using the  //
            //   static variable to keep track of the SumOfAllAges      //
            //==========================================================// 

            Person.SumOfAllAges += P1.Spouse.Age;
            P1.Spouse.LastName = P1.LastName;          //  <---------This insures that the spouse of p1 has the same last name as him/her  //

            //==========================================================//
            //   Refer to part 1 on the class. (variables declared      //
            //   and spouse referenced to the p2).                      //
            //==========================================================// 

            Person P2 = new Person();
            P2.Spouse = new Person();
            P2.Spouse.Spouse = P2; 


            System.Console.Write("Enter Your First Name                : ");
            P2.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Last Name                 : ");
            P2.LastName = System.Console.ReadLine();
            System.Console.Write("Enter Your Age                       : ");
            P2.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += P2.Age;
            System.Console.Write("Enter Your Spouse's Name             : ");
            P2.Spouse.FirstName = System.Console.ReadLine();
            System.Console.Write("Enter Your Spouse's Age              : ");
            P2.Spouse.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += P2.Spouse.Age;
            P2.Spouse.LastName = P2.LastName;          //  <---------This insures that the spouse of p2 has the same last name as him/her  //

            //==========================================================//
            //   Refer to part 3 & 4 on the class.                      //
            //==========================================================// 

            P1.PrintNameAndAge();
            P1.Spouse.PrintNameAndAge();
            P2.PrintNameAndAge();
            P2.Spouse.PrintNameAndAge();

            System.Console.WriteLine(Person.SumOfAllAges / 4);     //  <---This ensures that the SumOfAllAges average is calculated and printed to the console window //
            System.Console.Write("Press any Key to Continue...");
            System.Console.ReadKey ();



















        }
    }
}

namespace Lab2
{
    class Person
    {
        //==================================================================================================================================//
        //     Part 1:                                                                                                                      //
        //     Below are the Declared member variables for this assignment, Note spouse is declared as "person" and since this assignment   //
        //     requires the spouse to referenced inside of the objects p1 & p2, the spouse for p1 will need to be assigned to p1 and the    //
        //     spouse for p2 will need to be assigned to p2 in the main program.  Then the spouse of p1, and the spouse of p2 will need     //
        //     to be re-assigned to the spouse of p1 and p2 (each referenced separately inside of the main program).                        //
        //     Example:   Person P1 = new Person();                                                                                         //
        //                P1.Spouse = new Person();                                                                                         //
        //                P1.Spouse.Spouse = P1;                                                                                            //
        //==================================================================================================================================//     
        
                        
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        //==================================================================================================================================//
        //    Part 2:                                                                                                                       //
        //    Static variable declared, unique to each instance of a person.  Can only be accessed from the class, but will need to be      //
        //    declared as "Person.SumOfAllAges += P1.Spouse.Age;" in the main program in order to complete the action.                      //
        //==================================================================================================================================//
        public static double SumOfAllAges;


        //==================================================================================================================================//
        //   Part 3 & 4:                                                                                                                        //
        //   Here the public string variable is declared and a method will need to be invoked in order to have an action returned, below    //
        //   the declared variable of type string is an return command with the string concatenation of the necessary action needed.        //
        //   Then, since age and name needed to be printed to the console window, the void method was invoked to PrintNameAndAge and        //
        //   defined to concatenate a string with age and full name to and printed to the console window using system.console.writeline     //
        //==================================================================================================================================// 
        public string GetFullName()
        {
            return this.LastName  + ", " + this.FirstName;
        }

        public void PrintNameAndAge()
        {
            
            System.Console.WriteLine(GetFullName() + " (" + this.Age + ")");
        }
    }
}

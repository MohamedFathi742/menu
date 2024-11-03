namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // welcome user
            Console.WriteLine("welcome to manu app \n ");
            // manu
            Console.WriteLine("F- Food\nD-Drinks");
            Console.WriteLine("What do you want  ");
            //read value 
            char Selection = 'm';
            bool isConverted = char.TryParse(Console.ReadLine(), out Selection);
            if (!isConverted)
            {
                Console.WriteLine("please enter Correct value");
                return;
            }
            else
            {



                switch (Selection)
                {
                    case 'F':
                        Console.WriteLine("Which foods do you prefer\n1-Sandwiches\n2-pizza\n3-pasta\n4-chicks");
                        Console.WriteLine("What do you want  ");
                        byte selectionFood = 0;
                        bool ConvertedFood = byte.TryParse(Console.ReadLine(), out selectionFood);
                        switch (selectionFood)
                        {
                            case 1:
                                Console.WriteLine("Please confirm the order by :Y:");
                                char confirmYesOrNo = 'm';
                                bool Converted = char.TryParse(Console.ReadLine(), out confirmYesOrNo);
                                if (confirmYesOrNo == 'Y') { Console.WriteLine("Confirmed -Sandwiches-"); }
                                else { Console.WriteLine("Not confirmed"); }
                                break;
                            case 2:
                                Console.WriteLine("Please confirm the order by :Y:");
                                char confirmYeesOrNo = 'm';
                                bool Convertted = char.TryParse(Console.ReadLine(), out confirmYeesOrNo);
                                if (confirmYeesOrNo == 'Y') { Console.WriteLine("Confirmed -pizza-"); }
                                else { Console.WriteLine("Not confirmed"); }
                                break;



                            case 3:
                                Console.WriteLine("Please confirm the order by :Y:");
                                char confirmYesOrNoo = 'm';
                                bool Converteed = char.TryParse(Console.ReadLine(), out confirmYesOrNoo);
                                if (confirmYesOrNoo == 'Y') { Console.WriteLine("Confirmed -pasta-"); }
                                else { Console.WriteLine("Not confirmed"); }
                                break;
                            case 4:
                                Console.WriteLine("Please confirm the order by :Y:");
                                char confirmmYesOrNo = 'm';
                                bool Converrted = char.TryParse(Console.ReadLine(), out confirmmYesOrNo);
                                if (confirmmYesOrNo == 'Y') { Console.WriteLine("Confirmed -chicks-"); }
                                else { Console.WriteLine("Not confirmed"); }

                                break;

                        }
                        break;

                    case 'D':
                        Console.WriteLine("Which Drinks do you prefer\n1- Hot drinks\n2-cold drinks");

                        Console.WriteLine("What do you want  ");
                        byte selectionDrink = 0;
                        bool ConvertedDrink = byte.TryParse(Console.ReadLine(), out selectionDrink);
                        switch (selectionDrink)
                        {
                            case 1:
                                Console.WriteLine("Please confirm the order by :Y:");
                                char confirmYesOrNo = 'm';
                                bool Converted = char.TryParse(Console.ReadLine(), out confirmYesOrNo);
                                if (confirmYesOrNo == 'Y') { Console.WriteLine("Confirmed - Hot drinks-"); }
                                else { Console.WriteLine("Not confirmed"); }
                                break;
                            case 2:
                                Console.WriteLine("Please confirm the order by :Y:");
                                char confirmYeesOrNo = 'm';
                                bool Convertted = char.TryParse(Console.ReadLine(), out confirmYeesOrNo);
                                if (confirmYeesOrNo == 'Y') { Console.WriteLine("Confirmed -cold drinks-"); }
                                else { Console.WriteLine("Not confirmed"); }
                                break;





                        }
                        break;
                }
            }
        }
    }
}

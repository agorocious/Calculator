using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");




            /*



                        int x = 2;
                        int y = 3;
                        int z = x + y;

                        double z1 = 5.0;
                        bool flag = true;

                        decimal d = 9.0M;

                        char myCharacter = 'f';
                        // Console.WriteLine(z);

                        string aa = "uche";
                        //  Console.WriteLine(aa);
                        //  Console.WriteLine();

                        DateTime today = DateTime.Now;
                        DateTime myBirthday = Convert.ToDateTime("2000-09-09");

                        // Console.WriteLine(myBirthday);
                        // Console.WriteLine(flag);
                        // Console.WriteLine(d);
                        // Console.WriteLine(today);


                        string nam = "Agoro Hakeem";
                        decimal AcctBal = 3456787.987M;
                        string bank = "Access Bank";
                        string AcctNo = "9876009876";


                        // Console.WriteLine("Name: " + nam + " Bank: " + bank + "Account Number: " + AcctNo + " Account Ballance:" + AcctBal);

                        //int sd;
                        //sd = Convert.ToInt32(Console.ReadLine());

            line1:

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Welcome to MTN Service");
                        Console.WriteLine("Please choose your option");
                        Console.WriteLine("1.     Check Your Balance");
                        Console.WriteLine("2.     Data Plan");

                        string chose;
                        chose = Console.ReadLine();


                        if (chose == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Your Account Balance is 1000");
                            Console.WriteLine("-------------------------------------------" + "\n" + "\n");
                            goto line1;

                        }
                        else if (chose =="2") {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            Console.WriteLine("Welcome to MTN Data Plan");
                        Console.WriteLine("Please choose your data plan");
                        Console.WriteLine("1.     1000 for 10GB weekly");
                        Console.WriteLine("2.     2000 for 10GB weekly");
                        Console.WriteLine("3.     3000 for 10GB weekly");
                        Console.WriteLine("4.     4000 for 10GB weekly");
                            Console.ForegroundColor = ConsoleColor.Yellow;



                            string num;
                        num = Console.ReadLine();


                        if (num == "1")
                        {
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.Clear();
                                Console.WriteLine("You choose 1000 for 10GB weekly ");
                                Console.WriteLine("-------------------------------------------" + "\n" + "\n");
                                goto line1;


                            }
                        else if (num == "2")
                        {

                                Console.ForegroundColor = ConsoleColor.White; Console.Clear();
                                Console.WriteLine("You choose 2000 for 20GB weekly ");
                                Console.WriteLine("-------------------------------------------" + "\n" + "\n");
                                goto line1;

                            }

                        else if (num == "3")
                        {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("You choose 3000 for 30GB weekly ");
                                Console.WriteLine("-------------------------------------------" + "\n" + "\n");
                                goto line1;
                            }

                        else if (num == "4")
                        {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();

                                Console.WriteLine("You choose 2000 for 40GB weekly ");
                                Console.WriteLine("-------------------------------------------" + "\n" + "\n");
                                goto line1;
                            }




                    } */








            /*

            int[] numbers = {1,2,3,4,5,6,7};

            for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine($"{i}----- {numbers[i]}");
            }

            Console.WriteLine("content at index 5 is " + numbers[5]);


            bool ty = true;
            int tx = 0;
            while (ty == true)
            {
                ty = true;
                Console.WriteLine(numbers[tx]);
                tx++;

            } 
            */
            Person p = new Person();
            p.Name = "John";
            p.Age = 50;
            p.Talk();

            
        }
    }
}



namespace Assignment2
{
     class Accounts
    {
      public long acc_no = 15780054311;
      public string customername="Gajula Sridhar";
      public decimal bal = 500;
        public int amount = 0;
        public void credit(int amt)
        {
            amount=amt;
            bal=bal+amt;
            
        }
        public void debit(int amt)
        {  
            amount = amt;
            if (amt > bal)
            {
                Console.WriteLine();
                Console.WriteLine("Insufficient Balance!!!\n\n");
                
            }
            else
            {
                bal = bal - amt;
            }
        }

        public void balance()
        {
            Console.WriteLine($"Account number:  {acc_no}\nAccount_holder_name:  {customername}\n\n");
            Console.WriteLine($"Your Account balance is {bal}");
            Console.WriteLine();
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Accounts acc = new Accounts();
            Console.WriteLine($"Account number: 15780054311\nAccount_holder_name: Gajula sridhar\n");
            string Acc_type;
            Console.WriteLine("Please Select the Account_Type:\n1.savings\n2.current\n");
            int opt= int.Parse(Console.ReadLine());
            Console.WriteLine();
            do
            {
                switch (opt)
                {
                    case 1:
                        {
                            Acc_type = "Savings";



                        }
                        break;
                    case 2:
                        {
                            Acc_type = "Current";

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Option");

                        }
                        break;
                }
                
                Console.WriteLine("Please Select the Transaction_Type:\n1.Deposit\n2.Withdraw\n3.Check_BankBalance\n4.Exit\n");
                int opt1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (opt1)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter the amount\n");
                            int amt= int.Parse(Console.ReadLine());
                                acc.credit(amt);
                            
                            Console.WriteLine();
                            Console.WriteLine("Your money is Deposited Succesfully !!!!\n\n");


                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter the amount\n");
                            int amt = int.Parse(Console.ReadLine());
                           
                            acc.debit(amt);
                            if (amt <= acc.bal)
                            {
                                Console.WriteLine("Your withdrwal transaction has been Successfully !!!\n\n");
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 3:
                        {
                            acc.balance();

                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0);

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid Option\n\n");

                        }
                        break;
                }
            }while(true);

        }
    }
}

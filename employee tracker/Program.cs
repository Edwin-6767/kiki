using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee_tracker;

namespace employee_tracker
{
    public class employee
    {
        string employeename;
        string address;
      
         // postfix increment
           

        public employee()
        {   int employeeid= 0;
            Console.WriteLine("Enter your name");
            employeename = Console.ReadLine();
            
            Console.WriteLine("enter your address");
            address = Console.ReadLine();
            Console.WriteLine("Hi\n" + employeename + "\nWelcome to EQ SOFT");
            employee employee = new employee(0);
           


        }
        public employee(int employeeid)
        {
            ++employeeid;
            Console.WriteLine("your employee id is EQSOFT00" + employeeid);
        }
        
    }
    //public class employeedetails
    //{
    //    int employeid = 0 + 1;
    //    bool option;
    //    int yourchoice;
        //public employeedetails()
        //{
        //    option = true;
        //    do
        //    {
        //        Console.WriteLine("Explore the options we offer to find the perfect fit for your needs");
        //        Console.WriteLine("1.SALE\n2.LAB\n3.SERVICES");
        //        yourchoice = Convert.ToInt32(Console.ReadLine());
        //        switch (yourchoice)
        //        {
        //            case 1:
        //                Console.WriteLine("Welcome to Sales\n");
        //                sales sales = new sales();
        //                break;
        //            case 2:
        //                Console.WriteLine("Welcome to LAB");
        //                lab lab = new lab();

        //                break;
        //            case 3:
        //                Console.WriteLine("Welcome to Services");

        //                services services = new services();
        //                break;

        //        }
        //        Console.WriteLine("Would you like to explore our options again?(True/False)");
        //        option = bool.Parse(Console.ReadLine());

        //    } while (option);

            //Console.WriteLine("Thank You!\n");


    //    }
    //}

    public class sales : employee
    {
        int yourchoice;
        bool option1;
        public sales()
        {


            option1 = true;
            do
            {
                Console.WriteLine("1.ERP\n2.CLOUD ERP\n3.MOBILE APP\n4.OTHERS");
                yourchoice = Convert.ToInt32(Console.ReadLine());
                switch (yourchoice)
                {
                    case 1:
                        Console.WriteLine(" ERP Software will be around 1 lakh");
                        break;
                    case 2:
                        Console.WriteLine("Cloud ERP Software will be around 25,000 ");
                        break;
                    case 3:
                        Console.WriteLine("Mobile Applications will be around 15,000 ");
                        break;
                    case 4:
                        Console.WriteLine("Our Executive will get back to you soon.");
                        break;


                }
                Console.WriteLine("Do you want to continue in Sales(True/False)");
                option1 = bool.Parse(Console.ReadLine());

            } while (option1);


        }
    }
    public class lab : employee
    {
        public lab()
        {
            Console.WriteLine("GPS (Global Positioning System)\n2.APIs (Application Programming Interface)\n3.RFID (Radio Frequency Identification)."); 
        }
    }
    public class services:employee
    {
        protected int yourchoice;
        string date;
        protected bool option;
        public services()
        {

            date = DateTime.Now.ToString("dd/MM/yy");
            option = true;
            do
            {
                Console.WriteLine("1.Online\n2.Onsite");
                yourchoice = Convert.ToInt32(Console.ReadLine());
                switch (yourchoice)
                {
                    case 1:
                        Console.WriteLine("Hi User\nYour Online service is sheduled for today(" + date + ")");
                        break;
                    case 2:
                        Console.WriteLine("Hi User\ Online service is sheduled for tommorow(" + DateTime.Today.AddDays(1) + ")");
                        break;


                }
                Console.WriteLine("Do you want to continue in Services(True/False)");
                option = bool.Parse(Console.ReadLine());
            } while (option);
        
    }

}
    internal class Program
    {
        static void Main(string[] args)
        {
           
            employee employee = new sales();
            lab lab = new lab();
            services services = new services();
                   


                     

        }
    }
}

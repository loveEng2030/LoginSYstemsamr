using System;

internal class Program
{
    // تخزين البيانات في Arrays 
    static string[] Names = new string[10000];
    static string[] Passwords = new string[10000];
    static string[] Emails = new string[10000];
    static string[] Phones = new string[10000];
    static int accountCount = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            ShowMenu();
            int choice = GetChoice();

            if (choice == 1)
                CreateAccount();
            else if (choice == 2)
                Login();
            else if (choice == 3)
                ShowAllAccounts();
            else if (choice == 4)
            {
                Console.WriteLine("\t\t\t\t\t Thank you for using our system ....");
                break;
            }
        }
    }

    // دالة عرض القائمة
    static void ShowMenu()
    {
        //Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t|------------------------------------------------|\n ");
        Console.WriteLine("\t\t\t\t|       Hello Dear In Our System Login..!        |\n");
        Console.WriteLine("\t\t\t\t|------------------------------------------------|\n ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\t\t\t\t\t 1: Register New Account.. ");
        Console.WriteLine("\t\t\t\t\t 2: Login Your Account.. ");
        Console.WriteLine("\t\t\t\t\t 3: View Accounts Data.. ");
        Console.WriteLine("\t\t\t\t\t 4: Exit .. \n");
        Console.WriteLine("\t\t\t\t\t Please Enter Choice .. \n");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
    }

    // دالة الحصول على اختيار المستخدم
    static int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t Please Enter a Valid Choice (1-4) ..");
            Console.ResetColor();
            Console.Write("\t\t\t\t\t ");

        }
        return choice;
    }

    // دالة إنشاء حساب جديد
    static void CreateAccount()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t Enter Your Name.. ");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
        Names[accountCount] = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t Enter Password.. ");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
        Passwords[accountCount] = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t Enter Gmail.. ");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
        Emails[accountCount] = Console.ReadLine();

        while (!Emails[accountCount].Contains("@gmail.com"))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t Please enter a valid email (user@gmail.com)..!\n");
            Console.ResetColor();
            Console.Write("\t\t\t\t\t ");
            Emails[accountCount] = Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t Enter Phone Number.. ");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
        Phones[accountCount] = Console.ReadLine();
        //Console.Clear();
        accountCount++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\t\t Account Created Successfully!");
        Console.ResetColor();
    }

    // دالة تسجيل الدخول
    static void Login()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t Enter Your Name.. ");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
        string name = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\t\t\t\t\t Enter Password.. ");
        Console.Write("\t\t\t\t\t ");
        Console.ResetColor();
        string password = Console.ReadLine();
        Console.Write("\t\t\t\t\t ");

        bool found = false;
        for (int i = 0; i < accountCount; i++)
        {
            if (Names[i] == name && Passwords[i] == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Login Successful! Welcome " + name);
                Console.ResetColor();
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Name or Password!");
            Console.ResetColor();
            //Console.Clear();
        }
    }

    // دالة عرض كل الحسابات
    static void ShowAllAccounts()
    {
        if (accountCount == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\t No accounts registered.");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        //Console.WriteLine("\nAll Accounts:");
        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i < accountCount; i++)
        {
            Console.WriteLine($"\t\t\t\t\t {i + 1} Name: {Names[i]}\n\t\t\t\t\t Email: {Emails[i]}\n\t\t\t\t\t" +
                $" Phone: {Phones[i]}\n\t\t\t\t\t Password: {Passwords[i]}\n\t\t\t\t\t ------------------------ \n\n");

        }
        Console.ResetColor();
    }
}

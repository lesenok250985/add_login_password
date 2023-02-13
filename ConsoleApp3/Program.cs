using System;
public class Exercise16
{
    public static void Main()
    {
        string username, password;
        int ctr = 0;
        Console.Write("\n\nCheck username and password :\n");
        Console.Write("N.B. : Default user name and password is :Admin or User and 1234\n, 12345\n");
        Console.Write("------------------------------------------------------\n");

        do
        {
            Console.Write("Input a username: ");
            username = Console.ReadLine();

            Console.Write("Input a password: ");
            password = Console.ReadLine();

            if (username != "User" || password != "1234")
                ctr++;
            else if (username != "Admin" || password != "12345")
                ctr = 1;

        }
        while ((username != "User" || password != "1234") && (ctr != 3));

        if (ctr == 3)
            Console.Write("\nLogin attemp three or more times. Try later!\n\n");
        else
            Console.Write("\nThe password entered successfully!\n\n");
    }
}

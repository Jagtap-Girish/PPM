﻿using System;

namespace ProlificsProjectManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Number for operation");
            Console.WriteLine("1) Add Project");
            Console.WriteLine("2) View Project");
            Console.WriteLine("3) Add Employee");
            Console.WriteLine("4) View Employee");
            Console.WriteLine("5) Add Role");
            Console.WriteLine("6) View Role");
            Console.WriteLine("7) Quit");

            string[] Project = new string[4];
            string[] Employee = new string[5];
            string[] Role = new string[2];
           
            bool j = true;
            while (j)
            {
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        string name;
                        string Start_Date;
                        string End_Date;
                        string Budget;
                        Console.WriteLine("Enter Project Name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Project Start Date");
                        Start_Date = Console.ReadLine();
                        Console.WriteLine("Enter Project End Date");
                        End_Date = Console.ReadLine();
                        Console.WriteLine("Enter Project budget");
                        Budget = Console.ReadLine();


                        Project[0] = "Name " + name;
                        Project[1] = "Start_Date " + Start_Date;
                        Project[2] = "End_Date " + End_Date;
                        Project[3] = "Budget " + Budget;

                        break;
                    case 2:
                        foreach (var item in Project)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        string Id;
                        string First_name;
                        string Last_name;
                        string Contact;
                        string RoleId;
                        Console.WriteLine("Enter Employee Id");
                        Id = Console.ReadLine();
                        Console.WriteLine("Enter Employee First Name");
                        First_name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Last Name");
                        Last_name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Contact");
                        Contact = Console.ReadLine();
                        Console.WriteLine("Enter Employee RoleId");
                        RoleId = Console.ReadLine();
                        Employee[0] = "Id " + Id;
                        Employee[1] = "First name " + First_name;
                        Employee[2] = "Last_name " + Last_name;
                        Employee[3] = "Contact " + Contact;
                        Employee[4] = "RoleId " + RoleId;
                        break;
                    case 4:
                        foreach (var item in Employee)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 5:
                        string Roleid;
                        string RoleName;
                        Console.WriteLine("Enter Role Id");
                        Roleid = Console.ReadLine();
                        Console.WriteLine("Enter Project RoleName");
                        RoleName = Console.ReadLine();
                        Role[0] = "Roleid " + Roleid;
                        Role[1] = "Role Name " + RoleName;
                        break;
                    case 6:
                        foreach (var item in Role)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 7:

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EZInput;

namespace SignUp_SignIn
{
    class Program
    {
        static void Main(string[] args)
        {

            credentials[] s = new credentials[10];
            int count = 0;
            string path = "C:\\OOP week2\\Week 2 lab\\SignUp SignIn\\record.txt";
            string[] name = new string[10];
            string[] pass = new string[10];
            loadData( ref s, path,ref count);
            do
            {
                string rec;
                rec = menu();
                if (rec == "1")
                {
                    if (count < 9)
                    {
                        s[count] = SignUp(s, count, path);
                        count++;
                        Console.ReadKey();
                    }
                }
                else if (rec == "2")
                {
                    SignIn(s, count);
                    Console.ReadKey();
                }
                else
                {
                    break;
                }

            } while (true);
        }
        static string menu()
        {
            Console.Clear();
            string option;
            Console.WriteLine("1.SignUp!!!!");
            Console.WriteLine("2.SignIn!!!!");
            Console.WriteLine("3.Exit!!!!");
            option = Console.ReadLine();
            return option;
        }
        static void storeData(string n, string p, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
        static void loadData(ref credentials[] s, string path,ref int count)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while ((record = filevariable.ReadLine()) != null)
                {
                    credentials s1 = new credentials();
                    s1.name = parseData(record, 1);
                    s1.password = parseData(record, 2);
                    s[x] = s1;
                    x++;
                    count++;
                    if (x > 9)
                    {
                        break;
                    }
                }
                filevariable.Close();
            }
            else
            {
                Console.WriteLine("Not exists!!!!");
            }
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }

            return item;
        }
        static credentials SignUp(credentials[] s, int count, string path)
        {
            Console.Clear();
            string name;
            string password;
            credentials s1 = new credentials();
            Console.WriteLine("Enter new username!!!!");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter new password!!!!");
            s1.password = Console.ReadLine();
            bool found;
            found = checkValidateuser(s, s1.name, s1.password, count);
            if (found == true)
            {
                Console.WriteLine("Already exists!!!!");
            }
             if (found == false)
            {
                Console.WriteLine("Success!!!!");
                name = s1.name;
                password = s1.password;
                storeData(name, password, path);
                return s1;
            }
            return null;
        }
        static bool checkValidateuser(credentials[] s, string name, string password, int count)
        {
            bool flag = false;
            for (int i = 0; i < count; i++)
            {
                if (name == s[i].name)
                {
                    if (password == s[i].password)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            return flag;
        }
        static void SignIn(credentials[] s, int count)
        {
            Console.Clear();
            string n;
            string p;
            Console.WriteLine("Enter username!!!!");
            n = Console.ReadLine();
            Console.WriteLine("Enter password!!!!");
            p = Console.ReadLine();
            bool found;
            found = checkValidateLogInUser(n, p, s, count);
            if (found == true)
            {
                Console.WriteLine("Success!!!!");
            }
            else if (found == false)
            {
                Console.WriteLine("Wrong username or password!!!!");
            }
        }
        static bool checkValidateLogInUser(string n, string p, credentials[] s, int count)
        {
            bool flag = false;
            for (int i = 0; i < count; i++)
            {
                if (n == s[i].name && p == s[i].password)
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}


﻿using IntroSE.Kanban.Backend.ServiceLayer;
using System;

namespace Test
{
    class Program
    {
        /*ervice service = new Service();*/
        private static int testCount = 0; 
        static void Main(string[] args)
        {
            Service s = new Service();
           //Print(s.AddBoard("Rafa@gmail.com", "semster B"));
            //Print(s.Register("Rafa@gmail.com", "12345678"));
            //Print(s.Register("Rafagmail.com", "Rf12345678"));
            Print(s.Register("Rafa@gmail.com", "Rf12345678"));
            //Print(s.Register("Rafa@gmail.com", "Rf12345678"));
            //Print(s.Register("Rafa111111@gmail.com", "R12345678"));
            //Print(s.Register("Rafa111111@gmail.com", "ff12345678"));
            //Print(s.Register("Rafa111111@gmail.com", "RF12345678"));
            //Print(s.Register("Rafa111111@gmail.com", "Rf2"));
            //Print(s.Register("Rafa111111@gmail.com", "R12345678222222222222222222222222222222222f"));
            //Print(s.Register("Rafa111111@gmail.com", "R12345678ש"));
            Print(s.Register("Rafa111111@gmail.com", "R12345678f"));
            //Print(s.Login("Rafa@gmail.com", "R12345678f"));
            Print(s.AddBoard("Rafa@gmail.com", "semester B"));
            Print(s.Login("Rafa@gmail.com", "Rf12345678"));
            //Print(s.Login("Rafa123@gmail.com", "Rf12345678"));
            Print(s.Login("Rafa111111@gmail.com", "R12345678f"));

            //Print(s.Register("Rafa@...@", "1234567Rfgmlks"));
            //Print(s.Register("Rafa@gmail.com", "Rf12345678"));
            //Print(s.Logout("Rafa@gmail.com"));
            //Print(s.Logout("Rafa@gmail.com"));
            //Print(s.Register("Rafa@gmail.com", "Rf12345678"));
            //Print(s.Login("Rafa@gmail.com", "Rf12345678"));
            //Print(s.Login("Rafa@gmail.com", "Rf12345678"));



            // --------------------- AddBoard Tests -----------------------
            Print(s.AddBoard("Rafa@gmail.com", "semester B"));

            Print(s.AddBoard("Rafa@gmail.com", "semester B")); // ERR had board name already

            Print(s.AddBoard("Rafa@gmail.com", "semester A"));
            Print(s.AddBoard("Rafa111111@gmail.com", "semester B"));
            Print(s.AddBoard("Rafa@gmail.com", "")); // ERR not legle board name

            //Print(s.RemoveBoard("Rafa@gmail.com", "semester B")); 
            //Print(s.RemoveBoard("Rafa@gmail.com", "semester B")); // ERR not had board name
            //Print(s.RemoveBoard("Rafdsada@gmail.com", "semester B")); // ERR not had email 
            //Print(s.RemoveBoard("Rafa@gmail.com", "semester A"));




            // --------------------- AddTask Tests -----------------------

            //Print(s.AddTask("Rafa@gmail.com", "semester B", "SE", "task 1", new DateTime(2021, 5, 14, 0, 0, 0)));
            ////Console.WriteLine(s.AddTask("Rafa@gmail.com", "semester B", "SE", "task 1", new DateTime(2021, 5, 14, 0, 0, 0)).Value.Id);
            //Print(s.AddTask("Rafa@gmail.com", "semester B", "SE", "", new DateTime(2021, 5, 14, 0, 0, 0))); // possible the same name for task???
            ////Console.WriteLine(s.AddTask("Rafa@gmail.com", "semester B", "SE", "", new DateTime(2021, 5, 14, 0, 0, 0)).Value.Id);
            //Print(s.AddTask("Rafa@gmail.com", "semester B", "SE", "task 2", new DateTime(2021, 5, 14, 0, 0, 0)));
            ////Console.WriteLine(s.AddTask("Rafa@gmail.com", "semester B", "SE", "task 2", new DateTime(2021, 5, 14, 0, 0, 0)).Value.Id);
            //Print(s.AddTask("Rafa@gmail.com", "semester B", "SE", "task 3", new DateTime(2021, 5, 14, 0, 0, 0)));
            //Print(s.AddTask("Rafa@gmail.com", "semester A", "SE", "task 1", new DateTime(2021, 5, 14, 0, 0, 0)));
            //Print(s.AddTask("Rafa111111@gmail.com", "semester B", "SE", "task 1", new DateTime(2021, 5, 14, 0, 0, 0)));
            //Print(s.AddTask("a1@gmail.com", "semester B", "SE", "test", new DateTime(2021, 5, 14, 0, 0, 0)));
            //Print(s.AddTask("Rafa111111@gmail.com", "semester C", "SE", "task 1", new DateTime(2021, 5, 14, 0, 0, 0)));

            // --------------------- AdvenceTask Tests -----------------------
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 0, 10)); // EROR ID not exsit
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 0, 1));
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 1, 2));
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 1, 1));
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 1, 1));
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 2, 1));
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester B", 0, 3));
            //Print(s.AdvanceTask("Rafa@gmail.com", "semester A", 0, 5));


            //// --------------------- UpdateTask Tests ----------------
            ////Print(s.UpdateTaskDescription("Rafa@gmail.com", "semester B", 0, 2, "1.1"));
            //////Print(s.UpdateTaskDueDate("Rafa@gmail.com", "semester B", 0, 2, new DateTime(2021, 13, 14, 0, 0, 0))); // EROR invalid data 
            ////Print(s.UpdateTaskDueDate("Rafa@gmail.com", "semester B", 0, 2, new DateTime(2021, 4, 14, 0, 0, 0))); // EROR passed date
            ////Print(s.UpdateTaskDueDate("Rafa@gmail.com", "semester B", 0, 2, new DateTime(2021, 6, 15, 0, 0, 0)));
            ////Print(s.UpdateTaskTitle("Rafa@gmail.com", "semester B", 0, 2, "")); // EROR canot be empty title
            ////Print(s.UpdateTaskTitle("Rafa@gmail.com", "semester B", 0, 2, "semseter C"));

            //// --------------------- InProgress Tests ----------------

            //Console.WriteLine(s.InProgressTasks("Rafa@gmail.com").Value[0].Id);
            //Console.WriteLine(s.InProgressTasks("Rafa@gmail.com").Value[1].Id);
            ////Console.WriteLine(s.InProgressTasks("Rafa@gmail.com").Value[2].Id); // EROR 









            //Console.WriteLine(s.AddBoard("Rada@gmail.com", "Semester B").ErrorMessage);
            //Console.WriteLine(s.AddBoard("Rafa@gmail.com", "Semester B").ErrorMessage);
            //Console.WriteLine(s.Login("Rafa@gmail.com", "Rf12345678").ErrorMessage);
            //Console.WriteLine(s.AddBoard("Rafa@gmail.com", "Semester B").ErrorMessage);

            //// ------------- Asaf Tests -------------
            Console.WriteLine(" \n\n Asaf Tests \n\n");
            Print(s.Register("asafs@gmail.com", "Aa123"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.Login("asafs@gmail.com", "Aa123"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.Login("asafs@gmail.com", "Aa123"));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.Login("asafs@gmail.com", "Aa1234"));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.AddBoard("asafs@gmail.com",""));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.AddBoard("asafs@gmail.com", ""));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.AddBoard("asafs@gmail.com", "b1"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.AddBoard("asafs@gmail.com", "b1"));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.AddBoard("asafs@gmail.com", "b2"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.AddTask("asafs@gmail.com", "", "", "", new DateTime()));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.AddTask("asafs@gmail.com","b1", "", "", new DateTime()));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.AddTask("asafs@gmail.com", "b1","title1","", DateTime.Parse("4-20-2021")));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.AddTask("asafs@gmail.com", "b1", "title1", "123", DateTime.Parse("4-20-2021")));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.LimitColumn("asafs@gmail.com", "b11", 0, 2));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.LimitColumn("asafs@gmail.com", "b1", 0, 2));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.AddTask("asafs@gmail.com", "b1", "title1", "1234", DateTime.Parse("4-20-2021")));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.LimitColumn("asafs@gmail.com", "b1", 0, 3));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.AddTask("asafs@gmail.com", "b1", "title1", "1234", DateTime.Parse("4-20-2021")));
            Console.WriteLine("\t\tshould print ok\n");
            Console.WriteLine("\n\n\n\n" + s.InProgressTasks("asafs@gmail.com").Value.Count + "\n\n\n\n");
            Print(s.AdvanceTask("asafs@gmail.com", "b1", 1, 4));
            Console.WriteLine("\t\tshould print not ok\n");
            Console.WriteLine("\n\n\n\n" + s.InProgressTasks("asafs@gmail.com").Value.Count + "\n\n\n\n");
            Print(s.AdvanceTask("asafs@gmail.com", "b1", 0, 4));
            Console.WriteLine("\t\tshould print ok\n");
            Console.WriteLine("\n\n\n\n"+s.InProgressTasks("asafs@gmail.com").Value.Count+"\n\n\n\n");
            Print(s.AdvanceTask("asafs@gmail.com", "b1", 0, 1));
            Console.WriteLine("\t\tshould print ok\n");
            Console.WriteLine("\n\n\n\n" + s.InProgressTasks("asafs@gmail.com").Value.Count + "\n\n\n\n");
            Print(s.AdvanceTask("asafs@gmail.com", "b1", 1, 1));
            Console.WriteLine("\t\tshould print ok\n");
            Console.WriteLine("\n\n\n\n" + s.InProgressTasks("asafs@gmail.com").Value.Count + "\n\n\n\n");
            Print(s.GetColumnName("asafs@gmail.com", "b11", 1));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.GetColumnName("asafs@gmail.com", "b1", 3));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.GetColumnName("asafs@gmail.com", "b1", 1));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.GetColumn("asafs@gmail.com", "b11", 2));
            Console.WriteLine("\t\tshould print not ok\n");
            Console.WriteLine("\n\n\n\n" + s.GetColumn("asafs@gmail.com","b1",1).Value.Count + "\n\n\n\n");

            //////////// starting asaf register tests
            Print(s.Register("a@a.co.il", "Aa12"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.Register("aa@a.co.il", "Aa1"));
            Console.WriteLine("\t\tshould print not ok\n");
            Print(s.Register("aa@a.co.il", "Aaa1"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.Register("aaa@a.co.il", "0Aaa1"));
            Console.WriteLine("\t\tshould print ok\n");
            Print(s.Register("a^a_?a@a.co.il", "0Aaa1"));
            Console.WriteLine("\t\tshould print not ok\n");
        }

        static void Print(Response res)
        {
            string input = $"test {++testCount}  ";
            if (res.ErrorOccured)
                input += res.ErrorMessage;
            else
                input += "no error  " + res.GetType().Name;
            Console.WriteLine($"\n    -  ----------   {input}   ----------   -\n");
        }

        static void init(Service s)
        {
            s.Register("Rafa@gmail.com", "Rf12345678");
            s.Login("Rafa@gmail.com", "Rf12345678");
        }

        static void Register(Service s)
        {

        }

        static void Task(Service s)
        {

        }

        static void Column(Service s)
        {

        }

        static void validation(Response r, bool expected)
        {
            if (r.ErrorOccured != expected)
                throw new Exception();
        }
    }
}

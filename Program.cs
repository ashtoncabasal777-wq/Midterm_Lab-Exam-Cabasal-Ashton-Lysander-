using System.ComponentModel;

namespace StudentServiceQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> student = new Queue<string>();
            int finishedCount = 0;
            bool running = true;

            while (running)
            {
                Console.WriteLine("Choose what you want to do?");
                Console.WriteLine("1 - ADD STUDENT");
                Console.WriteLine("2 - SHOW WAITING STUDENTS");
                Console.WriteLine("3 - SERVE NEXT STUDENT");
                Console.WriteLine("4 - LAST SERVED STUDENT");
                Console.WriteLine("5 - EXIT");
                Console.Write("Enter code: ");
                string code = Console.ReadLine();
                Console.WriteLine();

                switch (code)
                {
                    case "1":
                        Console.Write("ADD STUDENT: ");
                        string newJob = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newJob))
                        {
                            student.Enqueue(newJob);
                            Console.WriteLine("student added.");
                        }
                        else
                        {
                            Console.WriteLine("student cannot be empty.");
                        }
                        break;

                    case "2":
                        if (student.Count == 0)
                        {
                            Console.WriteLine("No student in queue");
                        }
                        else
                        {
                            Console.WriteLine("Student Waiting");
                            int n = 1;
                            foreach (string job in student)
                            {
                                Console.WriteLine(n + ". " + student);
                                n++;
                                Console.WriteLine("Number of students: " + student.Count);
                                break;

                            }
                        }
                        break;

                    case "3":
                        if (student.Count == 0)
                        {
                            Console.WriteLine("No Student serving.");
                        }
                        else
                        {
                            student.Dequeue();
                            finishedCount++;
                            Console.WriteLine("Student successfully served");
                            Console.WriteLine("Serving Student " + student.Peek());
                            Console.WriteLine();
                        }
                        break;




                    case "4":
                                if (student.Count == 0)
                                    Console.WriteLine("No served student.");
                                else
                                    student.Peek();
                                Console.WriteLine("Last Served Student: " + student.Peek());
                                break;

                            case "5":
                                Console.WriteLine("Program ended. Goodbye!");
                                running = false;
                                break;

                            default:
                                Console.WriteLine("Invalid code. Please enter 1-5.");
                                break;
                            }

                            Console.WriteLine();


                        }
                }
            }

        }
    
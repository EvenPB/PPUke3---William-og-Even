
namespace PPTODOLIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program();

            static void Program()
            {

                Console.WriteLine("Velkommen til To-Do lista!");
                List<Tasks> todoList = new List<Tasks>();
                Tasks tasks = new Tasks();

                while (true)
                {
                    Console.WriteLine("Hva vil du gjøre?");
                    Console.WriteLine("Trykk 1. For å legge til ny task.");
                    Console.WriteLine("Trykk 2. For å fjerne en task");
                    Console.WriteLine("Trykk 3. for å vise alle tasksa");
                    Console.WriteLine("Trykk 4. for å avslutte programmet.");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Vennligst skriv navnet på tasken");
                        tasks.Navn = Console.ReadLine();
                        Console.WriteLine("Vennligst beskriv den");
                        tasks.Beskrivelse = Console.ReadLine();
                        todoList.Add(tasks);

                        Console.WriteLine("Tasken ble lagt til i lista");
                    }
                    else if (choice == "2")
                    {
                        for (int i = 0; i < todoList.Count; i++)
                        {

                            Console.WriteLine(i + ":" + todoList[i]);

                            Console.WriteLine("Velg en task for å se beskrivelsen.");

                            Console.WriteLine("Trykk 0. For å gå tilbake.");

                            int taskchoice = Convert.ToInt32(Console.ReadLine());

                            if (taskchoice == 0)
                            {
                                Program();
                            }/* else if (taskchoice != 0)
                        {
                            Console.WriteLine(todoList.description[taskchoice]); 
                        } */


                        }

                        Console.WriteLine("Vennligst skriv inn numberet på tasken du vil fjerne");
                        int taskNumberet = Convert.ToInt32(Console.ReadLine());
                        todoList.RemoveAt(taskNumberet);
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Tasks som du har lagt til i lista:");
                        if (todoList.Count > 0)
                        {
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"tasknumber {i + 1} ");
                                Console.WriteLine(todoList[i].Navn);
                                Console.WriteLine(todoList[i].Beskrivelse);
                            }
                        }



                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("På gjensyn!");
                        System.Environment.Exit(0);
                    }
                }

            }
        }
    }
}

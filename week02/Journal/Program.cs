using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "5" || choice == null)
            {
                return;
            }

            try
            {
                switch (choice)
                {
                    case "1":
                        string prompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        Console.Write("> ");
                        journal.AddEntry(new Entry
                        {
                            _date = DateTime.Now.ToShortDateString(),
                            _promptText = prompt,
                            _entryText = Console.ReadLine() ?? ""
                        });
                        break;
                    case "2":
                        journal.DisplayAll();
                        break;
                    case "3":
                        Console.Write("Filename: ");
                        journal.LoadFromFile(Console.ReadLine());
                        Console.WriteLine("Journal loaded.");
                        break;
                    case "4":
                        Console.Write("Filename: ");
                        journal.SaveToFile(Console.ReadLine());
                        Console.WriteLine("Journal saved.");
                        break;
                    default:
                        Console.WriteLine("Please choose an option from 1 to 5.");
                        break;
                }
            }
            catch (IOException exception)
            {
                Console.WriteLine($"Could not access the file: {exception.Message}");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a valid filename.");
            }

            Console.WriteLine();
        }
    }
}

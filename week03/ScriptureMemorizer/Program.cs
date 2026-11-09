using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeds requirements: randomly selects a scripture from a library,
        // and each round hides only words that are still visible.
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, " +
                "that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me.")
        };

        Scripture scripture = scriptures[Random.Shared.Next(scriptures.Count)];

        while (true)
        {
            if (!Console.IsOutputRedirected)
            {
                Console.Clear();
            }

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                return;
            }

            Console.Write("Press Enter to continue or type quit to finish: ");
            string input = Console.ReadLine();

            if (input == null || input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            if (input.Trim().Length == 0)
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}

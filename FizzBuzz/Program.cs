using System.Text;

internal sealed record FizzBuzzRule(int Divisor, string Label);

internal static class FizzBuzzRunner
{
    public static void WriteResults(int limit, IReadOnlyList<FizzBuzzRule> rules, TextWriter output)
    {
        ArgumentNullException.ThrowIfNull(rules);
        ArgumentNullException.ThrowIfNull(output);

        if (limit <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(limit), "The limit must be greater than zero.");
        }

        if (rules.Count == 0)
        {
            throw new ArgumentException("At least one rule is required.", nameof(rules));
        }

        foreach (FizzBuzzRule rule in rules)
        {
            ArgumentNullException.ThrowIfNull(rule);

            if (rule.Divisor <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rules), "Rule divisors must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(rule.Label))
            {
                throw new ArgumentException("Rule labels cannot be empty.", nameof(rules));
            }
        }

        var ruleCounts = new long[rules.Count];
        long otherCount = 0;
        output.WriteLine("\n--- Running FizzBuzz ---");

        for (long number = 1; number <= limit; number++)
        {
            var labels = new StringBuilder();

            for (int index = 0; index < rules.Count; index++)
            {
                FizzBuzzRule rule = rules[index];
                if (number % rule.Divisor != 0)
                {
                    continue;
                }

                labels.Append(rule.Label);
                ruleCounts[index]++;
            }

            if (labels.Length == 0)
            {
                output.WriteLine(number);
                otherCount++;
            }
            else
            {
                output.WriteLine($"{number} - {labels}");
            }
        }

        for (int index = 0; index < rules.Count; index++)
        {
            FizzBuzzRule rule = rules[index];
            output.WriteLine($"Count for {rule.Label} ({rule.Divisor}): {ruleCounts[index]}");
        }

        output.WriteLine($"Count of Other: {otherCount}");
    }
}

internal static class Program
{
    private static int Main()
    {
        Console.WriteLine("--- Configurable FizzBuzz ---");

        try
        {
            int limit = ReadPositiveInteger("Loop limit: ");
            int ruleCount = ReadPositiveInteger("Number of rules: ");
            var rules = new List<FizzBuzzRule>();

            for (int index = 1; index <= ruleCount; index++)
            {
                Console.WriteLine($"Rule {index}");
                int divisor = ReadPositiveInteger("  Divisor: ");
                string label = ReadRequiredText("  Label: ");
                rules.Add(new FizzBuzzRule(divisor, label));
            }

            FizzBuzzRunner.WriteResults(limit, rules, Console.Out);
            return 0;
        }
        catch (EndOfStreamException)
        {
            Console.Error.WriteLine("Input ended before configuration was complete.");
            return 1;
        }
    }

    private static int ReadPositiveInteger(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (input is null)
            {
                throw new EndOfStreamException();
            }

            if (int.TryParse(input, out int value) && value > 0)
            {
                return value;
            }

            Console.WriteLine("Enter a whole number greater than zero.");
        }
    }

    private static string ReadRequiredText(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (input is null)
            {
                throw new EndOfStreamException();
            }

            string value = input.Trim();
            if (value.Length > 0)
            {
                return value;
            }

            Console.WriteLine("The label cannot be empty.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NotificationChannelParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a notification title
            Console.WriteLine("The notification should be input with []");
            Console.WriteLine("Enter the notification title:");

            // Read the user's input (notification title) from the console
            string input = Console.ReadLine();

            // Call the ParseChannels method to analyze the input and get the result
            string result = ParseChannels(input);

            // Display the parsed result, showing the relevant notification channels
            Console.WriteLine(result);

            // Wait for the user to press any key before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        // Method to parse notification title and identify relevant notification channels
        static string ParseChannels(string title)
        {
            // Define a set of valid notification channels
            HashSet<string> validChannels = new HashSet<string> { "BE", "FE", "QA", "Urgent" };

            // Create a set to store channels detected in the title
            HashSet<string> detectedChannels = new HashSet<string>();

            // Regular expression to match tags within square brackets, e.g., "[BE]"
            Regex regex = new Regex(@"\[(.*?)\]");

            // Find all matches in the input title
            MatchCollection matches = regex.Matches(title);

            // Loop through each match found by the regular expression
            foreach (Match match in matches)
            {
                // Extract the tag name (e.g., "BE" from "[BE]")
                string tag = match.Groups[1].Value;

                // Check if the tag is one of the valid notification channels
                if (validChannels.Contains(tag))
                {
                    // Add the tag to detected channels if it's valid
                    detectedChannels.Add(tag);
                }
            }
            // Check if any valid channels were detected
            if (detectedChannels.Count > 0)
            {
                // Format the output to list all detected channels
                return $"Receive channels: {string.Join(", ", detectedChannels)}";
            }
            else
            {
                // If no valid channels were detected, return an informative message
                return "No valid notification channels detected.";
            }
        }
    }
}



using System;

using Eliza;

namespace ElizaMain
{
    /// <summary>
    /// The Eliza driver program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Initialize Eliza and greet the user
            ILogger logger = new ConsoleLogger();
            bool conversationOver = false;
            IEliza eliza = new Eliza.Eliza(logger);
            Console.WriteLine(eliza.WelcomeMessage);

            // Converse with the user until the conversation is over
            while (!conversationOver) {

                // Get the user's input
                Console.Write("> ");
                string input = Console.ReadLine().Trim();

                // If the input is a logging command, enable/disable logging.  Otherwise,
                // pass the input to Eliza.
                if (input.StartsWith("$")) {
                    switch(input.ToUpper()) {
                        case "$LON":
                            logger.EnableLogging(true);
                            Console.WriteLine("* LOGGING ENABLED" + Environment.NewLine);
                            break;
                        case "$LOFF":
                            logger.EnableLogging(false);
                            Console.WriteLine("* LOGGING DISABLED" + Environment.NewLine);
                            break;
                        default:                        
                            Console.WriteLine("* UNRECOGNIZED COMMAND" + Environment.NewLine);
                            break;
                    }
                }
                else {
                    Console.WriteLine(Environment.NewLine + eliza.GetResponse(input, out conversationOver));
                }
            }

            // Close window
            Console.WriteLine("\nPress ENTER to close window...");
            Console.ReadLine();
        }
    }
}












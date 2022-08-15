namespace DelegateASS
{
    internal class Program
    {
        /// <summary>
        /// Shows the timer.
        /// </summary>
        /// <param name="seenTime">The seen time.</param>
        public static void ShowTimer(int seenTime)
        {
            Console.WriteLine($"watched scenes is : {seenTime} ");
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            VideoPlayer.MovieWatch(ShowTimer);
            Console.ReadLine();

        }
    }
}
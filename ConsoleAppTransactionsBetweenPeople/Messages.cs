namespace ConsoleAppTransactionsBetweenPeople
{
    /// <summary>
    /// Сообщения
    /// </summary>
    internal class Messages
    {
        /// <summary>
        /// Сообщение string
        /// </summary>
        /// <param name="m"></param>
        public void M(string m)
        {
            Console.WriteLine("Message: " + m);
        }

        /// <summary>
        /// Сообщение int
        /// </summary>
        /// <param name="m"></param>
        public void M(int m)
        {
            Console.WriteLine("Message: " + m);
        }

        /// <summary>
        /// Оставить сообщение string
        /// </summary>
        /// <returns></returns>
        public string R()
        {
            return Console.ReadLine();
        }
    }
}

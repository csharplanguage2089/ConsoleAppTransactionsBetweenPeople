namespace ConsoleAppTransactionsBetweenPeople
{
    /// <summary>
    /// Люди
    /// </summary>
    internal class People
    {
        Messages messages = new Messages();

        /// <summary>
        /// Моё имя
        /// </summary>
        public string myName;

        /// <summary>
        /// Мои деньги
        /// </summary>
        public int myMoney;

        /// <summary>
        /// Полная информация о человеке и его средствах
        /// </summary>
        public void WriteMyInfo()
        {
            messages.M("- " + myName + " has " + myMoney + " bucks.");
        }
    }
}

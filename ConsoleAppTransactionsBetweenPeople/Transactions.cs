namespace ConsoleAppTransactionsBetweenPeople
{
    /// <summary>
    /// Транзакции
    /// </summary>
    internal class Transactions
    {
        Messages messages = new Messages();

        /// <summary>
        /// Выдача наличных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="argPeople"></param>
        /// <returns></returns>
        public int GiveOutCash(int a, People argPeople)
        {
            if (a == 0 || a < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                messages.M("Specify an amount greater than zero!");
                Console.ResetColor();
                return 0;
            }
            if (argPeople.myMoney >= a)
            {
                argPeople.myMoney = argPeople.myMoney - a;
                messages.M(argPeople.myName + " gives " + a + " bucks.");
                return a;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                messages.M(argPeople.myName + " does not possess " + a + " bucks.");
                Console.ResetColor();
                return 0;
            }
        }

        /// <summary>
        /// Получение наличных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="argPeople"></param>
        /// <returns></returns>
        public int ReceiveCash(int a, People argPeople)
        {
            if (a == 0)
            {
                return 0;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            messages.M("Thank you for your money, i have received: " + a + " bucks.");
            Console.ResetColor();
            argPeople.myMoney = argPeople.myMoney + a;
            return a;
        }
    }
}

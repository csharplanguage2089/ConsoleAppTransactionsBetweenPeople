namespace ConsoleAppTransactionsBetweenPeople
{
    /// <summary>
    /// Проверка введенных данных
    /// </summary>
    internal class Validations
    {
        Messages messages = new Messages();

        /// <summary>
        /// Аргументы функции CheckingForAName()
        /// Проверка на ввод существующих имен
        /// </summary>
        /// <param name="s">1-й аргумент s (обязательный)</param>
        /// <param name="argPeopleOne">2-й аргумент argPeopleOne (необязательный аргумент, значение по умолчанию null)</param>
        /// <param name="argPeopleTwo">3-й аргумент argPeopleTwo (необязательный аргумент, значение по умолчанию null)</param>
        /// <param name="argPeopleThree">4-й аргумент argPeopleThree (необязательный аргумент, значение по умолчанию null)</param>
        public string InputAndCheckingForAName(string s, People argPeopleOne = null, People argPeopleTwo = null, People argPeopleThree = null)
        {
            while (true)
            {
                s = messages.R();
                if (s == argPeopleOne.myName || s == argPeopleTwo.myName || s == argPeopleThree.myName)
                {
                    return s;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    messages.M("You entered the wrong name or the name does not exist!");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Проверка на ввод y или n
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string InputAndCheckingForYesOrNot(string s)
        {
            while (true)
            {
                s = messages.R();
                if (s == "y" || s == "n")
                {
                    return s;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    messages.M("Please, enter y or n.");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Проверка на ввод числа
        /// </summary>
        /// <param name="amountString"></param>
        /// <returns></returns>
        public int InputAndCheckingNumber(string amountString)
        {
            while (true)
            {
                amountString = messages.R();
                if (int.TryParse(amountString, out int amountInt))
                {
                    return amountInt;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    messages.M("Enter a number!");
                    Console.ResetColor();
                }
            }
        }
    }
}

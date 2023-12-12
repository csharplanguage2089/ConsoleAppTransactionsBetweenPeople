using ConsoleAppTransactionsBetweenPeople;

internal class Program
{
    private static void Main(string[] args)
    {
        Messages messages = new Messages();
        People peopleOne = new People();
        People peopleTwo = new People();
        People peopleThree = new People();
        Transactions transactions = new Transactions();
        Validations validations = new Validations();

        peopleOne.myName = "Andrey";
        peopleTwo.myName = "Anna";
        peopleThree.myName = "Smith";

        peopleOne.myMoney = 100;
        peopleTwo.myMoney = 100;
        peopleThree.myMoney = 100;

        int count = 0;

        while (true)
        {
            messages.M("Cash information at the beginning of the iteration:"); // Информация о денежных средствах в начале итерации
            peopleOne.WriteMyInfo();
            peopleTwo.WriteMyInfo();
            peopleThree.WriteMyInfo();

            if (count > 0)
            {
                // Выводить выбор завершения программы после первой итерации
                messages.M("Try again?");
                string endProgram = null;
                endProgram = validations.InputAndCheckingForYesOrNot(endProgram);
                if (endProgram == "n") { return; }
            }
            count++;

            messages.M("From whom?"); // От кого?
            string fromWhom = null;
            fromWhom = validations.InputAndCheckingForAName(fromWhom, peopleOne, peopleTwo, peopleThree);

            messages.M("To whom?"); // Кому?
            string toWhom = null;
            toWhom = validations.InputAndCheckingForAName(toWhom, peopleOne, peopleTwo, peopleThree);

            messages.M("How much to give out?"); // Сколько выдать?
            string amount = null;
            int amountInt;
            amountInt = validations.InputAndCheckingNumber(amount);

            int transaction = 0;

            if (fromWhom == peopleOne.myName) { transaction = transactions.GiveOutCash(amountInt, peopleOne); }
            if (fromWhom == peopleTwo.myName) { transaction = transactions.GiveOutCash(amountInt, peopleTwo); }
            if (fromWhom == peopleThree.myName) { transaction = transactions.GiveOutCash(amountInt, peopleThree); }

            if (toWhom == peopleOne.myName) { transactions.ReceiveCash(transaction, peopleOne); }
            if (toWhom == peopleTwo.myName) { transactions.ReceiveCash(transaction, peopleTwo); }
            if (toWhom == peopleThree.myName) { transactions.ReceiveCash(transaction, peopleThree); }
        }
    }
}

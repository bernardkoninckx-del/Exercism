static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0) return 3.213f;
        if (balance < 1000) return 0.5f;
        if (balance < 5000) return 1.621f;
        return 2.475f;
        
    }

    public static decimal Interest(decimal balance) =>
        balance * (decimal) InterestRate(balance)/100.0m;

    public static decimal AnnualBalanceUpdate(decimal balance) =>
        balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var tempBalance = balance;
        var occurs = 0;
        while (tempBalance < targetBalance){
            tempBalance = AnnualBalanceUpdate(tempBalance);
            occurs ++ ;
        }
        return occurs;
    }
}

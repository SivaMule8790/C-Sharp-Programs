using System;

public abstract class WithdrawalAmount{
    public abstract int withdraw(int n);
}
public class FixedAmount:WithdrawalAmount{
    private int FixedInitialAmount=100000;
    private int availableAmount;
    public override int withdraw(int n)
    {
        availableAmount=FixedInitialAmount-n;
        return availableAmount;
        
    }
}
public class Bank:FixedAmount{
    static void Main(){
        FixedAmount obj1=new FixedAmount();
        Console.WriteLine(obj1.withdraw(456));
    }
}


/*Consider a bank scenario where the user is having a fixed initial amount of 10000 which is defined in the class FixedAmount.
Create an abstract class named WithdrawalAmount with an abstract method withdraw which accepts an integer argument
Also in the main class Bank define the withdraw method which shows the available balance after withdrawal.
Sample Test Case:
Command line args 350
Maintain minimum balance10000
the available balance:9650
*/
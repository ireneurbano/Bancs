namespace Bancs.Classes;

public class Account
{
    public int id;
    private int user_id;
    public double balance;

    public Account(int id, int user_id, int balance)
    {
        this.id = id;
        this.user_id = user_id;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"S'ha ingressat {amount} corectament. El teu diposit es de {balance}");
        }
        else
        {
            Console.WriteLine("El diposit ha de ser positiu.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine($"No hi ha fons suficients.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"S'ha retirat {amount}. El teu saldo es: {balance}");
        }
    }

    public double CheckBalance()
    {
        return balance;
    }

    public bool CheckUser(int u_id)
    {
        return u_id == user_id;
    }
}
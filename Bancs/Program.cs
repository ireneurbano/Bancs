using System.Threading.RateLimiting;
using Bancs.Classes;

Account[] accounts = [new Account(1, 1, 10), new Account(2, 2, 1000), new Account(3, 1, 20000)];
User[] users = [new User(1, "Irene", "1234"), new User(2, "Eva", "abcd")];

//Main Loop
while (true){
    Console.Write($"ID usuari: ");
    int id_user = Convert.ToInt16(Console.ReadLine());
    if (id_user == -1){
        break;
    }
    Console.Write($"Contrasenya: ");
    string pass_user = Console.ReadLine()!;
    bool correct = false;

    foreach (User u in users){
        if (u.id == id_user && u.CheckPassword(pass_user)){
            correct = true;
            break;
        }
    }

    if (!correct){
        continue;
    }

    while (true){
        Console.Write("ID compte: ");
        int id_acc = Convert.ToInt16(Console.ReadLine());
        if(id_acc == -1)
        {
            break;
        }
        correct = false;
        foreach (Account a in accounts){
            if (a.id == id_acc && a.CheckUser(id_user))
            {
                correct = true;
                break;
            }
        }
        if (!correct)
        {
            continue;
        }
        while (true)
        {
            Console.Write($"Operation [1] Ingressar, [2] Retirar");
            string op = Console.ReadLine();
            if (op == "-1"){
                break;
            }
            if(op != "1" && op != "2")
            {
                continue;
            }
            Console.Write($"Quantitat: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (op == "1")
            {
                accounts[id_acc - 1].Deposit(amount);
            }
            else
            {
                accounts[id_acc - 1].Withdraw(amount);
            }
        }
    }
}
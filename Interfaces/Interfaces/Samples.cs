namespace Interfaces;

public abstract class Human
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }

    public override string ToString()
    {
        return $"Фамилия {LastName} \nИмя {Name}\nДень рождения {Birthday.ToLongDateString()}\n ";
    }

}

public abstract class Employee : Human
{
    public string Position { get; set; }
    public double Salary   { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Должность {Position}\nЗарплата {Salary}\n";
    }
    
}

public interface IWorker
{
    bool IsWorking { get; }
    string Work();
}

public interface IManager
{
    List<IWorker> ListOfWorkers { get; set; }
    void Organize();
    void Control();
    void MakeBudget();
}

class Director : Employee, IManager
{
    public List<IWorker> ListOfWorkers { get; set; }
    public void Organize()
    {
        Console.WriteLine("Организовывает");
    }

    public void Control()
    {
        Console.WriteLine("Контролирует");
    }

    public void MakeBudget()
    {
        Console.WriteLine("Бюджетирует");
    }
}

class Seller : Employee, IWorker
{
    private bool isWorking = true;

    public bool IsWorking
    {
        get
        {
            return isWorking;
        }
    }
    public string Work()
    {
        return $"Продаю товар";
    }
}

class Cashier : Employee, IWorker
{
    private bool isWorking = true;

    public bool IsWorking
    {
        get
        {
            return isWorking;
        }
    }
    public string Work()
    {
        return $"Принимаю оплату за товар";
    }
}

class Keeper: Employee, IWorker
{
    private bool isWorking = true;

    public bool IsWorking
    {
        get
        {
            return isWorking;
        }
    }
    public string Work()
    {
        return $"Выдаю товар";
    }
}
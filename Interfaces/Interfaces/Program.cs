using Interfaces;

Director director = new Director()
{
    LastName = "Иванов ",
    Name = "Петр",
    Birthday = new DateTime(1990, 9, 9),
    Position = "директор",
    Salary = 1000

};

IWorker seller = new Seller()
{
    LastName = "Димилин",
    Name = "Димка",
    Birthday = new DateTime(1999, 9, 9),
    Position = "продавец",
    Salary = 12.9

};

if (seller is Employee )
{
    Console.WriteLine($"Зарплата продавца : {(seller as Employee).Salary} ");
    
}



director.ListOfWorkers = new List<IWorker>()
{
    seller,
    new Cashier
    {
        LastName = "Димилин1",
        Name = "Димка1",
        Birthday = new DateTime(1999, 9, 9),
        Position = "кассир",
        Salary = 2.9


    },
    new Keeper()
    {
        LastName = "Димилин",
        Name = "Димка2",
        Birthday = new DateTime(1999, 9, 9),
        Position = "кладовщик",
        Salary = 1.9

    }

};    
    
Console.WriteLine(director);

if (director is IManager)
{
   director.Control(); 
}


foreach (IWorker i in director.ListOfWorkers)
{   Console.WriteLine(i);
    if (i.IsWorking)
    Console.WriteLine(i.Work());
}
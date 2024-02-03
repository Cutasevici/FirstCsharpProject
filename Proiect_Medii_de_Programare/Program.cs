using Proiect_Medii_de_Programare.HR;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Manager dan = new Manager("Dan", "Cutasevici", "dan@example.com", new DateTime
    (1992, 7, 2), 25);

dan.DisplayEmployeeDetails();

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee iulica = new("Iuliana", "Gusan", "gusan@example.com", new DateTime(1994, 5, 8),
    30);

iulica.DisplayEmployeeDetails();

Console.WriteLine("Creating an employee of type Manager");
Console.WriteLine("-------------------------------------\n");

Manager anatol = new Manager("Anatol", "Liberalu", "liberalu@example.com",
    new DateTime(1972,10,23),40);

anatol.DisplayEmployeeDetails();
anatol.PerformWork(25);
anatol.PerformWork();
anatol.ReceiveWage();
anatol.AttendManagerMeeting();


Console.WriteLine("Creating a junior researcher");
Console.WriteLine("----------------------------\n");

JuniorReasercher ala = new JuniorReasercher("Ala", "Bulibasa", "ala@example.com",
    new DateTime(1965, 9, 23),15);

ala.ResearchNewThing(5);
ala.ResearchNewThing(5);

Console.WriteLine("Creating an Employee with an address");
Console.WriteLine("------------------------------------\n");

Employee vlad = new Employee("Vlad", "Moldovan", "md@example.com", new DateTime(1993, 9, 4), 10,
    "Covasna street", "123", "123456", "Anenii noi");

Console.WriteLine("Creating an interface type");
Console.WriteLine("--------------------------\n");

IEmployee catea = new StoreManager("Ecaterina", "Sarmatova", "catea@example.com",
    new DateTime(1993, 12, 9), 17);



List<Employee> employees = new List<Employee>();
employees.Add(vlad);
employees.Add(ala);
employees.Add(anatol);
employees.Add(iulica);
employees.Add(dan);

foreach(Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
}








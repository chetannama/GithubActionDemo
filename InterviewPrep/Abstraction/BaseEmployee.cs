
namespace InterviewPrep.Abstraction;

public abstract class BaseEmployee
{
    /* if we create two classes with almost same functionality then code maintainablity is the issue */

    /* If we apply the virtual and override concept (Function Overriding) then there will be posibility to instantiate the base class
     * and if anybody can able to create object of this BaseEmployee class it breaks the concept because no such object is present in 
     * the real world
     */

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public BaseEmployee()
    {
        Console.WriteLine("Yes! Abstract class can have a constructor and can not make it abstract");
    }
    
    ~BaseEmployee()
    {
        Console.WriteLine("Destructor");
    }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public abstract double MonthlySalary();
}

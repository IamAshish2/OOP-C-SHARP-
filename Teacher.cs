class Teacher
{
    private int teacherId;
    private String? teacherName;
    private String? address;
    private String? workType;
    private string? employmentStatus;
    private int workingHours;

    public static void Main(string[] args)
    {
        Lecturer lecturer = new Lecturer(101, "Dr. John Smith", 
        "1234 Elm Street", "Full-Time", "Permanent", "Computer Science",
         10, 40);
         lecturer.GradedScore = 30;
         int gradedScore = lecturer.GradedScore;
         Console.WriteLine(gradedScore);
    }

    public Teacher(int teacherId, String teacherName,
    String address, String workType, String employmentStatus)
    {
        this.teacherId = teacherId;
        this.teacherName = teacherName;
        this.address = address;
        this.workType = workType;
        this.employmentStatus = employmentStatus;
        workingHours = 0;
    }

    /*
    public void setWorkingHours(int workingHours)
    {
        this.workingHours = workingHours;
    }
    */

    public int WorkingHours{
        get {return workingHours;}
        set {workingHours = value;}
    }

    public virtual void display()
    {
        Console.WriteLine($"The teacher Name is {teacherName}");
        Console.WriteLine($"The {teacherName}'s id is {teacherId}");
        Console.WriteLine($"The {teacherName}'s address is {address}");
        Console.WriteLine($"The working Type of the {teacherName} is {workType}");    
        Console.WriteLine($"The employment Status of the {teacherName} is {employmentStatus}");
        if(workingHours == 0){
            Console.WriteLine($"The working hours is yet to be assigned for {teacherName}.");
        }else{
             Console.WriteLine($"The working hours of the {teacherName} is {workingHours}.");
        }
       
    }
}
class Tutor:Teacher{

    private double salary;
    private String? specialization;
    private String? academicQualifications;
    private int performanceIndex;
    private bool isCertified;

    public Tutor(int teacherId, String teacherName,
    String address, String workType, String employmentStatus,double salary,String specialization,String academicQualificatons,int performanceIndex,int workingHours)
     :base(teacherId,teacherName,address,workType,employmentStatus){

        // base.setWorkingHours(workingHours);
        base.WorkingHours = workingHours;
        this.salary = salary;
        this.specialization = specialization;
        this.academicQualifications = academicQualificatons;
        this.performanceIndex = performanceIndex;
        this.isCertified = false;
    }

      public double Salary{
        get{return salary;}
    }

      public String? AcademicQualifications{
        get{return academicQualifications;}
    }

    public int PerformanceIndex{
        get{return performanceIndex;}
    }

    public bool IsCertified{
        get{return isCertified;}
    }

    public void setSalary(double salary,double performanceIndex){
        double appraisal = 0;
        if(performanceIndex >= 5 && base.WorkingHours > 20 ){
            if(performanceIndex >=5 && performanceIndex <=7){
                appraisal = 5 / 100 * salary;
                salary += appraisal;
            } else if(performanceIndex >=8 && performanceIndex <=9){
                appraisal = 10 / 100 * salary;
                salary += appraisal;
            } else if(performanceIndex >=10){
                appraisal = 20/100 * salary;
                salary += appraisal;
            }
            this.isCertified = true;
        } else{
            Console.WriteLine("Sorry, the tutor is not certified for salary appraisal.");
        }
    }


    public void removeTutor(){
        if(this.isCertified == false){
            this.salary = 0;
            this.academicQualifications = "";
            this.performanceIndex = 0;
        } else{
            Console.WriteLine("The tutor is certified and cannot be removed.");
        }
    }


    public override void display(){

        if(isCertified == true){
            Console.WriteLine($"The salary of the Tutor is {this.salary}"); 
            Console.WriteLine($"The specialization of the Tutor is {this.specialization}");
            Console.WriteLine($"The performance index of the Tutor is {this.performanceIndex}");
        }
        base.display();
    }
}
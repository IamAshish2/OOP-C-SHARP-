
class Lecturer:Teacher{

    private String? department;
    private int yearsOfExperience;
    private int gradedScore;
    private bool hasGraded;


    public Lecturer(int teacherId,String teacherName,String address,String workType,
    String employmentStatus,String department,int yearsOfExperience,int workingHours)
     :base(teacherId,teacherName,address,workType,employmentStatus){
        this.yearsOfExperience = yearsOfExperience;
        this.department = department;
       gradedScore = 0;
        this.hasGraded = false;
        base.WorkingHours =workingHours ;
    }    


    public int GradedScore{
        get{return gradedScore;}
        set{gradedScore = value;}
    }

    public String? Department{
        get{return department;}
    }

    public int YearsOfExperience{
        get{return yearsOfExperience;}

    }

        public bool HasGraded{
        get{return hasGraded;}
        set{hasGraded = value;}
    }

    public void gradeAssignment(int gradedScore,String department,int yearsOfExperience){
        if(yearsOfExperience >= 5 && this.department == department){

            HasGraded = true;

            if(gradedScore > 70 && gradedScore <=100){
                Console.WriteLine("You scored an A.");
            } else if(gradedScore <=70 && gradedScore >60   ){
                Console.WriteLine("You scored an B.");
            } else if(gradedScore <=60 && gradedScore >50){
                Console.WriteLine("You scored an C.");
            } else if(gradedScore <=50 && gradedScore >40){
                Console.WriteLine("You scored an D.");
            }else if(gradedScore <=40 && gradedScore >=0){
                Console.WriteLine("You scored an E.");
            }
        }
    }

    public override void display() {
        base.display();
       Console.WriteLine($"The department of the teacher is ${department}");
       Console.WriteLine($"The years of Experience of the teacher is ${yearsOfExperience}");
       if(hasGraded){
         Console.WriteLine($"The graded Score of the student is {gradedScore}");
       } else{
        Console.WriteLine("The teacher is yet to grade the score of the student.");
       }
      
    }
}
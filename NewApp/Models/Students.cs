 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        public Students ()
        {
            Name = "ho ten mac dinh";
            Address ="Ha noi";
            StudentID ="1921050280";
        }
        public int GetYearOfBirth(int age)
    {
        int yearOfBirth = 2023-age;
        return yearOfBirth;
    }   
 }
 } 
namespace Unit1Project.Models
{/// <summary>
/// 
/// </summary>
    public class Birthdate
    {
        public DateTime BirthDate { get; set; }
        public int Age => CalculateAge();


        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;


            // If statement
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;



        }
    }
}

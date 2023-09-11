namespace Unit1Project.Models
{
    public class BirthDate
    {
        public DateTime BirthDate { get; set; }
        public int Age => CalculateAge();


        private int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;


            // If statement
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;



        }
    }
}

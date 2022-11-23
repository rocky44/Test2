namespace Test2.Models
{
    public class Display
    {
        public IList<StudentsInClass> StudentsInClass { get; set; } = new List<StudentsInClass>();
        public IList<StudentsInCountry> StudentsInCountry { get; set; } = new List<StudentsInCountry>();
        public int AvgAge { get; set; }
    }

    public class StudentsInClass
    {
        public int ClassId { get; set; }
        public int StudentCount { get; set; }
    }

    public class StudentsInCountry
    {
        public int CountryId { get; set; }
        public int StudentCount { get; set; }
    }
}

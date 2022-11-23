namespace Test2.Models
{
    public class Students
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
    }
}

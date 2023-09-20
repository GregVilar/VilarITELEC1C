namespace VilarITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProf, Prof
    }

    public enum IsTenured
    {
        True, False
    }

    public class Instructor
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiringDate { get; set; } 

        public Rank Rank { get; set; }  
        public IsTenured IsTenured { get; set; }

    }
}

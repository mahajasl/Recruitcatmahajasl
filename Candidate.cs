namespace RecruitCatmahajasl.models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public bool IsCompleted { get; set; }
        public string Gender { get; set; }

        public decimal TargetSalary { get; set; }
        public DateTime StartDate { get; set; }

    }
}

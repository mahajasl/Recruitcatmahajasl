namespace RecruitCatmahajasl.models
{
    public class Company
    {
        public int CompanyID { get; set; }  
        public string CompanyName { get; set; }     
        public int CompanyTypeID { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public string Location { get; set; }
        public string PositionName { get; set; }
        public string CompanyOfficeLocation { get; set; }



    }
}

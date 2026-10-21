namespace StepanovaValeriyaKt_42_23.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
       
        public int SpecialnostId { get; set; }
        public Specialnost Specialnost { get; set; }
        public bool IsDeleted { get; set; } // Флаг логического удаления
        public int Course { get; set; }
    }
}
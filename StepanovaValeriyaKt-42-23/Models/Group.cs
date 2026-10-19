namespace StepanovaValeriyaKt_42_23.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool IsDeleted { get; set; } // Флаг логического удаления
    }
}
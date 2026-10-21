using System.Collections.Generic;

namespace StepanovaValeriyaKt_42_23.Models
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<Grade> Grades { get; set; }
    }
}

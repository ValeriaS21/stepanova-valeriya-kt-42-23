using System.Collections.Generic;

namespace StepanovaValeriyaKt_42_23.Models
{
    public class Specialnost
    {
        public int SpecialnostId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public List<Group> Groups { get; set; }
    }
}
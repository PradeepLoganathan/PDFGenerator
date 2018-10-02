using System;
using System.Collections.Generic;

namespace BestCV.JobSeeker.Models.Schooling
{
    public class MarksCard
    {
        public Guid MarkCardID { get; set; }
        public string RegistrationNumber { get; set; }
        public List<Subject> SubjectMarks { get; set; }
        public DateTime ExamDate { get; set; }
        public double PercentageObtained { get; set; }
        public bool IsVerified { get; set; }
    }
}

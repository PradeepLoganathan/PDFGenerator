namespace BestCV.JobSeeker.Models
{
    /*public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Core.Candidate, Domain.Core.Candidate>();        
            CreateMap<Models.Core.Candidatename, Domain.Core.CandidateName>();
            CreateMap<Models.Core.Aadhaar, Domain.Core.Aadhar>();            
            CreateMap<Models.Core.Emailid, Domain.Core.EmailID>().ConstructUsing(s=> new Domain.Core.EmailID(s.EmailID));
            CreateMap<Models.Core.MobileNumber, Domain.Core.MobileNumber>();
            CreateMap<Models.Core.MobileNumbers, Domain.Core.MobileNumbers>();
            CreateMap<Models.Work.NoticePeriod, Domain.Work.NoticePeriod>();
            CreateMap<Models.Schooling.Education, Domain.Schooling.Education>();
            CreateMap<Models.Work.EmploymentType, Domain.Work.EmploymentType>();

            Guid AddressId = Guid.NewGuid();
            CreateMap<Models.Location.Address, Domain.Location.Address>().ConstructUsing(s => new Domain.Location.Address(AddressId, s.Line1,s.Line2, s.City, s.State, s.Country, s.Zip));
            CreateMap<Models.Work.Company, Domain.Work.Company>().ConstructUsing(S => new Domain.Work.Company(S.Name, S.Location, S.ROCID, S.Logo));
            //CreateMap<Models.Work.WorkExperience, Domain.Work.WorkExperience>()
            //    .ConstructUsing(
            //    s => new Domain.Work.WorkExperience
            //            (new Domain.Work.Company(s.Company.Name,s.Company.Location, s.Company.ROCID, s.Company.Logo), 
            //                s.StartDate, s.EndDate, s.Designation, 
            //                new Domain.Skills.Skill(s.skill.Name, s.skill.Description, new Domain.Skills.SkillRating(new Domain.Skills.Rating(), s.skill.Description)),
            //                s.Salary, new Domain.Work.EmploymentType()));
            







        }
    }*/
}

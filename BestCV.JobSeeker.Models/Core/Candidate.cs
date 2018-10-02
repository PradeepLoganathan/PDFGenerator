using System;
using BestCV.JobSeeker.Models.Extra;
using BestCV.JobSeeker.Models.Location;
using BestCV.JobSeeker.Models.Schooling;
using BestCV.JobSeeker.Models.Work;
using BestCV.JobSeeker.Models.Skills;
namespace BestCV.JobSeeker.Models.Core
{
    public class Candidate
    {
        public Candidate()
        {
            this.CandidateName = new CandidateName();

        }

        public Guid CandidateId { get; set; }
        public AvatarSet AvatarSet { get; set; }
        public CandidateName CandidateName { get; set; }
        public CandidateTag CandidateTag { get; set; }
        public CandidateProfile CandidateProfile { get; set; }
        public EmailIDs EmailIDs { get; set; }
        public MobileNumbers MobileNumbers { get; set; }
        public Address ResidentialAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public Aadhaar AadhaarID { get; set; }
        public NoticePeriod NoticePeriod { get;  set; }
        public Career Career { get; set; }
        public double CurrentSalary { get; set; }
        public string DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public Education Education { get; set; }
        public PreferredJobLocations PreferredJobLocations { get; set; }
        public SkillSet Skillset { get; set; }
        public Hobbies Hobbies { get; set; }
        public Languages Languages { get; set; }
        public References References { get; set; }
        public PersonalSkillSet PersonalSkillSet { get; set; }
        public Achievements Achievements { get; set; }
        public Highlights Highlights { get; set; }
        public Visas Visas { get; set; }
        public string FavouriteQuotes { get; set; }
        public SocialProfiles SocialProfiles { get; set; }
        public ShareableProfile ShareableProfile { get; set; }
        public Achievements WorkAchievements { get; set; }
        //public object JobApplications { get; set; }
        //public object SubscriptionPlans { get; set; }
        //public object Notifications { get; set; }
    }

}


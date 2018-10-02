using System;
using System.Collections.Generic;
using System.Text;

namespace BestCV.JobSeeker.Models.Core
{
    public class AvatarSet
    {
        public AvatarSet()
        {
            Avatar = new List<Core.Avatar>();
        }
        public List<Avatar> Avatar { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{
    public class CommunityViewModel
    {
        public IEnumerable<Student> Student { get; set; }
        public IEnumerable<Community> Community { get; set; }
        public IEnumerable<CommunityMembership> CommunityMembership { get; set; }

    }
}
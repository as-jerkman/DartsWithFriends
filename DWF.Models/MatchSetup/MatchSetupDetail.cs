﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWF.Models.MatchSetup
{
    public class MatchSetupDetail
    {
        public int MatchSetupId { get; set; }
        public string PlayerOneEmail { get; set; }
        public string PlayerTwoEmail { get; set; }
        public int NumberOfSets { get; set; }
        public int NumberOfLegs { get; set; }
    }
}

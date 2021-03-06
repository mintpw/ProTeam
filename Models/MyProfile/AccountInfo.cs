﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTeam.Models
{
    public class AccountInfo
    {
        public int Id { get; set; }
        public int LastMatchDateTime { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string ProfileUri { get; set; }
        public int SoloRank { get; set; }
        public int PartyRank { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class SearchLkSections
    {
        public int Id { get; set; }
        public string? SectionType { get; set; }
        public string? Section { get; set; }
        public DateTime? Createdate { get; set; }
        public string? Createuser { get; set; }
        public string? Status { get; set; }
        public int? Sortby { get; set; }

        public DateTime? Moddate { get; set; }
        public string? Moduser { get; set; }

    }
}

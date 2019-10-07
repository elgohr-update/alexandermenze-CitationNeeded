﻿using System.Collections.Generic;

namespace CitationNeeded.Domain.ValueTypes
{
    public class CitationBook
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<CitationGroup> CitationGroups { get; set; }
    }
}

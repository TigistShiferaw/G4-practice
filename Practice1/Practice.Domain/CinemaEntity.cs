using Practice.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Domain
{
    public class CinemaEntity:BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactInformation { get; set; }
    }
}

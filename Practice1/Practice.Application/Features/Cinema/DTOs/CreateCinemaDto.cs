using Practice.Application.Features.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Application.Features.Cinema.DTOs
{
    public class CreateCinemaDto: BaseDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string ContactInformation { get; set; }
    }
}

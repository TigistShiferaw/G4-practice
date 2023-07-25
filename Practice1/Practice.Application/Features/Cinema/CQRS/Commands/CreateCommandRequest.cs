using MediatR;
using Practice.Application.Features.Cinema.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Application.Features.Cinema.CQRS.Commands
{
    
        public class CreateCinemaCommandRequest : IRequest<int>
        {
            public CreateCinemaDto CreateCinemaDto { get; set; }
        }
    
}

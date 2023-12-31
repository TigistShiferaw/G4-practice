﻿
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Practice.API.Controllers
{
    [Route("api/[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CinemaController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}

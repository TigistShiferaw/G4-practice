using AutoMapper;
using MediatR;
using Practice.Application.Contract;
using Practice.Application.Features.Cinema.CQRS.Commands;
using Practice.Application.Features.Cinema.DTOs.Vallidators;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.Application.Features.Cinema.CQRS.Handlers
{
    public class CreateCommandRequestHandler : IRequestHandler<CreateCinemaCommandRequest, int>
    {
        private readonly IMapper _mapper;
        private readonly ICinemaRepository _cinemaRepository;
        public CreateCommandRequestHandler(IMapper mapper, ICinemaRepository cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
            _mapper = mapper;
            
        }

        public async Task<int> Handle(CreateCinemaCommandRequest request, CancellationToken cancellationToken)
        {
            var validator = new CreateCinemaDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CreateCinemaDto);

            if (validationResult.IsValid == false)
                throw new Exception();
            var cinema = _mapper.Map<CinemaEntity>(request.CreateCinemaDto);
            cinema = await _cinemaRepository.Add(cinema);
            return cinema.Id;
        }
    }
}

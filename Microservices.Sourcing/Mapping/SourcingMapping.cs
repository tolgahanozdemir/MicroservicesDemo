using AutoMapper;
using EventBusRabbitMQ.Events;
using Microservices.Sourcing.Entities;

namespace Microservices.Sourcing.Mapping
{
    public class SourcingMapping : Profile
    {
        public SourcingMapping()
        {
            CreateMap<OrderCreateEvent, Bid>().ReverseMap();
        }
    }
}

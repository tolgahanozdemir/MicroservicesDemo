﻿using AutoMapper;
using EventBusRabbitMQ.Events;
using Ordering.Application.Commands.OrderCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Order.Mapping
{
    public class OrderMapping : Profile
    {
        public OrderMapping()
        {
            CreateMap<OrderCreateEvent, OrderCreateCommand>().ReverseMap();
        }
    }
}

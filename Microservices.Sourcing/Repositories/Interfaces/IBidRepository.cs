﻿using Microservices.Sourcing.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Sourcing.Repositories.Interfaces
{
    public interface IBidRepository
    {
        Task SendBid(Bid bid);
        Task<List<Bid>> GetBidsByAuctionId(string id);
        Task<List<Bid>> GetAllBidsByAuctionId(string id);
        Task<Bid> GetWinnerBid(string id);
    }
}

﻿using Domain.Entities;
namespace Domain.Interfaces
{
    public interface ITagRepository : IRepository<Tag>
    {
        IEnumerable<Tag> GetByVendor(Vendor vendor);
    }
}
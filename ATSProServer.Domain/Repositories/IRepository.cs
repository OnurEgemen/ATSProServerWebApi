﻿using ATSProServer.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain.Repositories
{
    public interface IRepository<T>
        where T : Entity
    {
        void SetDbContextInstance(DbContext context);
        DbSet<T> Entity { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        DbSet<TEntity> Table { get; }
    }
}

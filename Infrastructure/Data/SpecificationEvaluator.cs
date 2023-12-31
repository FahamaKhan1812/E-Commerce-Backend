﻿using Core.Entities;
using Core.Specification;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
{
    public static IQueryable<TEntity> GetQueries(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specifications)
    {
        var query = inputQuery;
        if(specifications.Criteria != null)
        {
            query = query.Where(specifications.Criteria);
        }
        query = specifications.Includes.Aggregate(query, 
            (current, include) => current.Include(include)
        );

        return query;
    }
}

﻿using System;
using DbManagementSystem.Core.Database;

namespace DbManagementSystem.Core.Query.Executors.DatabaseQueryExecutors
{
    class CreateDatabaseQueryExecutor : IQueryExecutor
    {
        public IQueryResult Execute(IDatabaseConnection databaseConnection, IQuery query)
        {
            throw new NotImplementedException();
        }

        public bool MatchesQuery(IQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
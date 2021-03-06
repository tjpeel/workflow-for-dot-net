﻿using System.Data.Common;

namespace FergusonMoriyam.Workflow.Interfaces.Infrastructure
{
    public interface IDatabaseHelper
    {
        string IdentityQuery { get; }

        DbTransaction BeginTransaction();

        DbCommand CreateCommand(string text);
        DbParameter CreateParameter(string name, object value);

        void CloseConnection();
    }
}

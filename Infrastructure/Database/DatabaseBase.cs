using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database
{
    public abstract class DatabaseBase
    {
        protected string _connectionString;

        public DatabaseBase()
        {
            Config();
        }

        protected abstract void Config();
        protected abstract void Connect();
        public abstract void ExecuteCommand(string query);
        public abstract List<T> Query<T>(string query) where T : EntityBase;
    }
}

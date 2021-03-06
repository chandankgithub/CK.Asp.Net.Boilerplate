﻿using CK.ABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CK.ABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly ABPDbContext _context;

        public InitialHostDbBuilder(ABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}

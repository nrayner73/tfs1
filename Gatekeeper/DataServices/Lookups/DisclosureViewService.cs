﻿using Gatekeeper.Interfaces;
using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Gatekeeper.DataServices.Lookups
{

    public class DisclosureViewService : IDisclosureViewService
    {
        private LookupDbContext _context;
        public DisclosureViewService(LookupDbContext context) {
            _context = context;
        }

        public async Task<IEnumerable<LocationViewitem>> GetLocationitemsList(int fileid)
        {

            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? (object)DBNull.Value : fileid };
            List<LocationViewitem> items = new List<LocationViewitem>();

            items = _context?.LocationViewitems.FromSqlRaw("Execute [gkp].[Getlocationitems] @fileid", parms).ToList();

            return items;
        }

        public async Task<IEnumerable<DisclosedViewitem>> GetDiscloseditemsList(int fileid)
        {

                  SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? (object)DBNull.Value : fileid };
            List<DisclosedViewitem> items = new List<DisclosedViewitem>();
        
            items = _context?.DisclosedViewitems.FromSqlRaw("Execute [gkp].[GetDisclosureitems] @fileid", parms).ToList();

            return items;
        }

        public async Task<IEnumerable<Summarydisclosure>> GetDisclosureSummary(int fileid)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? (object)DBNull.Value : fileid };
            IEnumerable<Summarydisclosure> items = new List<Summarydisclosure>();

            items = _context?.Summarydisclosures.FromSqlRaw("Execute [gkp].[GetDisclosureSummary] @fileid", parms).ToList();

            return items;
            

        }
    }
}

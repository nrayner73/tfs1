﻿using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchmytaskService : ISearchmytaskService
    {
        private LookupDbContext _context;
        public SearchmytaskService(LookupDbContext context)
        {
            _context = context;
        }

        public List<Searchmytask> GetMytaskList(Searchmytask searchfilter)
        {
            // var prmRegno = new SqlParameter { ParameterName = "@regno", Value = string.IsNullOrEmpty(regno) ? (object)DBNull.Value : regno };
            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@regno",Value = string.IsNullOrEmpty(searchfilter.Regno) ? (object)DBNull.Value : searchfilter.Regno } ,
                new SqlParameter { ParameterName = "@id",Value = searchfilter.Id ==  0 ? (object)DBNull.Value : searchfilter.Id } ,
                new SqlParameter { ParameterName = "@yearid",Value = searchfilter.Yearid == null ? (object)DBNull.Value : searchfilter.Yearid  } ,
                new SqlParameter { ParameterName = "@fileyear",Value = searchfilter.Fileyear  == null ? (object)DBNull.Value : searchfilter.Fileyear } ,
                new SqlParameter { ParameterName = "@filenumber",Value = string.IsNullOrEmpty(searchfilter.Filenumber) ? (object)DBNull.Value : searchfilter.Filenumber } ,
                new SqlParameter { ParameterName = "@requestdate",Value = searchfilter.Requestdate == null ? (object)DBNull.Value : searchfilter.Requestdate } ,
                new SqlParameter { ParameterName = "@receivefromdate",Value = searchfilter.Receivedate == null ? (object)DBNull.Value : searchfilter.Receivedate } ,
                new SqlParameter { ParameterName = "@receivetodate",Value = searchfilter.Receivedate == null ? (object)DBNull.Value : searchfilter.Receivedate } ,
                new SqlParameter { ParameterName = "@requestduedate",Value = searchfilter.Requestduedate == null ? (object)DBNull.Value : searchfilter.Requestduedate } ,
                new SqlParameter { ParameterName = "@referencenumber",Value = string.IsNullOrEmpty(searchfilter.Referencenumber) ? (object)DBNull.Value : searchfilter.Referencenumber } ,
                new SqlParameter { ParameterName = "@statusnote",Value = string.IsNullOrEmpty(searchfilter.Statusnote) ? (object)DBNull.Value : searchfilter.Statusnote } ,
                new SqlParameter { ParameterName = "@requesttypeid",Value = searchfilter.Requesttypeid == null ? (object)DBNull.Value : searchfilter.Requesttypeid } ,
                new SqlParameter { ParameterName = "@requesttype",Value = string.IsNullOrEmpty(searchfilter.Requesttype) ? (object)DBNull.Value : searchfilter.Requesttype} ,
                new SqlParameter { ParameterName = "@analystassignedid",Value = searchfilter.Analystassignedid == null ? (object)DBNull.Value : searchfilter.Analystassignedid } ,
                new SqlParameter { ParameterName = "@requeststateid",Value = searchfilter.Requeststateid == null ? (object)DBNull.Value : searchfilter.Requeststateid } ,
                new SqlParameter { ParameterName = "@personid",Value = searchfilter.PersonId== null ? (object)DBNull.Value : searchfilter.PersonId } ,
                new SqlParameter {ParameterName = "@personname",Value = searchfilter.Personname== null ? (object)DBNull.Value : searchfilter.Personname } ,
                new SqlParameter { ParameterName = "@email",Value = string.IsNullOrEmpty(searchfilter.Email) ? (object)DBNull.Value : searchfilter.Email } ,
                new SqlParameter { ParameterName = "@daytimephone",Value = string.IsNullOrEmpty(searchfilter.Daytimephone) ? (object)DBNull.Value : searchfilter.Daytimephone } ,
                new SqlParameter { ParameterName = "@poiname",Value = string.IsNullOrEmpty(searchfilter.PersonOfInterest) ? (object)DBNull.Value : searchfilter.PersonOfInterest } ,
                new SqlParameter { ParameterName = "@requestdetails",Value = string.IsNullOrEmpty(searchfilter.Requestdetails) ? (object)DBNull.Value : searchfilter.Requestdetails } ,
                new SqlParameter { ParameterName = "@intakenotes",Value = string.IsNullOrEmpty(searchfilter.Intakenotes) ? (object)DBNull.Value : searchfilter.Intakenotes }
             };

            List<Searchmytask> mytasklist = new List<Searchmytask>();
            mytasklist = _context?.MytaskfileInfos.FromSqlRaw("EXECUTE [gkp].[getMyTasks] " +
            " @regno, " +
            " @id, " +
            " @yearid, " +
            " @fileyear, " +
            " @filenumber, " +
            " @requestdate, " +
            " @requestduedate, " +
            " @receivefromdate, " +
            " @receivetodate, " +
            " @referencenumber, " +
            " @statusnote, " +
            " @requesttypeid, " +
            " @requesttype, " +
            " @analystassignedid, " +
            " @requeststateid, " +
            " @personid, " +
            " @personname, " +
            " @email, " +
            " @daytimephone, " +
            " @poiname, " +
            " @requestdetails, " +
            " @intakenotes ", parms.ToArray()).ToList();
           
            return mytasklist;
        }
    }
}

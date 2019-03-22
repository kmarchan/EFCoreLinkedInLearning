using System;
using System.Linq;
using DataAccessLayer.EfStructures.Context;
using DataAccessLayer.EfStructures.Entities;
using DataAccessLayer.EfStructures.Extensions;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace DataAccessLayerTests.A_QueryingData.B_GeneratedSQLAndLogging
{
    public class GeneratedSqlTests : IDisposable
    {
        private readonly AdventureWorksContext _context;

        public GeneratedSqlTests()
        {
            _context = new AdventureWorksContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        [Fact]
        public void ShouldGetSqlWithSimpleQuery()
        {
            IQueryable<Product> query = _context.Product;
            string generatedSql = query.ToSql();
            var foo = "foo";
        }

        [Fact]
        public void GetGeneratedSqlFromLinqStatement()
        {
            var query = _context.Product.Where(x => x.MakeFlag ?? true)
                .OrderBy(x => x.Name)
                .Skip(25).Take(25)
                .Include(x=>x.TransactionHistory);
            var result = query.ToList();
        }

    }
}
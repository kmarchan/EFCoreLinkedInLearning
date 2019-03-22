using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.EfStructures.Context;
using DataAccessLayer.EfStructures.Entities;
using DataAccessLayer.EfStructures.Extensions;
using Xunit;

namespace DataAccessLayerTests.A_QueryingData.C_FilterSortAndPage
{
    public class FilterTests : IDisposable
    {
        private readonly AdventureWorksContext _context;

        public FilterTests()
        {
            _context = new AdventureWorksContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
        [Fact]
        public void ShouldFindWithPrimaryKey()
        {
            Product prod = _context.Product.Find(3);
            Assert.Equal("BB Ball Bearing", prod.Name,ignoreCase:true);
            //This will not execute a query, since entity is already tracked
            Product prod2 = _context.Product.Find(3);
            Assert.Equal("BB Ball Bearing", prod.Name, ignoreCase: true);
        }
        [Fact]
        public void ShouldReturnNullIfPrimaryKeyIsNotFound()
        {
            Product prod = _context.Product.Find(-1);
            Assert.Null(prod);
        }
        [Fact]
        public void FilteringResultsWithFindComplexKey()
        {

            ProductVendor productVendor = _context.ProductVendor.Find(2, 1688);
            Assert.Equal(5, productVendor.MaxOrderQty);
            Assert.Equal(3, productVendor.OnOrderQty);
			
        }

        [Fact]
        public void FilterWithSimpleWhereClause()
        {
        }
        [Fact]
        public void FilterWithMultipleStatementWhereClauses()
        {
        }

        [Fact]
        public void FilterWithBuildingWhereClauses()
        {
        }

        [Fact]
        public void SHouldBeCarefulWithOrClauses()
        {
        }
        [Fact]
        public void FilterWithListOfIds()
        {
        }

        [Fact]
        public void ShouldGetTheFirstRecord()
        {
        }

        [Fact]
        public void ShouldThrowWhenFirstFails()
        {
        }

        [Fact(Skip="Executes client side")]
        public void ShouldGetTheLastRecord()
        {
        }
        [Fact]
        public void ShouldReturnNullWhenRecordNotFound()
        {
        }

        [Fact]
        public void ShouldReturnJustOneRecordWithSingle()
        {
        }
        [Fact]
        public void ShouldFailIfMoreThanOneRecordWithSingle()
        {
        }

    }

}

﻿

using Microsoft.OData;

namespace Community.OData.Linq.xTests
{
    using Community.OData.Linq.xTests.SampleData;
    using Xunit;
    using System.Linq;

    public class FilterDataContractTests
    {
        [Fact]
        public void WhereById()
        {
            var result = SimpleClassDataContract.CreateQuery().OData().Filter($"{nameof(SimpleClassDataContract.Id)} eq 1").ToArray();

            Assert.Single(result);
            Assert.Equal(1, result[0].Id);
        }

        [Fact]
        public void WhereByChangedName()
        {
            var result = SimpleClassDataContract.CreateQuery().OData().Filter("nameChanged eq 'n1'").ToArray();

            Assert.Single(result);
            Assert.Equal(1, result[0].Id);
        }

        [Fact]
        public void WhereByIgnoredMemberThrowException()
        {
            Assert.Throws<ODataException>(() => SimpleClassDataContract.CreateQuery().OData()
                .Filter($"{nameof(SimpleClassDataContract.NameToIgnore)} eq 'ign1'"));
        }

        [Fact]
        public void WhereByNotMarkedThrowException()
        {
            Assert.Throws<ODataException>(() => SimpleClassDataContract.CreateQuery().OData()
                .Filter($"{nameof(SimpleClassDataContract.NameNotMarked)} eq 'nm1'"));
        }
    }
}
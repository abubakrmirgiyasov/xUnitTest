using System;
using System.Collections.Generic;
using Xunit;

namespace TestApplication.Test
{
    public class PersonTestClass
    {
        [Fact]
        public void FindJohanna()
        {
            var person = new Person();

            var item = person.GetAllPeople().Find(x => x.Name == "Johanna").Info;

            Assert.Equal("female", item);
        }

        [Fact]
        public void QuickSort_With_DefaultAlghoritm()
        {
            var person = new Person();

            var list = person.GetAllPeople();

            // default, by list
            list.Sort(delegate(Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            });

            Assert.StartsWith("Alex", list[0].Name);
        }

        [Fact]
        public void QuickSort_With_OwnAlghoritm()
        {
            var person = new Person();

            var list = person.GetAllPeople();

            var comparer = Comparer<Person>.Create((x, y) => string.Compare(x.Name, y.Name, StringComparison.Ordinal));

            person.QuickSort(list, 0, list.Count - 1, comparer);

            Assert.Equal("Alex", list[0].Name);
        }

        [Fact]
        public void QuickSort_With_OwnAlghoritm_PivotIndex()
        {
            var person = new Person();

            var list = person.GetAllPeople();

            var comparer = Comparer<Person>.Create((x, y) => string.Compare(x.Info, y.Info, StringComparison.Ordinal));

            person.QuickSort(list, 0, list.Count - 1, comparer);

            Assert.True(list[^1].Info == "male");
        }

        [Fact]
        public void SAD()
        {
            List<string> list = new()
            {  "Ru", "Us", "Uz", "Kz", "Kr", "Tj", "Az", "Bl", "Ua" };

            var person = new Person();

            var comparer = Comparer<string>.Create((x, y) => string.Compare(x, y, StringComparison.Ordinal));

            person.QuickSort(list, 0, list.Count - 1, comparer);

            Assert.Contains("Az", list);
        }
    }
} 
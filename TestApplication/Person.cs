namespace TestApplication
{
    public class Person
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Info { get; set; }

        public Person() { }

        public List<Person> GetAllPeople()
        {
            var list = new List<Person>()
            {
                new Person() { Id = "e50048b9-2d7c-4871-baa8-9f8c384e1793", Name = "Frances", Info = "female" },
                new Person() { Id = "cb654da4-d33f-4d8f-8adb-7b740180129b", Name = "Fred", Info = "male" },
                new Person() { Id = "6d9fef00-9801-4dc6-9a48-925a8754d67a", Name = "Johanna", Info = "female"},
                new Person() { Id = "e38ff9d7-f7d5-4cb3-9c9f-51f9a6e1ee2a", Name = "Alex", Info = "female" },
                new Person() { Id = "29cef353-e8da-48d2-bc5b-ff7309e7ff41", Name = "Timothy", Info = "male" },
                new Person() { Id = "0a599298-a44f-4c57-bf2f-47a83dfaaec5", Name = "Dorothy", Info = "female" },
                new Person() { Id = "df8ff057-016a-48a4-8c08-cd3d3d894a63", Name = "Steve", Info = "male" },
            };

            return list;
        }

        public void QuickSort<T>(IList<T> list, int left, int right, IComparer<T> comparer)
        {
            int i = left;
            int j = right;
            var pivot = list[(left + right) / 2];

            while (i <= j)
            {
                while (comparer.Compare(list[i], pivot) < 0)
                {
                    i++;
                }

                while (comparer.Compare(list[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(list, left, j, comparer);
            }

            if (i < right)
            {
                QuickSort(list, i, right, comparer);
            }
        }
    }
}

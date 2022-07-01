using TestApplication;

var person = new Person();

var list = person.GetAllPeople();

List<int> id = new();

foreach (var item in list)
{
    Console.WriteLine("{0}\t\t{1}\t\t{2}", item.Id, item.Name, item.Info);
}

var comparer = Comparer<Person>.Create((x, y) => string.Compare(x.Id, y.Id, StringComparison.Ordinal));

person.QuickSort(list, 0, list.Count - 1, comparer);

Console.WriteLine("Sorted by <ID>:");
foreach (var item in list)
{
    Console.WriteLine("{0}\t{1}", item.Id, item.Name);
}

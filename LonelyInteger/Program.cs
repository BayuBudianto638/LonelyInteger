List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
foreach (var item in a)
{
    var result = a.Select(x => x).Where(w => ((uint)w) == item);
    if (result.Count() == 1)
        Console.WriteLine($"{item}");
}

Console.ReadKey();
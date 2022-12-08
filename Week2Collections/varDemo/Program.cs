Dictionary<string, int> nums = new Dictionary<string, int>();

nums["One"] = 1;
nums["Ten"] = 10;
nums["Twenty"] = 20;

foreach(KeyValuePair<string, int> pair in nums)
{
    Console.WriteLine($"{pair.Key}");
}
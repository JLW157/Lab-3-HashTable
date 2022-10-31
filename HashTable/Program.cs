using HashTable;

int[] GenerateRandomNumbers(int amount)
{
	int[] randomNumbers = new int[amount];
	for (int i = 0; i < amount; i++)
	{
		randomNumbers[i] = new Random().Next(0, 100);
	}

	return randomNumbers;
}

HashTable<int> hashTable = new HashTable<int>(15);

int[] arrNums = GenerateRandomNumbers(15);

for (int i = 0; i < arrNums.Length; i++)
{
	hashTable.Add(arrNums[i]);
}

Console.WriteLine("All nums: ");
hashTable.ShowTable();
Console.WriteLine();

Console.WriteLine($"After removing: {arrNums[0]} - {hashTable.Remove(arrNums[0])}");
Console.WriteLine(hashTable.Remove(123));
Console.WriteLine();

hashTable.ShowTable();
Console.WriteLine();

Console.WriteLine(hashTable.Search(arrNums[0]));
Console.WriteLine(hashTable.Search(arrNums[1]));
Console.WriteLine(hashTable.Search(10));
using System.Text.Json;

namespace DNDLibrary;

public class Bracers
{
	public string Name { get; set; }
	public string Slot { get; set; }
	public string Rarity { get; set; }
	public bool RequiresAttunement { get; set; }

	public int? ArmorClassBonus { get; set; }

	public List<string> Conditions { get; set; } = new();
	public List<string> Effects { get; set; } = new();
}


public static class BracersRepository
{
	private static readonly string FilePath = "Data/bracers.json";

	public static List<Bracers> GetAll()
	{
		if (!File.Exists(FilePath))
			throw new FileNotFoundException("Bracers JSON file not found.", FilePath);

		var json = File.ReadAllText(FilePath);

		return JsonSerializer.Deserialize<List<Bracers>>(json,
			new JsonSerializerOptions
			{
				PropertyNameCaseInsensitive = true
			}) ?? new List<Bracers>();
	}

	public static Bracers? GetByName(string name)
	{
		return GetAll()
			.FirstOrDefault(b =>
				b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
	}
}


public static class ExampleBracersCode
{
	public static void ExampleBracers()
	{
		var bracers = BracersRepository.GetByName("Bracers of Defense");

		if (bracers != null && bracers.RequiresAttunement)
		{
			Console.WriteLine($"{bracers.Name} requires attunement.");
		}
	}

}
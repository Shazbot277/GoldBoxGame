using DNDLibrary.Equipment;
using System.Text.Json;

namespace DNDLibrary;
public static class EquipmentRepository<T> where T : Equipment.Equipment
{
	public static List<T> Load(string filePath)
	{
		if (!File.Exists(filePath))
			throw new FileNotFoundException($"Equipment file not found: {filePath}");

		var json = File.ReadAllText(filePath);

		return JsonSerializer.Deserialize<List<T>>(json,
			new JsonSerializerOptions
			{
				PropertyNameCaseInsensitive = true
			}) ?? new List<T>();
	}

	public static T? GetByName(string filePath, string name)
	{
		return Load(filePath)
			.FirstOrDefault(e =>
				e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
	}
}

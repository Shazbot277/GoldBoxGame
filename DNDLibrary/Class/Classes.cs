namespace DNDLibrary.Class;

public static class Classes
{
	private static readonly Dictionary<string, ICharacterClass> _classes =
		new(StringComparer.OrdinalIgnoreCase)
		{
			{ "Fighter", new Fighter() },
			{ "Wizard", new Wizard() }
		};

	public static ICharacterClass Get(string name)
	{ 
		return _classes[name];
	}

	public static List<ICharacterClass> List() => _classes.Values.ToList();
	
}

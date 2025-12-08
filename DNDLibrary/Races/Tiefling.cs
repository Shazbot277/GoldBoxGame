namespace DNDLibrary.Races;

public class Tiefling : RaceBase
{
	public override string Name => "Tiefling";
	public override string Description =>
		"Tieflings are beings with infernal heritage, often marked by their fiendish appearance and innate magical abilities.";
	public Tiefling()
		{
		AbilityScoreModifiers[Ability.Charisma] = 2;
		AbilityScoreModifiers[Ability.Intelligence] = 1;
		Languages.Add(Language.Common);
		Languages.Add(Language.Infernal);
		Traits.Add(new RacialTrait
		{
			Name = "Darkvision",
			Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Hellish Resistance",
			Description = "You have resistance to fire damage."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Infernal Legacy",
			Description = "You know the Thaumaturgy cantrip. Once you reach 3rd level, you can cast the Hellish Rebuke spell once as a 2nd-level spell. Once you reach 5th level, you can cast the Darkness spell once. You regain the ability to cast these spells this way after a long rest. Charisma is your spellcasting ability for these spells."
		});
	}
}
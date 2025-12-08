namespace DNDLibrary.Races;

public class HalfOrc : RaceBase
{
	public override string Name => "Half-Orc";
	public override string Description =>
		"Half-orcs are strong and resilient, often inheriting the best traits of both their human and orcish heritage.";
	public HalfOrc()
	{

		AbilityScoreModifiers[Ability.Strength] = 2;
		AbilityScoreModifiers[Ability.Constitution] = 1;

		Languages.Add(Language.Common);
		Languages.Add(Language.Orcish);

		Traits.Add(new RacialTrait
		{
			Name = "Darkvision",
			Description = "You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Relentless Endurance",
			Description = "When you are reduced to 0 hit points but not killed outright, you can drop to 1 hit point instead. You can use this feature once per long rest."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Savage Attacks",
			Description = "When you score a critical hit with a melee weapon attack, you can roll one of the weapon's damage dice one additional time and add it to the extra damage of the critical hit."
		});
	}
}
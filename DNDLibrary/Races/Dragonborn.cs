namespace DNDLibrary.Races;

public class Dragonborn : RaceBase
{
	public override string Name => "Dragonborn";
	public override string Description => "Born of dragons, as their name proclaims, the dragonborn walk proudly among their kin, with a noble bearing and a fierce loyalty.";
	public Dragonborn()
	{
		AbilityScoreModifiers[Ability.Strength] = 2;
		AbilityScoreModifiers[Ability.Charisma] = 1;
		Languages.Add(Language.Common);
		Languages.Add(Language.Draconic);

		Traits.Add(new RacialTrait
		{
			Name = "Draconic Ancestry",
			Description = "You have draconic ancestry. Choose one type of dragon from the Draconic Ancestry table. Your breath weapon and damage resistance are determined by the dragon type, as shown in the table."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Breath Weapon",
			Description = "You can use your action to exhale destructive energy. Your draconic ancestry determines the size, shape, and damage type of the exhalation."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Damage Resistance",
			Description = "You have resistance to the damage type associated with your draconic ancestry."
		});
	}
}
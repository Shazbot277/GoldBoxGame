namespace DNDLibrary.Races;

public class RockGnome : Gnome
{
	public override string Name => "Rock Gnome";
	public override string Description => "A rock gnome is a tinkerer and inventor, with a natural talent for craftsmanship.";
	public RockGnome()
	{
		AbilityScoreModifiers[Ability.Constitution] = 1;
		Traits.Add(new RacialTrait
		{
			Name = "Artificer's Lore",
			Description = "Whenever you make an Intelligence (History) check related to magic items, alchemical objects, or technological devices, you can add twice your proficiency bonus."
		});
		Traits.Add(new RacialTrait
		{
			Name = "Tinker",
			Description = "You have proficiency with artisan's tools (tinker's tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend another hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time."
		});
	}
}
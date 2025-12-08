namespace DNDLibrary.Races;

public class WoodElf : Elf
{
    public override string Name => "Wood Elf";
    public override string Description => "A wood elf is a graceful and agile being, deeply attuned to the natural world. They are known for their keen senses, swift movements, and strong connection to the forests they call home.";
    public WoodElf()
    {
        AbilityScoreModifiers[Ability.Dexterity] += 2;
        AbilityScoreModifiers[Ability.Wisdom] += 1;
        Traits.Add(new RacialTrait
        {
            Name = "Mask of the Wild",
            Description = "You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena."
        });
	}
}

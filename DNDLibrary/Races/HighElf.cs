namespace DNDLibrary.Races;

public class HighElf : Elf
{
    public override string Name => "High Elf";
    public override string Description => "Elves of refined intellect and magical prowess";
    public HighElf()
    {
        AbilityScoreModifiers[Ability.Intelligence] = 1;
        Languages.Add(Language.Elvish);
        Traits.Add(new RacialTrait
        {
            Name = "Cantrip",
            Description = "You know one cantrip of your choice from the wizard spell list. Intelligence is your spellcasting ability for it."
        });
	}
}
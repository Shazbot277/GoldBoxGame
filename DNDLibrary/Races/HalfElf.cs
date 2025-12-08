namespace DNDLibrary.Races;

public class HalfElf : RaceBase
{
    public override string Name => "Half-Elf";
    public override string Description => "Half human, half Elf";

    //Plus 1 to two other abilities
    public HalfElf()
    {
        AbilityScoreModifiers[Ability.Charisma] = 2;

        Languages.Add(Language.Common);
        Languages.Add(Language.Elvish);

        Traits.Add(new RacialTrait
        {
            Name = "DarkVision",
            Description = "You can see in dim light within 60 feet..."
        });

        Traits.Add(new RacialTrait
        {
            Name = "Fey Ancestry",
            Description = "You have advantage on saving throws..."
        });
    }
}

namespace DNDLibrary.Races;

public class HighElf : Elf
{
    public override string Name => "High Elf";

    public HighElf()
    {
        AbilityScoreModifiers[Ability.Intelligence] = 1;

        Proficiencies.Add(SkillType.Arcana);
        Proficiencies.Add(SkillType.History);


        Traits.Add(new RacialTrait
        {
            Name = "Cantrip",
            Description = "You know one cantrip of your choice from the wizard spell list."
        });
    }
}
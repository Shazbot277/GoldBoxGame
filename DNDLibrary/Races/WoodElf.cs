namespace DNDLibrary.Races;

public class WoodElf : Elf
{
    public override string Name => "Wood Elf";

    public WoodElf()
    {
        AbilityScoreModifiers[Ability.Wisdom] = 1;


        Proficiencies.Add(SkillType.Survival);
        Proficiencies.Add(SkillType.Stealth);
        Proficiencies.Add(SkillType.AnimalHandling);

        Traits.Add(new RacialTrait
        {
            Name = "Cantrip",
            Description = "You know one cantrip of your choice from the wizard spell list."
        });
    }
}

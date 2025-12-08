namespace DNDLibrary.Races;

public class DrowElf : Elf
{
    public override string Name => "Drow Elf";

    public DrowElf()
    {
        AbilityScoreModifiers[Ability.Charisma] = 1;

        Proficiencies.Add(SkillType.Deception);
        Proficiencies.Add(SkillType.Persuasion);
        Proficiencies.Add(SkillType.Intimidation);

        Traits.Add(new RacialTrait
        {
            Name = "Cantrip",
            Description = "You know one cantrip of your choice from the wizard spell list."
        });
    }
}

namespace DNDLibrary.Races;

public abstract class RaceBase : IRace
{
    public abstract string Name { get; }
    public abstract string Description { get; }

    public virtual Dictionary<Ability, int> AbilityScoreModifiers { get; } = new Dictionary<Ability, int>();

    public virtual List<Language> Languages { get; } = new List<Language>();

    public virtual List<SkillType> Proficiencies { get; } = new List<SkillType>();

    public virtual List<RacialTrait> Traits { get; } = new();

    public virtual List<Equipment.Weapon> WeaponProficiencies { get; } = new();

	public virtual void ApplyTo(Character character)
    {
        foreach (var mod in AbilityScoreModifiers)
            character.AbilityScores[mod.Key] += mod.Value;

        character.Languages.AddRange(Languages);
        character.Proficiencies.AddRange(Proficiencies);
        character.Traits.AddRange(Traits);
    }
}
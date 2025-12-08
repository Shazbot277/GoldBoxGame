namespace DNDLibrary.Races;

public interface IRace
{
    string Name { get; }
    string Description { get; }

    // Ability score changes (post-2024 rules often give floating ASIs)
    Dictionary<Ability, int> AbilityScoreModifiers { get; }

    // Languages, proficiencies, traits
    List<Language> Languages { get; }
    List<SkillType> Proficiencies { get; }
    List<RacialTrait> Traits { get; }

    void ApplyTo(Character character);
}
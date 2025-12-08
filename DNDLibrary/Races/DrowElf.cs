namespace DNDLibrary.Races;

public class DrowElf : Elf
{
    public override string Name => "Drow Elf";
    public override string Description => "Drow elves, also known as dark elves, are a subrace of elves that dwell in the Underdark. They are known for their dark skin, white hair, and affinity for magic. Drow elves are often portrayed as cunning and treacherous, with a matriarchal society that worships the spider goddess Lolth.";
    public DrowElf()
    {
        AbilityScoreModifiers[Ability.Charisma] += 1;
        Traits.Add(new RacialTrait
        {
            Name = "Superior Darkvision",
            Description = "You can see in darkness (shades of gray) up to 120 feet."
        });
        Traits.Add(new RacialTrait
        {
            Name = "Sunlight Sensitivity",
            Description = "You have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight."
        });
        Traits.Add(new RacialTrait
        {
            Name = "Drow Magic",
            Description = "You know the Dancing Lights cantrip. When you reach 3rd level, you can cast the Faerie Fire spell once per day. When you reach 5th level, you can also cast the Darkness spell once per day. Charisma is your spellcasting ability for these spells."
        });
	}
}

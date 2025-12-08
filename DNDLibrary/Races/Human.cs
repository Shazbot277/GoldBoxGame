using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDLibrary.Races;

public class Human : RaceBase
{
    public override string Name => "Human";
    public override string Description => "Florida man";

    public Human()
    {
        AbilityScoreModifiers[Ability.Strength] = 1;
        AbilityScoreModifiers[Ability.Intelligence] = 1;
        AbilityScoreModifiers[Ability.Wisdom] = 1;
        AbilityScoreModifiers[Ability.Dexterity] = 1;
        AbilityScoreModifiers[Ability.Constitution] = 1;
        AbilityScoreModifiers[Ability.Charisma] = 1;

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

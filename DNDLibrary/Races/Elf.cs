using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDLibrary.Races;

public class Elf : RaceBase
{
    public override string Name => "Elf";
    public override string Description => "Grace, magical people";

    public Elf()
    {
        AbilityScoreModifiers[Ability.Dexterity] = 2;

        Languages.Add(Language.Common);
        Languages.Add(Language.Elvish);

        Proficiencies.Add(SkillType.Perception);

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
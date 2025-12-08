using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDLibrary.Races;

public class Elf : RaceBase
{
    public override string Name => "Elf";
    public override string Description => "Graceful and wise beings";
    public Elf()
    {
        AbilityScoreModifiers[Ability.Dexterity] = 2;
        Languages.Add(Language.Common);
        Languages.Add(Language.Elvish);
        Traits.Add(new RacialTrait
        {
            Name = "DarkVision",
            Description = "You can see in dim light within 60 feet..."
        });
        Traits.Add(new RacialTrait
        {
            Name = "Keen Senses",
            Description = "You have proficiency in the Perception skill."
        });
        Traits.Add(new RacialTrait
        {
            Name = "Fey Ancestry",
            Description = "You have advantage on saving throws against being charmed, and magic can't put you to sleep."
        });
	}
}
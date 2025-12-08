using System.Collections.Immutable;
using System.ComponentModel;
using System.Security.Cryptography;

namespace DNDLibrary;

public static class Roll
{
	public static int InitialAbilityScore()
	{
		int die1 = D6();
		int die2 = D6();
		int die3 = D6();
		int die4 = D6();
		int[] dieArray = new int[] { die1, die2, die3, die4 };
		Array.Sort(dieArray);
		return dieArray[1] + dieArray[2] + dieArray[3];
	}		

	public static int D6()
	{
		return RandomNumberGenerator.GetInt32(1,6);
	}
}

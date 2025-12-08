using System.Collections.Immutable;
using System.ComponentModel;
using System.Security.Cryptography;

namespace DNDLibrary;

public static class Roll
{
	public static int InitialAbilityScore()
	{
		int die1 = D20();
		int die2 = D20();
		int die3 = D20();
		int die4 = D20();
		int[] dieArray = new int[] { die1, die2, die3, die4 };
		Array.Sort(dieArray);
		return dieArray[1] + dieArray[2] + dieArray[3];
	}		

	public static int D20()
	{
		return RandomNumberGenerator.GetInt32(1,21);
	}
}

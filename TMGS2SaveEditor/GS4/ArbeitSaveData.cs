using System;


namespace GS4
{
	
	[Serializable]
	public class ArbeitSaveData
	{
		
		
		public ArbeitSaveData()
		{
		}

		
		
		public ArbeitId arbeitId;

		
		
		public int exp;

		
		
		public float salary;

		
		
		public int eventBase;

		
		
		public bool isRankUp;

		
		
		public bool isMaster;

		
		
		public bool[] isJoins;

		
		
		public bool[] isGetAddress;
	}
}

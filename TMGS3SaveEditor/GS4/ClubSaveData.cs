using System;


namespace GS4
{
	
	[Serializable]
	public class ClubSaveData
	{
		
		
		public ClubSaveData()
		{
		}

		
		
		public ClubId clubId;

		
		
		public int exp;

		
		
		public int campEntryCount;

		
		
		public int gameEntryCount;

		
		
		public int gameWinCount;

		
		
		public int absentCount;

		
		
		public int festivalCount;

		
		
		public bool isMaster;

		
		
		public bool[] isJoins;
	}
}

using System;


namespace GS4
{
	
	[Serializable]
	public class ProgressSaveData
	{
		
		
		public ProgressSaveData()
		{
		}

		
		
		public DateTime nowDate;

		
		
		public int[] cycleCounts;

		
		
		public ReserveDateSaveData[] reserveDates;

		
		
		public ChatSaveData[] chats;

		
		
		public AdvSaveData[] advs;

		
		
		public IconKind runCommand;

		
		
		public IconKind dayCommand;

		
		
		public bool isPlayBadRumors;
	}
}

using System;


namespace GS4
{
	
	[Serializable]
	public class PlayerSaveData
	{
		
		
		public PlayerSaveData()
		{
		}

		
		
		public ProfileSaveData profile;

		
		
		public float[] standardParams;

		
		
		public bool isSick;

		
		
		public int dayCommandSucceedCount;

		
		
		public int dayCommandFailedCount;

		
		
		public ClubSaveData club;

		
		
		public ArbeitSaveData arbeit;

		
		
		public SchoolSaveData school;

		
		
		public FashionSaveData fashion;

		
		
		public bool[] isCheckDateContents;

		
		
		public bool[] isCheckShops;

		
		
		public bool[] isCheckNews;

		
		
		public bool[] isCheckColumns;

		
		
		public int[] oneYearCommandCounts;

		
		
		public int[] threeYearCommandCounts;

		
		
		public int[] stayCommandCounts;

		
		
		public int serialRestCount;

		
		
		public int cafeCommandCount;

		
		
		public CharacterId[] chocoChars;

		
		
		public ChocoMadeId chocooMade;

		
		
		public CharacterId stayChar;

		
		
		public CharacterId summerVacationChar;

		
		
		public IconKind lastCommandIconKind;

		
		
		public CharacterId bestFriendChar;

		
		
		public int bestFriendDateCount;

		
		
		public bool isPlayTutorial;

		
		
		public CharacterId accidentKissChar;

		
		
		public CharacterId etcEndingCharNo;

		
		
		public bool[] soloGoOutFlags;

		
		
		public bool[] schoolGoOutFlags;

		
		
		public bool[] datePersonalFlags;

		
		
		public bool[] personalFlags;

		
		
		public bool[] requiredEventFlags;

		
		
		public bool[] playerFlags;

		
		
		public int[] playerCounters;

		
		
		public int[] scriptWorks;
	}
}

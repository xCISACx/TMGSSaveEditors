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

		
		
		public int[] oneYearCommandCounts;

		
		
		public int[] threeYearCommandCounts;

		
		
		public int[] stayCommandCounts;

		
		
		public int serialRestCount;

		
		
		public int cafeCommandCount;

		
		
		public CharacterId[] chocoChars;

		
		
		public ChocoMadeId chocooMade;

		
		
		public int specialToppingId;

		
		
		public CharacterId stayChar;

		
		
		public CharacterId summerVacationChar;

		
		
		public CharacterId bestFriendChar;

		
		
		public int bestFriendDateCount;

		
		
		public bool isPlayTutorial;

		
		
		public bool isTriangle;

		
		
		public bool isTriangleFight;

		
		
		public DateTime triangleDate;

		
		
		public DateTime last3DateDate;

		
		
		public CharacterId[] triChar;

		
		
		public int[] triMF;

		
		
		public int[] triMFKeep;

		
		
		public int[] triMM;

		
		
		public int[] triMMKeep;

		
		
		public TriState[] triState;

		
		
		public int[] triObstinate;

		
		
		public int[] triOvercome;

		
		
		public bool[,] groupDatePatternFlags;

		
		
		public bool[] soloGoOutFlags;

		
		
		public bool[] schoolGoOutFlags;

		
		
		public bool[] datePersonalFlags;

		
		
		public bool[] personalFlags;

		
		
		public bool[] requiredEventFlags;

		
		
		public bool[] playerFlags;

		
		
		public int[] playerCounters;
	}
}

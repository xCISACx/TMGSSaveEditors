using System;


namespace GS4
{
	
	[Serializable]
	public class FriendCharSaveData
	{
		
		
		public FriendCharSaveData()
		{
		}

		
		
		public int friendPoint;

		
		
		public EmotionState emotionState;

		
		
		public int meetCount;

		
		
		public int meetCount1Month;

		
		
		public DateTime lastMeetDate;

		
		
		public int dateCount;

		
		
		public bool isAppear;

		
		
		public DateTime appearDate;

		
		
		public bool isKnownBirthDay;

		
		
		public NicknameId nicknameId;

		
		
		public bool isStandAppear;

		
		
		public bool isSDAnimAppear;

		
		
		public bool[] hearSelectFlags;

		
		
		public bool[] playPatternFlags;

		
		
		public bool[] playItemFlags;

		
		
		public bool[] schoolOutTalkFlags;

		
		
		public bool[] commonFlags;

		
		
		public int[] commonCounters;
	}
}

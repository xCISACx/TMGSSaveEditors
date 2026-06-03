using System;


namespace GS4
{
	
	[Serializable]
	public class ApproachCharSaveData
	{
		
		
		public ApproachCharSaveData()
		{
		}

		
		
		public int lovePoint;

		
		
		public int friendPoint;

		
		
		public int lovePoint1Month;

		
		
		public EmotionState emotionState;

		
		
		public int meetCount;

		
		
		public int meetCount1Month;

		
		
		public DateTime lastMeetDate;

		
		
		public int dateCount;

		
		
		public int serialDateCount;

		
		
		public int dateCount1Month;

		
		
		public DateTime lastDateDate;

		
		
		public DateTime lastHomeDateDate;

		
		
		public bool isInvitedLastDate;

		
		
		public DateContent lastDateContent;

		
		
		public DateRate oldDateRate;

		
		
		public PairlookState lastDatePairlookState;

		
		
		public bool isReactToPresentLastDate;

		
		
		public EquipData lastDateEquip;

		
		
		public int LoveSwell;

		
		
		public int FriendSwell;

		
		
		public int LoveSwellPlus;

		
		
		public int FriendSwellPlus;

		
		
		public int LoveSwellPlusAll;

		
		
		public int FriendSwellPlusAll;

		
		
		public int SwellPlusAll;

		
		
		public int brokenPoint;

		
		
		public BrokenState brokenState;

		
		
		public BombState bombState;

		
		
		public DateTime lastSparkDate;

		
		
		public bool isAppear;

		
		
		public DateTime appearDate;

		
		
		public bool isKnownBirthDay;

		
		
		public NicknameId nicknameId;

		
		
		public bool isStandAppear;

		
		
		public bool isSDAnimAppear;

		
		
		public int[] fashionFavoritePoints;

		
		
		public FashionFavoriteId[] fashionFavoriteRanks;

		
		
		public int clothIndex;

		
		
		public int dokidokiMaxCount;

		
		
		public int[] dateRotateIndexs;

		
		
		public bool[] nssSelectFlags;

		
		
		public int[] hearSelectCounts;

		
		
		public bool[] schoolOutTalkFlags;

		
		
		public bool[] commonFlags;

		
		
		public int[] commonCounters;

		
		
		public int[] titlePatternIndexs;
	}
}

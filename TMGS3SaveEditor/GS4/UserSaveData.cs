using System;


namespace GS4
{
	
	[Serializable]
	public class UserSaveData
	{
		
		
		public UserSaveData()
		{
		}

		
		
		public bool enable;

		
		
		public DateTime saveDate;

		
		
		public byte languageCode;

		
		
		public ProgressSaveData progress;

		
		
		public PlayerSaveData player;

		
		
		public ApproachCharSaveData[] approachChars;

		
		
		public FriendCharSaveData[] friendChars;

		
		
		public AdvCharSaveData[] advChars;

		
		
		public SdCategoryId sdCategoryId;

		
		
		public string memoString;

		
		
		public SaveDataManager.ErrorCode errorCode;
	}
}

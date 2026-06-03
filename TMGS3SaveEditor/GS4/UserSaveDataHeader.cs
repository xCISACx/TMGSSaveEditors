using System;


namespace GS4
{
	
	[Serializable]
	public class UserSaveDataHeader
	{
		
		
		public UserSaveDataHeader()
		{
		}

		
		
		public bool enable;

		
		
		public DateTime saveDate;

		
		
		public DateTime nowDate;

		
		
		public string familyName;

		
		
		public string firstName;

		
		
		public DateTime birthday;

		
		
		public BloodType bloodType;

		
		
		public ClubId clubId;

		
		
		public ArbeitId arbeitId;

		
		
		public float[] standardParams;

		
		
		public AdvSaveData[] advs;

		
		
		public SdCategoryId sdCategoryId;

		
		
		public string memoString;

		
		
		public NicknameId[] nicknameIds;

		
		
		public bool[] nicknameFlags;
	}
}

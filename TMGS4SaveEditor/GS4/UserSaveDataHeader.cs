using System;


namespace GS4
{
	// Token: 0x0200040F RID: 1039
	[Serializable]
	public class UserSaveDataHeader
	{
		// Token: 0x06001913 RID: 6419 RVA: 0x00002053 File Offset: 0x00000253

	

		// Token: 0x040017C2 RID: 6082
		public bool enable;

		// Token: 0x040017C3 RID: 6083
		public DateTime saveDate;

		// Token: 0x040017C4 RID: 6084
		public DateTime nowDate;

		// Token: 0x040017C5 RID: 6085
		public string familyName;

		// Token: 0x040017C6 RID: 6086
		public string firstName;

		// Token: 0x040017C7 RID: 6087
		public DateTime birthday;

		// Token: 0x040017C8 RID: 6088
		public BloodType bloodType;

		// Token: 0x040017C9 RID: 6089
		public ClubId clubId;

		// Token: 0x040017CA RID: 6090
		public ArbeitId arbeitId;

		// Token: 0x040017CB RID: 6091
		public int reporterLevel;

		// Token: 0x040017CC RID: 6092
		public float[] standardParams;

		// Token: 0x040017CD RID: 6093
		public AdvSaveData[] advs;

		// Token: 0x040017CE RID: 6094
		public SdCategoryId sdCategoryId;

		// Token: 0x040017CF RID: 6095
		public string memoString;

		// Token: 0x040017D0 RID: 6096
		public NicknameId[] nicknameIds;

		// Token: 0x040017D1 RID: 6097
		public bool[] nicknameFlags;
	}
}

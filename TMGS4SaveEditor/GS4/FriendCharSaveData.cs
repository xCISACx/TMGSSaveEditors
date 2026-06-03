using System;


namespace GS4
{
	// Token: 0x020003E7 RID: 999
	[Serializable]
	public class FriendCharSaveData
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x00002053 File Offset: 0x00000253

	

		// Token: 0x0400153E RID: 5438
		public int friendPoint;

		// Token: 0x0400153F RID: 5439
		public EmotionState emotionState;

		// Token: 0x04001540 RID: 5440
		public int meetCount;

		// Token: 0x04001541 RID: 5441
		public int meetCount1Month;

		// Token: 0x04001542 RID: 5442
		public DateTime lastMeetDate;

		// Token: 0x04001543 RID: 5443
		public int dateCount;

		// Token: 0x04001544 RID: 5444
		public bool isAppear;

		// Token: 0x04001545 RID: 5445
		public DateTime appearDate;

		// Token: 0x04001546 RID: 5446
		public bool isKnownBirthDay;

		// Token: 0x04001547 RID: 5447
		public NicknameId nicknameId;

		// Token: 0x04001548 RID: 5448
		public bool isStandAppear;

		// Token: 0x04001549 RID: 5449
		public bool isSDAnimAppear;

		// Token: 0x0400154A RID: 5450
		public int omikujiCount;

		// Token: 0x0400154B RID: 5451
		public int birthdayPresentCount;

		// Token: 0x0400154C RID: 5452
		public int goOutCount;

		// Token: 0x0400154D RID: 5453
		public int goOutInviteCount;

		// Token: 0x0400154E RID: 5454
		public bool[] hearSelectFlags;

		// Token: 0x0400154F RID: 5455
		public bool[] playPatternFlags;

		// Token: 0x04001550 RID: 5456
		public bool[] playItemFlags;

		// Token: 0x04001551 RID: 5457
		public bool[] schoolOutTalkFlags;

		// Token: 0x04001552 RID: 5458
		public bool[] commonFlags;
	}
}

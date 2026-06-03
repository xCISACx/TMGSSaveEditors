using System;


namespace GS4
{
	// Token: 0x020003E1 RID: 993
	[Serializable]
	public class FashionSaveData
	{
		// Token: 0x0600171C RID: 5916 RVA: 0x00002053 File Offset: 0x00000253


		// Token: 0x04001503 RID: 5379
		public bool[] isPossessionDresses;

		// Token: 0x04001504 RID: 5380
		public EquipData equip;

		// Token: 0x04001505 RID: 5381
		public EquipData[] equipHistories;

		// Token: 0x04001506 RID: 5382
		public int equipHistoriesCount;

		// Token: 0x04001507 RID: 5383
		public EquipData[] myCoordinate;

		// Token: 0x04001508 RID: 5384
		public bool isEquipTrainGips;

		// Token: 0x04001509 RID: 5385
		public DateTime trainGipsEquipDate;

		// Token: 0x0400150A RID: 5386
		public float[] trainGipsParams;

		// Token: 0x0400150B RID: 5387
		public int fashionSkillPoint;

		// Token: 0x0400150C RID: 5388
		public int fashionSkillLevel;

		// Token: 0x0400150D RID: 5389
		public int serialTrendCount;

		// Token: 0x0400150E RID: 5390
		public bool isPlayedFashionCheck;

		// Token: 0x0400150F RID: 5391
		public int shopCardStampCount;

		// Token: 0x04001510 RID: 5392
		public int[] specialTicketCount;

		// Token: 0x04001511 RID: 5393
		public int[] trendDressTypes;

		// Token: 0x04001512 RID: 5394
		public int[] trendColors;

		// Token: 0x04001513 RID: 5395
		public int[] trendAccessoryTypes;

		// Token: 0x04001514 RID: 5396
		public int[] happyItemAccessoryTypes;
	}
}

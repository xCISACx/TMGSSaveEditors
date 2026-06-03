using System;


namespace GS4
{
	// Token: 0x020003EA RID: 1002
	[Serializable]
	public class PlayerSaveData
	{
		// Token: 0x06001797 RID: 6039 RVA: 0x00002053 File Offset: 0x00000253

		// Token: 0x0400155B RID: 5467
		public ProfileSaveData profile;

		// Token: 0x0400155C RID: 5468
		public float[] standardParams;

		// Token: 0x0400155D RID: 5469
		public bool isSick;

		// Token: 0x0400155E RID: 5470
		public int reporterExp;

		// Token: 0x0400155F RID: 5471
		public int reportCount;

		// Token: 0x04001560 RID: 5472
		public int reporterLevel;

		// Token: 0x04001561 RID: 5473
		public int lastReportId;

		// Token: 0x04001562 RID: 5474
		public DateTime ch02ReportDate;

		// Token: 0x04001563 RID: 5475
		public int dayCommandSucceedCount;

		// Token: 0x04001564 RID: 5476
		public int dayCommandFailedCount;

		// Token: 0x04001565 RID: 5477
		public ClubSaveData club;

		// Token: 0x04001566 RID: 5478
		public ArbeitSaveData arbeit;

		// Token: 0x04001567 RID: 5479
		public SchoolSaveData school;

		// Token: 0x04001568 RID: 5480
		public FashionSaveData fashion;

		// Token: 0x04001569 RID: 5481
		public bool[] isCheckDateContents;

		// Token: 0x0400156A RID: 5482
		public bool[] isCheckShops;

		// Token: 0x0400156B RID: 5483
		public bool[] isCheckNews;

		// Token: 0x0400156C RID: 5484
		public int[] oneYearCommandCounts;

		// Token: 0x0400156D RID: 5485
		public int[] threeYearCommandCounts;

		// Token: 0x0400156E RID: 5486
		public int[] stayCommandCounts;

		// Token: 0x0400156F RID: 5487
		public int serialRestCount;

		// Token: 0x04001570 RID: 5488
		public int cafeCommandCount;

		// Token: 0x04001571 RID: 5489
		public int groupADateCount;

		// Token: 0x04001572 RID: 5490
		public int groupBDateCount;

		// Token: 0x04001573 RID: 5491
		public int groupCDateCount;

		// Token: 0x04001574 RID: 5492
		public FoursomeId nowFoursomeId;

		// Token: 0x04001575 RID: 5493
		public bool isBuyPresent;

		// Token: 0x04001576 RID: 5494
		public PresentRate presentRate;

		// Token: 0x04001577 RID: 5495
		public bool isNanaPlayerSelection;

		// Token: 0x04001578 RID: 5496
		public CharacterId[] chocoChars;

		// Token: 0x04001579 RID: 5497
		public ChocoMadeId chocooMade;

		// Token: 0x0400157A RID: 5498
		public int specialToppingId;

		// Token: 0x0400157B RID: 5499
		public CharacterId stayChar;

		// Token: 0x0400157C RID: 5500
		public CharacterId lastPromotionChar;

		// Token: 0x0400157D RID: 5501
		public CharacterId lastDemotedChar;

		// Token: 0x0400157E RID: 5502
		public bool[] soloGoOutFlags;

		// Token: 0x0400157F RID: 5503
		public bool[] schoolGoOutFlags;

		// Token: 0x04001580 RID: 5504
		public bool[] schoolMealTalkFlags;

		// Token: 0x04001581 RID: 5505
		public bool[] fireflyTalkFlags;

		// Token: 0x04001582 RID: 5506
		public bool[] habachaFlags;

		// Token: 0x04001583 RID: 5507
		public bool[] datePersonalFlags;

		// Token: 0x04001584 RID: 5508
		public bool[] personalFlags;

		// Token: 0x04001585 RID: 5509
		public bool[] everydayFlags;

		// Token: 0x04001586 RID: 5510
		public bool[] requiredEventFlags;

		// Token: 0x04001587 RID: 5511
		public bool[] playerFlags;
	}
}

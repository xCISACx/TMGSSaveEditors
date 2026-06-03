using System;


namespace GS4
{
	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class ApproachCharSaveData
	{
		// Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253

	

		// Token: 0x04001440 RID: 5184
		public int lovePoint;

		// Token: 0x04001441 RID: 5185
		public int friendPoint;

		// Token: 0x04001442 RID: 5186
		public EmotionState emotionState;

		// Token: 0x04001443 RID: 5187
		public int meetCount;

		// Token: 0x04001444 RID: 5188
		public int meetCount1Month;

		// Token: 0x04001445 RID: 5189
		public DateTime lastMeetDate;

		// Token: 0x04001446 RID: 5190
		public int dateCount;

		// Token: 0x04001447 RID: 5191
		public int serialDateCount;

		// Token: 0x04001448 RID: 5192
		public int dateCount1Month;

		// Token: 0x04001449 RID: 5193
		public DateTime lastDateDate;

		// Token: 0x0400144A RID: 5194
		public DateTime lastHomeDateDate;

		// Token: 0x0400144B RID: 5195
		public bool isInvitedLastDate;

		// Token: 0x0400144C RID: 5196
		public DateContent lastDateContent;

		// Token: 0x0400144D RID: 5197
		public DateRate dateRateHigh;

		// Token: 0x0400144E RID: 5198
		public PairlookState lastDatePairlookState;

		// Token: 0x0400144F RID: 5199
		public bool isReactToPresentLastDate;

		// Token: 0x04001450 RID: 5200
		public EquipData lastDateEquip;

		// Token: 0x04001451 RID: 5201
		public int initimatePoint;

		// Token: 0x04001452 RID: 5202
		public int initimatePointTotal;

		// Token: 0x04001453 RID: 5203
		public int nearSkinShipInitimateDownCount;

		// Token: 0x04001454 RID: 5204
		public int brokenPoint;

		// Token: 0x04001455 RID: 5205
		public BrokenState brokenState;

		// Token: 0x04001456 RID: 5206
		public BombState bombState;

		// Token: 0x04001457 RID: 5207
		public DateTime lastSparkDate;

		// Token: 0x04001458 RID: 5208
		public bool isPrincessBox;

		// Token: 0x04001459 RID: 5209
		public bool isReserveBox;

		// Token: 0x0400145A RID: 5210
		public bool isPrincessBoxAtLeastOnce;

		// Token: 0x0400145B RID: 5211
		public bool canMeramera;

		// Token: 0x0400145C RID: 5212
		public int gardenOrder;

		// Token: 0x0400145D RID: 5213
		public bool isAppear;

		// Token: 0x0400145E RID: 5214
		public DateTime appearDate;

		// Token: 0x0400145F RID: 5215
		public bool isKnownBirthDay;

		// Token: 0x04001460 RID: 5216
		public bool isNotReceived;

		// Token: 0x04001461 RID: 5217
		public NicknameId nicknameId;

		// Token: 0x04001462 RID: 5218
		public bool isStandAppear;

		// Token: 0x04001463 RID: 5219
		public bool isSDAnimAppear;

		// Token: 0x04001464 RID: 5220
		public bool isVisit;

		// Token: 0x04001465 RID: 5221
		public int[] fashionFavoritePoints;

		// Token: 0x04001466 RID: 5222
		public FashionFavoriteId[] fashionFavoriteRanks;

		// Token: 0x04001467 RID: 5223
		public MensType mensType;

		// Token: 0x04001468 RID: 5224
		public int clothIndex;

		// Token: 0x04001469 RID: 5225
		public int omikujiCount;

		// Token: 0x0400146A RID: 5226
		public int whiteDayCount;

		// Token: 0x0400146B RID: 5227
		public int birthdayPresentCount;

		// Token: 0x0400146C RID: 5228
		public int dokidokiMaxCount;

		// Token: 0x0400146D RID: 5229
		public int[] dateRotateIndexs;

		// Token: 0x0400146E RID: 5230
		public int[] groupDateCounts;

		// Token: 0x0400146F RID: 5231
		public int[] runThroughDateCounts;

		// Token: 0x04001470 RID: 5232
		public bool[] nssSelectFlags;

		// Token: 0x04001471 RID: 5233
		public bool[] hearSelectFlags;

		// Token: 0x04001472 RID: 5234
		public bool[] hearSelectFlagsGroup1;

		// Token: 0x04001473 RID: 5235
		public bool[] hearSelectFlagsGroup2;

		// Token: 0x04001474 RID: 5236
		public bool[] schoolOutTalkFlags;

		// Token: 0x04001475 RID: 5237
		public bool[] commonFlags;
	}
}

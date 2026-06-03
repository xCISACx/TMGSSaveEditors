using System;


namespace GS4
{
	// Token: 0x020003FA RID: 1018
	[Serializable]
	public class ReserveDateSaveData
	{
		// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253

		

		// Token: 0x0400160A RID: 5642
		public bool enable;

		// Token: 0x0400160B RID: 5643
		public CharacterId charId;

		// Token: 0x0400160C RID: 5644
		public CharacterId subCharId0;

		// Token: 0x0400160D RID: 5645
		public CharacterId subCharId1;

		// Token: 0x0400160E RID: 5646
		public bool isInvited;

		// Token: 0x0400160F RID: 5647
		public DateType dateType;

		// Token: 0x04001610 RID: 5648
		public DateSpot dateSpot;

		// Token: 0x04001611 RID: 5649
		public DateContent dateContent;

		// Token: 0x04001612 RID: 5650
		public DateTime reserveDate;

		// Token: 0x04001613 RID: 5651
		public int groupDateSpot;

		// Token: 0x04001614 RID: 5652
		public int runThroughDateSpot;
	}
}

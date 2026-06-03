using System;


namespace GS4
{
	// Token: 0x020003F8 RID: 1016
	[Serializable]
	public class ProgressSaveData
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x00002053 File Offset: 0x00000253

		

		// Token: 0x040015FF RID: 5631
		public DateTime nowDate;

		// Token: 0x04001600 RID: 5632
		public int[] cycleCounts;

		// Token: 0x04001601 RID: 5633
		public ReserveDateSaveData[] reserveDates;

		// Token: 0x04001602 RID: 5634
		public ChatSaveData[] chats;

		// Token: 0x04001603 RID: 5635
		public AdvSaveData[] advs;

		// Token: 0x04001604 RID: 5636
		public IconKind runCommand;

		// Token: 0x04001605 RID: 5637
		public IconKind dayCommand;

		// Token: 0x04001606 RID: 5638
		public bool isPlayBadRumors;
	}
}

using System;


namespace GS4
{
	// Token: 0x020003DF RID: 991
	[Serializable]
	public class ClubSaveData
	{
		// Token: 0x060016FB RID: 5883 RVA: 0x00002053 File Offset: 0x00000253


		// Token: 0x040014F9 RID: 5369
		public ClubId clubId;

		// Token: 0x040014FA RID: 5370
		public int exp;

		// Token: 0x040014FB RID: 5371
		public int campEntryCount;

		// Token: 0x040014FC RID: 5372
		public int gameEntryCount;

		// Token: 0x040014FD RID: 5373
		public int gameWinCount;

		// Token: 0x040014FE RID: 5374
		public int absentCount;

		// Token: 0x040014FF RID: 5375
		public int festivalCount;

		// Token: 0x04001500 RID: 5376
		public bool isMaster;

		// Token: 0x04001501 RID: 5377
		public bool[] isJoins;
	}
}

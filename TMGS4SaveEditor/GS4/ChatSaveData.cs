using System;


namespace GS4
{
	// Token: 0x020003DD RID: 989
	[Serializable]
	public class ChatSaveData
	{
		// Token: 0x060016E8 RID: 5864 RVA: 0x00002053 File Offset: 0x00000253



		// Token: 0x040014F2 RID: 5362
		public bool enable;

		// Token: 0x040014F3 RID: 5363
		public int chatId;

		// Token: 0x040014F4 RID: 5364
		public DateTime receiveDate;

		// Token: 0x040014F5 RID: 5365
		public bool isRead;

		// Token: 0x040014F6 RID: 5366
		public DateTime readDate;

		// Token: 0x040014F7 RID: 5367
		public int replyId;
	}
}

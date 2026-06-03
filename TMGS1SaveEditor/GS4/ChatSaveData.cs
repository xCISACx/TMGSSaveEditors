using System;


namespace GS4
{
	
	[Serializable]
	public class ChatSaveData
	{
		
		
		public ChatSaveData()
		{
		}

		
		
		public bool enable;

		
		
		public int chatId;

		
		
		public DateTime receiveDate;

		
		
		public bool isRead;

		
		
		public DateTime readDate;

		
		
		public int replyId;
	}
}

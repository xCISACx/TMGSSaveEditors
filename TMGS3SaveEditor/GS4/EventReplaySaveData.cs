using System;

namespace GS4
{
	[Serializable]
	public class EventReplaySaveData
	{
		public EventReplaySaveData()
		{
		}
		public bool[] nameChanges;

		public NicknameId[] nicknameIds;
	}
}

using System;


namespace GS4
{
	
	[Serializable]
	public class ReserveDateSaveData
	{
		
		
		public ReserveDateSaveData()
		{
		}

		
		
		public bool enable;

		
		
		public CharacterId charId;

		
		
		public CharacterId subCharId0;

		
		
		public CharacterId subCharId1;

		
		
		public bool isInvited;

		
		
		public DateType dateType;

		
		
		public DateSpot dateSpot;

		
		
		public DateContent dateContent;

		
		
		public DateTime reserveDate;
	}
}

using System;


namespace GS4
{
	
	[Serializable]
	public class FashionSaveData
	{
		
		
		public FashionSaveData()
		{
		}

		
		
		public bool[] isPossessionDresses;

		
		
		public EquipData equip;

		
		
		public EquipData[] equipHistories;

		
		
		public int equipHistoriesCount;

		
		
		public EquipData[] myCoordinate;

		
		
		public bool isEquipTrainGips;

		
		
		public DateTime trainGipsEquipDate;

		
		
		public float[] trainGipsParams;

		
		
		public int fashionSkillPoint;

		
		
		public int fashionSkillLevel;

		
		
		public int serialTrendCount;

		
		
		public bool isPlayedFashionCheck;

		
		
		public int shopCardStampCount;

		
		
		public int[] specialTicketCount;

		
		
		public int[] trendDressTypes;

		
		
		public int[] trendColors;

		
		
		public int[] trendAccessoryTypes;

		
		
		public int[] happyItemAccessoryTypes;
	}
}

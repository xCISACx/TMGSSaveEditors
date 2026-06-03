using System;


namespace GS4
{
	
	[Serializable]
	public class SchoolSaveData
	{
		
		
		public SchoolSaveData()
		{
		}

		
		
		public int lastTestAllOrder;

		
		
		public int testCount;

		
		
		public int serial1stCount;

		
		
		public int serialExClassCount;

		
		
		public bool isLesson;

		
		
		public int festivalReady;

		
		
		public bool isJoinClassDisplay;

		
		
		public CharacterId[] festivalChars;

		
		
		public TakeCourseId takeCourseId;

		
		
		public TakeCourseRank takeCourseRank;

		
		
		public CourseId courseId;

		
		
		public CharacterId lastSchoolOutCharacterId;
	}
}

using System;


namespace GS4
{
	// Token: 0x020003FF RID: 1023
	[Serializable]
	public class SchoolSaveData
	{
		// Token: 0x06001869 RID: 6249 RVA: 0x00002053 File Offset: 0x00000253

	

		// Token: 0x0400162A RID: 5674
		public int lastTestAllOrder;

		// Token: 0x0400162B RID: 5675
		public int testCount;

		// Token: 0x0400162C RID: 5676
		public int serial1stCount;

		// Token: 0x0400162D RID: 5677
		public int serialExClassCount;

		// Token: 0x0400162E RID: 5678
		public bool isLesson;

		// Token: 0x0400162F RID: 5679
		public int festivalReady;

		// Token: 0x04001630 RID: 5680
		public bool isJoinClassDisplay;

		// Token: 0x04001631 RID: 5681
		public CharacterId[] festivalChars;

		// Token: 0x04001632 RID: 5682
		public TakeCourseId takeCourseId;

		// Token: 0x04001633 RID: 5683
		public TakeCourseRank takeCourseRank;

		// Token: 0x04001634 RID: 5684
		public CourseId courseId;

		// Token: 0x04001635 RID: 5685
		public CharacterId lastSchoolOutCharacterId;
	}
}

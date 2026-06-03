using System;


namespace GS4
{
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public class SystemSaveData
	{
		// Token: 0x0600188D RID: 6285 RVA: 0x00002053 File Offset: 0x00000253

		

		// Token: 0x0400163A RID: 5690
		public float seMasterVolume;

		// Token: 0x0400163B RID: 5691
		public float bgmMasterVolume;

		// Token: 0x0400163C RID: 5692
		public float voiceMasterVolume;

		// Token: 0x0400163D RID: 5693
		public float ambientMasterVolume;

		// Token: 0x0400163E RID: 5694
		public MessageSpeedType messageSpeedType;

		// Token: 0x0400163F RID: 5695
		public CommandSpeedType commandSpeedType;

		// Token: 0x04001640 RID: 5696
		public bool isLeftHandSupport;

		// Token: 0x04001641 RID: 5697
		public int messageWindowFrameColorIndex;

		// Token: 0x04001642 RID: 5698
		public int messageWindowBaseColorIndex;

		// Token: 0x04001643 RID: 5699
		public SystemBGCustomType systemBGCustomType;

		// Token: 0x04001644 RID: 5700
		public int systemBGUserCustomColorIndex;

		// Token: 0x04001645 RID: 5701
		public PhotoFrameId photoFrameId;

		// Token: 0x04001646 RID: 5702
		public LaunchVoiceCharId bootVoiceId;

		// Token: 0x04001647 RID: 5703
		public CharacterId evsHelpVoiceId;

		// Token: 0x04001648 RID: 5704
		public int lastSaveSlotIndex;

		// Token: 0x04001649 RID: 5705
		public string lastSaveFamilyName;

		// Token: 0x0400164A RID: 5706
		public string lastSaveFirstName;

		// Token: 0x0400164B RID: 5707
		public NicknameId[] nicknameIds;

		// Token: 0x0400164C RID: 5708
		public bool[] isChangeNames;

		// Token: 0x0400164D RID: 5709
		public DateTime lastSaveBirthday;

		// Token: 0x0400164E RID: 5710
		public DateTime lastSaveDate;

		// Token: 0x0400164F RID: 5711
		public bool isOpenSkinShipTutorial;

		// Token: 0x04001650 RID: 5712
		public int endingCount;

		// Token: 0x04001651 RID: 5713
		public bool[] isOpenDownloadContents;

		// Token: 0x04001652 RID: 5714
		public bool[] isOpenMiniGames;

		// Token: 0x04001653 RID: 5715
		public bool[] isOpenMiniGameChars;

		// Token: 0x04001654 RID: 5716
		public bool[] isOpenMiniGameClubs;

		// Token: 0x04001655 RID: 5717
		public bool[] isOpenValentineBases;

		// Token: 0x04001656 RID: 5718
		public bool[] isOpenValentineToppings;

		// Token: 0x04001657 RID: 5719
		public bool[] isOpenValentineSpToppings;

		// Token: 0x04001658 RID: 5720
		public bool[] isOpenAlbums;

		// Token: 0x04001659 RID: 5721
		public AdvSaveData[] advs;

		// Token: 0x0400165A RID: 5722
		public bool[] isOpenEndings;

		// Token: 0x0400165B RID: 5723
		public EndingPatternId[] endingPatterns;

		// Token: 0x0400165C RID: 5724
		public bool[] isOpenPhotoFrames;

		// Token: 0x0400165D RID: 5725
		public bool[] isOpenDresses;

		// Token: 0x0400165E RID: 5726
		public bool[] isReadHelps;

		// Token: 0x0400165F RID: 5727
		public int[] allInitimatePointTotals;

		// Token: 0x04001660 RID: 5728
		public ProfileSaveData initialProfileData;

		// Token: 0x04001661 RID: 5729
		public bool enableInitialProfileData;

		// Token: 0x04001662 RID: 5730
		public ProfileCardSaveData myCard;

		// Token: 0x04001663 RID: 5731
		public bool[] isOpenBgs;

		// Token: 0x04001664 RID: 5732
		public bool[] isReadBgs;

		// Token: 0x04001665 RID: 5733
		public bool[] isOpenLunchs;

		// Token: 0x04001666 RID: 5734
		public bool[] isReadLunchs;

		// Token: 0x04001667 RID: 5735
		public bool[] isOpenAvatars;

		// Token: 0x04001668 RID: 5736
		public bool[] isReadAvatars;

		// Token: 0x04001669 RID: 5737
		public bool[] isOpenCharPatterns;

		// Token: 0x0400166A RID: 5738
		public bool[] isReadCharPatterns;

		// Token: 0x0400166B RID: 5739
		public bool[] isOpenCalls;

		// Token: 0x0400166C RID: 5740
		public bool[] isReadCalls;

		// Token: 0x0400166D RID: 5741
		public int[] commandCounts;

		// Token: 0x0400166E RID: 5742
		public int[] dateCounts;

		// Token: 0x0400166F RID: 5743
		public int[] playCounts;

		// Token: 0x04001670 RID: 5744
		public int chocoCount;

		// Token: 0x04001671 RID: 5745
		public UserSaveDataHeader[] userSaveDataHeaders;

		// Token: 0x04001672 RID: 5746
		public SaveDataManager.ErrorCode errorCode;
	}
}

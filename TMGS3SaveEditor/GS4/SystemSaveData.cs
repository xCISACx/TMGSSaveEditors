using System;


namespace GS4
{
	
	[Serializable]
	public class SystemSaveData
	{
		
		
		public SystemSaveData()
		{
		}

		
		
		public float seMasterVolume;

		
		
		public float bgmMasterVolume;

		
		
		public float voiceMasterVolume;

		
		
		public float ambientMasterVolume;

		
		
		public MessageSpeedType messageSpeedType;

		
		
		public CommandSpeedType commandSpeedType;

		
		
		public bool isLeftHandSupport;

		
		
		public bool enableTutorial;

		
		
		public int messageWindowFrameColorIndex;

		
		
		public int messageWindowBaseColorIndex;

		
		
		public SystemBGCustomType systemBGCustomType;

		
		
		public int systemBGUserCustomColorIndex;

		
		
		public PhotoFrameId photoFrameId;

		
		
		public LaunchVoiceCharId bootVoiceId;

		
		
		public CharacterId evsHelpVoiceId;

		
		
		public int lastSaveSlotIndex;

		
		
		public string lastSaveFamilyName;

		
		
		public string lastSaveFirstName;

		
		
		public int lastSaveFamilyNameEVSNo;

		
		
		public int lastSaveFirstNameEVSNo;

		
		
		public NicknameId[] nicknameIds;

		
		
		public bool[] isChangeNames;

		
		
		public DateTime lastSaveBirthday;

		
		
		public DateTime lastSaveDate;

		
		
		public bool isOpenSkinShipTutorial;

		
		
		public int endingCount;

		
		
		public bool[] isOpenDownloadContents;

		
		
		public bool[] isOpenMiniGames;

		
		
		public bool[] isOpenMiniGameChars;

		
		
		public bool[] isOpenMiniGameClubs;

		
		
		public bool[] isOpenValentineBases;

		
		
		public bool[] isOpenValentineToppings;

		
		
		public bool[] isOpenValentineSpToppings;

		
		
		public bool[] isOpenAlbums;

		
		
		public AdvSaveData[] advs;

		
		
		public bool[] isOpenEndings;

		
		
		public EndingPatternId[] endingPatterns;

		
		
		public EventReplaySaveData[] endingReplayDatas;

		
		
		public bool[] isOpenPhotoFrames;

		
		
		public bool[] isOpenDresses;

		
		
		public bool[] isReadHelps;

		
		
		public int[] allInitimatePointTotals;

		
		
		public ProfileSaveData initialProfileData;

		
		
		public bool enableInitialProfileData;

		
		
		public UserSaveDataHeader[] userSaveDataHeaders;

		
		
		public SaveDataManager.ErrorCode errorCode;
	}
}

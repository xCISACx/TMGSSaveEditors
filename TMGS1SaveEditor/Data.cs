namespace TMGSSaveEditor
{
    public partial class UserSaveDataManager
    {
        public enum CycleCountType
        {
            SchoolOut,
            Date,
            HimuroDate,
            AmanohashiDate,
            Job,
            Friend,
            WDate,
            Club,
        }

        public enum ClubId
        {
            None,
            Baseball,
            Basketball,
            Tennis,
            Support,
            Art,
            Brassband,
            Gardening,
            Handicraft,
        }

        public enum ArbeitId
        {
            None = 0,
            Cafe = 1,
            Gasstand = 2,
            General = 3,
            Boutique = 4,
            Flower = 5,
            BurgerShop = 6,
            Debug = 7,
            Management = 8,
        }

        public enum TestCharId
        {
            Ch01,
            Ch02,
            Ch03,
            Ch04,
            Ch05,
            Ch10,
            Ch11,
            Ch12,
            Ch13,
        }

        public enum DressIdParts
        {
            Inner,
            Outer,
            Bottoms,
            Idk,
            Accessory,
        }

        public enum FashionColorId
        {
            None = 0,
            White = 1,
            Black = 2,
            Red = 3,
            Blue = 4,
            Yellow = 5,
            Green = 6,
            Purple = 7,
            AquaBlue = 8,
            Orange = 9,
            Pink = 10,
            Brown = 11,
            Gray = 12,
        }

        public string[] FashionKindId =>
        [
            "Cardigan",
            "Bolero",
            "Coat",
            "Jacket",
            "Pullover",
            "Vest",
            "Short-Sleeved Blouse",
            "Long-Sleeved Blouse",
            "Sleeveless Blouse",
            "Short-Sleeved T-Shirt",
            "Long-Sleeved T-Shirt",
            "Short-Sleeved Shirt",
            "Long-Sleeved Shirt",
            "Camisole",
            "Summer Knitwear",
            "Tunic",
            "Sweater",
            "Scarf",
            "Cut And Sew",
            "Tank Top",
            "Parka",
            "Poncho",
            "Tube Top",
            "One Shoulder Top",
            "Turtleneck",
            "Flared Skirt",
            "Mini Skirt",
            "Pleated Skirt",
            "Wrap Skirt",
            "Bootcut",
            "Tight Skirt",
            "Hot Pants",
            "Jeans",
            "Pants",
            "Chiffon Skirt",
            "Girly Skirt",
            "Petticoat",
            "Culottes",
            "Bloomers",
            "Satin Skirt",
            "Slit Skirt",
            "Mermaid Skirt",
            "Classic A-Line Skirt",
            "Tulip Skirt",
            "Ruffled Skirt",
            "Camo Skirt",
            "Long Dress",
            "Sleeveless Dress",
            "Cami Dress",
            "Gothic Lolita Dress",
            "Checkered Dress",
            "Floral Dress",
            "Mini Dress",
            "Safari Dress",
            "Jumpsuit",
            "Shawl"
        ];

        public string[] AccessoryKindId =>
        [
            "Hair Clip",
            "Clip",
            "Hairpin",
            "Japanese Hair Accessory",
            "Hair Tie",
            "Earrings",
            "Earrings",
            "Ear Cuffs",
            "Pendant",
            "Necklace",
            "Choker",
            "Bracelet",
            "Bangle",
            "Ring",
            "Brooch",
            "Corsage",
            "Hat",
            "Gloves",
            "Shawl",
        ];
        
        public enum PlayerFlag
        {
            PLFG_BIRTHDAY_GIFT = 0,
            PLFG_CHRISTMAS_GIFT = 1,
            PLFG_CHOCO_DUTY = 2,
            PLFG_CHOCO_HIGH = 3,
            PLFG_CHOCO_MADE = 4,
            PLFG_BIRTHDAY_FROM_MAN = 5,
            PLFG_BIRTHDAY_FROM_WOMAN = 6,
            PLFG_FESTIVAL_CLASS = 7,
            PLFG_BESTFRIEND = 8,
            PLFG_NON_TIME_PROGRESS = 9,
            PLFG_DEFEAT_MEETING = 10,
            PLFG_BESTFRIEND_LOVE = 11,
            PLFG_TIME_PROGRESS = 12,
            PLFG_WIN_PRACTICE_GAME = 13,
            PLFG_BIRTHDAY_PRESENT = 14,
            PLFG_DATE_TROUBLE = 15,
            PLFG_CH01_TEST_HAPPENING = 17,
            PLFG_CH04_TEST_HAPPENING = 18,
            FestivalNotice = 19,
            NIGHT_EVENT = 20,
            _D01_03_000 = 21,
            _B05_07_000 = 22,
            _B05_07_002 = 23,
            _B05_07_003 = 24,
            _D10_09_000 = 25,
            _EVENT_FLAG1_AOKI_EVENT_FINAL = 25,
            _B07_01_010 = 26,
            _B07_02_010 = 27,
            _B07_03_010 = 28,
            _B07_04_010 = 29,
            _B07_05_010 = 30,
            _B07_06_010 = 31,
            _B07_07_010 = 32,
            _B07_08_010 = 33,
            _S11_01_000 = 34,
            _S11_02_000 = 35,
            _S11_03_000 = 36,
            _S11_04_000 = 37,
            _S11_05_000 = 38,
            _S11_06_000 = 39,
            _S11_07_000 = 40,
            _S11_08_000 = 41,
            _S11_14_000 = 42,
            GETMAIL_0 = 43,
            GETMAIL_1 = 44,
            GETMAIL_2 = 45,
            GETMAIL_3 = 46,
            GETMAIL_4 = 47,
            GETMAIL_5 = 48,
            GETMAIL_6 = 49,
            GETMAIL_7 = 50,
            GETMAIL_8 = 51,
            GETMAIL_9 = 52,
            GETMAIL_10 = 53,
            GETMAIL_11 = 54,
            GETMAIL_12 = 55,
            GETMAIL_13 = 56,
            GETMAIL_14 = 57,
            GETMAIL_15 = 58,
            GETMAIL_16 = 59,
            GETMAIL_17 = 60,
            GETMAIL_18 = 61,
            GETMAIL_19 = 62,
            GETMAIL_20 = 63,
            GETMAIL_21 = 64,
            GETMAIL_22 = 65,
            GETMAIL_23 = 66,
            GETMAIL_24 = 67,
            GETMAIL_25 = 68,
            GETMAIL_26 = 69,
            GETMAIL_27 = 70,
            GETMAIL_28 = 71,
            GETMAIL_29 = 72,
            GETMAIL_30 = 73,
            GETMAIL_31 = 74,
            GETMAIL_32 = 75,
            GETMAIL_33 = 76,
            GETMAIL_34 = 77,
            GETMAIL_35 = 78,
            GETMAIL_36 = 79,
            GETMAIL_37 = 80,
            GETMAIL_38 = 81,
        }

        public enum CharFlag
        {
            NameChange = 0,
            BusyApproach = 1,
            BusyFriend = 2,
            SickVisit = 3,
            BombEvent1 = 4,
            BombEvent2 = 5,
            BombEvent3 = 6,
            BombEvent4 = 7,
            Rival = 8,
            RivalCancel = 9,
            RivalGiveup = 10, // 0x0000000A
            RivalCouple = 11, // 0x0000000B
            CH_TEL = 12, // 0x0000000C
            CH_GEKOU_NG = 13, // 0x0000000D
            CH_BESTFRIEND_LOVE = 14, // 0x0000000E
            CH_FRIEND_OS_LOVE = 15, // 0x0000000F
            CH_SELECT1_OK = 16, // 0x00000010
            CH_SELECT4_OK = 17, // 0x00000011
            CH_SELECT5_OK = 18, // 0x00000012
            CH_GET_ACCE = 19, // 0x00000013
            CH_DREAM = 20, // 0x00000014
            CH_HOBBY = 21, // 0x00000015
            CH_TV = 22, // 0x00000016
            CH_FOOD = 23, // 0x00000017
            CH_SPORTS = 24, // 0x00000018
            CH_SOUND = 25, // 0x00000019
            CH_SCHOOL = 26, // 0x0000001A
            CH_TYPE = 27, // 0x0000001B
            CH_LOVE = 28, // 0x0000001C
            CH_KISS = 29, // 0x0000001D
            CH_ATTEMPTED = 30, // 0x0000001E
            CH_BOYSHOUSE = 31, // 0x0000001F
            CH_KISS_TALK1 = 32, // 0x00000020
            CH_KISS_TALK2 = 33, // 0x00000021
            CH_KISS_TALK3 = 34, // 0x00000022
            CH_KISS_TALK4 = 35, // 0x00000023
            _PARAM_CHARA_BIT_SPORTS_DAY_EVENT = 36, // 0x00000024
            _PARAM_CHARA_BIT_SPECIAL_EVENT1 = 37, // 0x00000025
            _PARAM_CHARA_BIT_SPECIAL_EVENT2 = 38, // 0x00000026
            _PARAM_CHARA_BIT_SPECIAL_EVENT3 = 39, // 0x00000027
            _PARAM_CHARA_BIT_SPECIAL_EVENT4 = 40, // 0x00000028
        }

        public enum CharCounter
        {
            BGIFT1 = 0,
            BGIFT2 = 1,
            WHITE_THREE = 2,
            CH_OMIKUZI_CNT = 3,
            CH_SHRINE_CNT = 4,
            MEET_ADV = 5,
            CH_EVENT1_CNT = 6,
            CH_EVENT2_CNT = 7,
            CH_EVENT3_CNT = 8,
            CH_EVENT4_CNT = 9,
            CH_VALENTINE_CNT = 10, // 0x0000000A
            CH_VALENTINE = 11, // 0x0000000B
            friendEventCnt = 12, // 0x0000000C
            VALENTAIN = 13, // 0x0000000D
            NENGA = 14, // 0x0000000E
            rivalCounter = 15, // 0x0000000F
        }

        public enum DateTopicBoy
        {
            _DTB1_TV = 0,
            _DTB1_FOOD = 1,
            DTB1_SPORTS = 2,
            DTB1_MUSIC = 3,
            DTB1_INTEREST = 4,
            DTB1_SCHOOL = 5,
            DTB1_DREAM = 6,
            DTB1_GIRL = 7,
            DTB1_DOKI = 8,
            DTB1_CHARM = 9,
            DTB1_MAN = 10, // 0x0000000A
            DTB1_LOVE = 11, // 0x0000000B
            DTB1_KISS = 12, // 0x0000000C
            DTB2_MAX = 12, // 0x0000000C
            DTB1_LIKE = 13, // 0x0000000D
            DTB1_MAX = 14, // 0x0000000E
            DTB2_GIRL = 14, // 0x0000000E
            DTB2_DOKI = 15, // 0x0000000F
            DTB2_CHARM = 16, // 0x00000010
            DTB2_MAN = 17, // 0x00000011
            DTB2_GIRL2 = 18, // 0x00000012
            DTB2_DOKI2 = 19, // 0x00000013
            DTB2_CHARM2 = 20, // 0x00000014
            DTB2_OWATA = 21, // 0x00000015
            DTB2_MAN2 = 22, // 0x00000016
            DTB2_OWATA2 = 23, // 0x00000017
            DTB2_LOVE = 24, // 0x00000018
            DTB2_KISS = 25, // 0x00000019
            DTB_MAX = 26, // 0x0000001A
        }

        public enum EndingId
        {
            Ch01Normal = 1,
            Ch02Normal = 2,
            Ch03Normal = 3,
            Ch04Normal = 4,
            Ch05Normal = 5,
            Ch06Normal = 6,
            Ch07Normal = 7,
            Ch08Normal = 8,
            Ch09 = 9,
            Ch17 = 10, // 0x0000000A
            Ch01BSFDLove = 11, // 0x0000000B
            Ch02BSFDLove = 12, // 0x0000000C
            Ch03BSFDLove = 13, // 0x0000000D
            Ch04BSFDLove = 14, // 0x0000000E
            Ch05BSFDLove = 15, // 0x0000000F
            Ch06BSFDLove = 16, // 0x00000010
            Ch07BSFDLove = 17, // 0x00000011
            Ch08BSFDLove = 18, // 0x00000012
            Ch01BSFDFriend = 21, // 0x00000015
            Ch02BSFDFriend = 22, // 0x00000016
            Ch03BSFDFriend = 23, // 0x00000017
            Ch04BSFDFriend = 24, // 0x00000018
            Ch05BSFDFriend = 25, // 0x00000019
            Ch06BSFDFriend = 26, // 0x0000001A
            Ch07BSFDFriend = 27, // 0x0000001B
            Ch08BSFDFriend = 28, // 0x0000001C
            Ch10 = 30, // 0x0000001E
            Ch11 = 31, // 0x0000001F
            Ch12 = 32, // 0x00000020
            Ch13 = 33, // 0x00000021
            Bad = 34, // 0x00000022
            Ch15 = 35, // 0x00000023
            Ch17Black = 37, // 0x00000025
        }

        public enum OneYearCommandType
        {
            Study,
            Sports,
            Art,
            Charm,
            Fashion,
            Friend1,
            Friend2,
            Friend3,
            Friend4,
            Rest,
        }

        public enum ShopId
        {
            None = -1, // 0xFFFFFFFF
            Sierra = 0,
            Jess = 1,
            Nanami = 2,
            Sofia = 3,
            Simon = 4,
            Vincent = 5,
            Gekkudosho = 6,
            Miluihi = 7,
            Ebisumaru = 8,
            FleaMarket = 9,
        }

        public enum DateContent
        {
            None = -1, // 0xFFFFFFFF
            Shop = 1,
            Movie1 = 2,
            Movie2 = 3,
            Movie3 = 4,
            Movie4 = 5,
            Movie5 = 6,
            Movie6 = 7,
            Movie7 = 8,
            Movie8 = 9,
            Movie9 = 10, // 0x0000000A
            Movie10 = 11, // 0x0000000B
            Livehouse1 = 12, // 0x0000000C
            Livehouse2 = 13, // 0x0000000D
            Livehouse3 = 14, // 0x0000000E
            Livehouse4 = 15, // 0x0000000F
            Bowling1 = 16, // 0x00000010
            Bowling2 = 17, // 0x00000011
            Bowling3 = 18, // 0x00000012
            Gamecenter1 = 19, // 0x00000013
            Gamecenter2 = 20, // 0x00000014
            Gamecenter3 = 21, // 0x00000015
            Karaoke = 22, // 0x00000016
            Planetarium = 23, // 0x00000017
            Park = 25, // 0x00000019
            Freemarket = 26, // 0x0000001A
            Forest1 = 27, // 0x0000001B
            Forest2 = 28, // 0x0000001C
            Forest3 = 29, // 0x0000001D
            Forest4 = 30, // 0x0000001E
            Forest5 = 31, // 0x0000001F
            Plant = 32, // 0x00000020
            Museum1 = 33, // 0x00000021
            Museum2 = 34, // 0x00000022
            Museum3 = 35, // 0x00000023
            Pool = 36, // 0x00000024
            Skatingrink = 37, // 0x00000025
            Mountain1 = 41, // 0x00000029
            Mountain2 = 42, // 0x0000002A
            Themepark1 = 43, // 0x0000002B
            Themepark2 = 44, // 0x0000002C
            Themepark3 = 45, // 0x0000002D
            Themepark4 = 46, // 0x0000002E
            Themepark5 = 47, // 0x0000002F
            Themepark6 = 48, // 0x00000030
            Zoo1 = 49, // 0x00000031
            Zoo2 = 51, // 0x00000033
            Shopmall = 52, // 0x00000034
            Seaside1 = 53, // 0x00000035
            Seaside2 = 54, // 0x00000036
            Seaside3 = 55, // 0x00000037
            Fireworks = 56, // 0x00000038
            Sea = 57, // 0x00000039
            Aquarium = 58, // 0x0000003A
            Eventhall1 = 59, // 0x0000003B
            Eventhall2 = 60, // 0x0000003C
            Eventhall3 = 61, // 0x0000003D
            Eventhall4 = 62, // 0x0000003E
            Eventhall5 = 63, // 0x0000003F
            Eventhall6 = 64, // 0x00000040
            Eventhall7 = 65, // 0x00000041
            SkyLounge = 66, // 0x00000042
            Cruiser = 67, // 0x00000043
            Home = 68, // 0x00000044
            Drive = 69, // 0x00000045
        }
        
        public enum ChocoType
        {
            Courtesy = 0,
            Luxury,
            Handmade,
        }
        
        public enum NamedCharacterId
        {
            None = -1, // 0xFFFFFFFF
            Player = 0,
            Hazuki = 1,
            Morimura = 2,
            Mihara = 3,
            Kijyo = 4,
            Suzuka = 5,
            Hibiya = 6,
            Himuro = 7,
            Amanohashi = 8,
            Chiharu = 9,
            Arisawa = 10, // 0x0000000A
            Sudo = 11, // 0x0000000B
            Fuji = 12, // 0x0000000C
            Konno = 13, // 0x0000000D
            Tsukushi = 14, // 0x0000000E
            Goro = 15, // 0x0000000F
            Ch16 = 16, // 0x00000010
            Tendo = 17, // 0x00000011
            Ch18 = 18, // 0x00000012
            Ch19 = 19, // 0x00000013
            Ch20 = 20, // 0x00000014
            Ch21 = 21, // 0x00000015
        }
        
        public enum ScriptWork
        {
          _SCRIPT_GLOBAL_BIRTHDAY = 0,
          _SCRIPT_GLOBAL_33EVENT = 1,
          _SCRIPT_GLOBAL_SUZUKA_TEAR = 2,
          _SCRIPT_GLOBAL_HADUKI_DREAM = 3,
          _SCRIPT_GLOBAL_HANATUBAKI = 4,
          _SCRIPT_GLOBAL_RAND_CHARA = 5,
          _SCRIPT_GLOBAL_RAND04 = 6,
          _SCRIPT_GLOBAL_TENDO = 8,
          _SCRIPT_GLOBAL_ENDING = 12, // 0x0000000C
          _SCRIPT_GLOBAL_INVITE = 13, // 0x0000000D
          _SCRIPT_GLOBAL_EVENT_NO = 14, // 0x0000000E
          _SCRIPT_GLOBAL_D01EVENT_1_3 = 15, // 0x0000000F
          _SCRIPT_GLOBAL_EVENT_HANABI = 16, // 0x00000010
          _SCRIPT_GLOBAL_01 = 17, // 0x00000011
          _SCRIPT_GLOBAL_02 = 18, // 0x00000012
          _SCRIPT_GLOBAL_03 = 19, // 0x00000013
          _SCRIPT_GLOBAL_04 = 20, // 0x00000014
          _SCRIPT_GLOBAL_05 = 21, // 0x00000015
          _SCRIPT_GLOBAL_06 = 22, // 0x00000016
          _SCRIPT_GLOBAL_07 = 23, // 0x00000017
          _SCRIPT_GLOBAL_08 = 24, // 0x00000018
          _SCRIPT_GLOBAL_09 = 25, // 0x00000019
          _SCRIPT_GLOBAL_10 = 26, // 0x0000001A
          _SCRIPT_GLOBAL_POSE_DEBUG = 27, // 0x0000001B
          _SCRIPT_GLOBAL_SEC_RESULT = 28, // 0x0000001C
          _SCRIPT_GLOBAL_DATE_PEOPLE = 29, // 0x0000001D
          _SCRIPT_GLOBAL_POSE = 30, // 0x0000001E
          _SCRIPT_GLOBAL_HMAN = 31, // 0x0000001F
          _SCRIPT_GLOBAL_MAX = 32, // 0x00000020
        }
    }
}

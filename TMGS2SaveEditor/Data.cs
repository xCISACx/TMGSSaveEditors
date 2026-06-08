namespace TMGSSaveEditor
{
    public partial class UserSaveDataManager
    {
        public enum CycleCountType
        {
            SchoolOut,
            Date,
            ExClass,
            SoloGoOut,
            School,
            Arbeit,
            Friend,
            WDate,
            Ch07Date,
            Ch08Date,
        }

        public enum ClubId
        {
            None,
            Baseball,
            Lacrosse,
            TrackAndField,
            Support,
            Art,
            Brassband,
            Handicraft,
            Executives,
        }

        public enum ArbeitId
        {
            None = 0,
            Cafe = 1,
            MusicStore = 2,
            Sweets = 3,
            SelectShop = 4,
            Flower = 5,
            Gasstand = 6,
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
            Ch06,
            Ch07,
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
            "Bootcut Jeans",
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
            "Shawl",
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
            PLFG_JUDO_INVITE = 9,
            PLFG_NON_TIME_PROGRESS = 10, // 0x0000000A
            PLFG_M4_APPEAR_EVENT = 11, // 0x0000000B
            PLFG_PLAY_TRUANT_CLUB = 12, // 0x0000000C
            PLFG_DEFEAT_MEETING = 13, // 0x0000000D
            PLFG_M4_APPEAR_EVENT2 = 14, // 0x0000000E
            PLFG_STAY_FRIEND = 15, // 0x0000000F
            PLFG_THREE_LEAVING_SCHOOL = 16, // 0x00000010
            PLFG_GHOST_HOUSE_BEFORE = 17, // 0x00000011
            PLFG_THREE_DATE_INVITE = 18, // 0x00000012
            PLFG_THREE_DATE_BECOME = 19, // 0x00000013
            PLFG_SANDY_BEACH_TALK = 20, // 0x00000014
            PLFG_DTSP_M2_SKATINGRINK = 21, // 0x00000015
            PLFG_TALK_M4_HOBBY = 22, // 0x00000016
            PLFG_JUDO_CONCERN = 23, // 0x00000017
            PLFG_DTSP_M5_HOME = 24, // 0x00000018
            PLFG_M1_INVITE_HOME = 25, // 0x00000019
            PLFG_M4_TRIP = 26, // 0x0000001A
            PLFG_CHILD_FRIEND = 27, // 0x0000001B
            PLFG_M4_JOIN_JUDO = 28, // 0x0000001C
            PLFG_EMAIL_FROM_MAN = 29, // 0x0000001D
            PLFG_CHRISTMAS_INVITE = 30, // 0x0000001E
            PLFG_M1_HOSPITAL = 31, // 0x0000001F
            PLFG_M1_SCHOOLOUTINVITED = 32, // 0x00000020
            PLFG_BESTFRIEND_LOVE = 33, // 0x00000021
            PLFG_S1_TRAINING = 34, // 0x00000022
            PLFG_WDATE_TRI_A = 35, // 0x00000023
            PLFG_WDATE_TRI_B = 36, // 0x00000024
            PLFG_WDATE_TRI_C = 37, // 0x00000025
            PLFG_SHRINE_GIRL = 38, // 0x00000026
            PLFG_STAY_PARTICIPATE = 39, // 0x00000027
            PLFG_TIME_PROGRESS = 40, // 0x00000028
            PLFG_M4_APPEAR_EVENT4 = 41, // 0x00000029
            PLFG_WIN_PRACTICE_GAME = 42, // 0x0000002A
            PLFG_TRI_A_FIGHT_DEVT1 = 43, // 0x0000002B
            PLFG_TRI_A_FIGHT_DEVT2 = 44, // 0x0000002C
            PLFG_TRI_A_FIGHT_DEVT3 = 45, // 0x0000002D
            PLFG_TRI_A_FIGHT_SEVT1 = 46, // 0x0000002E
            PLFG_TRI_A_FIGHT_SEVT2 = 47, // 0x0000002F
            PLFG_TRI_A_FIGHT_SEVT3 = 48, // 0x00000030
            PLFG_TRI_A_FIGHT_PEVT1 = 49, // 0x00000031
            PLFG_TRI_A_FIGHT_PEVT2 = 50, // 0x00000032
            PLFG_TRI_A_FIGHT_PEVT3 = 51, // 0x00000033
            PLFG_TRI_B_FIGHT_DEVT1 = 52, // 0x00000034
            PLFG_TRI_B_FIGHT_DEVT2 = 53, // 0x00000035
            PLFG_TRI_B_FIGHT_DEVT3 = 54, // 0x00000036
            PLFG_TRI_B_FIGHT_SEVT1 = 55, // 0x00000037
            PLFG_TRI_B_FIGHT_SEVT2 = 56, // 0x00000038
            PLFG_TRI_B_FIGHT_SEVT3 = 57, // 0x00000039
            PLFG_TRI_B_FIGHT_PEVT1 = 58, // 0x0000003A
            PLFG_TRI_B_FIGHT_PEVT2 = 59, // 0x0000003B
            PLFG_TRI_B_FIGHT_PEVT3 = 60, // 0x0000003C
            PLFG_TRI_A_DEFEAT = 61, // 0x0000003D
            PLFG_TRI_B_DEFEAT = 62, // 0x0000003E
            PLFG_G2_FASHION_CHECK = 63, // 0x0000003F
            PLFG_M4_ARBEIT_EVT1 = 64, // 0x00000040
            PLFG_M4_ARBEIT_EVT2 = 65, // 0x00000041
            PLFG_M3_COURSE_EVT1 = 66, // 0x00000042
            PLFG_M3_COURSE_EVT2 = 67, // 0x00000043
            PLFG_JOIN_JUDO = 68, // 0x00000044
            PLFG_M6_PIANO_CONTEST = 69, // 0x00000045
            PLFG_G1_FESTIVAL = 70, // 0x00000046
            PLFG_G1_FIELDDAY = 71, // 0x00000047
            PLFG_JUDO_CAMP = 72, // 0x00000048
            PLFG_M4_APPEAR_EVENT3 = 73, // 0x00000049
            PLFG_DATE_TROUBLE = 74, // 0x0000004A
            PLFG_THREE_DATE_RUN = 75, // 0x0000004B
            PLFG_0A_3DATE_FIREWORK = 76, // 0x0000004C
            PLFG_TRI_FRIEND_DECLARE = 77, // 0x0000004D
            PLFG_ED_LINING_UP = 78, // 0x0000004E
            PLFG_TEST_TOP = 79, // 0x0000004F
            PLFG_ART_PARA = 80, // 0x00000050
            PLFG_ART_YEAR_CHECK = 81, // 0x00000051
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
            RivalBetrayal = 12, // 0x0000000C
            CH_TEL = 13, // 0x0000000D
            CH_GEKOU_NG = 14, // 0x0000000E
            CH_BESTFRIEND_LOVE = 15, // 0x0000000F
            CH_FRIEND_OS_LOVE = 16, // 0x00000010
            CH_SELECT1_OK = 17, // 0x00000011
            CH_SELECT4_OK = 18, // 0x00000012
            CH_SELECT5_OK = 19, // 0x00000013
            CH_GET_ACCE = 20, // 0x00000014
            CH_DREAM = 21, // 0x00000015
            CH_HOBBY = 22, // 0x00000016
            CH_TV = 23, // 0x00000017
            CH_FOOD = 24, // 0x00000018
            CH_SPORTS = 25, // 0x00000019
            CH_SOUND = 26, // 0x0000001A
            CH_SCHOOL = 27, // 0x0000001B
            CH_TYPE = 28, // 0x0000001C
            CH_LOVE = 29, // 0x0000001D
            CH_KISS = 30, // 0x0000001E
            CH_ATTEMPTED = 31, // 0x0000001F
            CH_BOYSHOUSE = 32, // 0x00000020
            CH_KISS_TALK1 = 33, // 0x00000021
            CH_KISS_TALK2 = 34, // 0x00000022
            CH_KISS_TALK3 = 35, // 0x00000023
            CH_KISS_TALK4 = 36, // 0x00000024
            CHANGE_CLUB = 37, // 0x00000025
            CHS_CHRISTMAS_OK1 = 38, // 0x00000026
            CHS_CHRISTMAS_OK2 = 39, // 0x00000027
        }

        public enum CharCounter
        {
            BGIFT1 = 0,
            BGIFT2 = 1,
            CH_WHITEDAY_CNT = 2,
            CH_OMIKUZI_CNT = 3,
            CH_SHRINE_CNT = 4,
            MEET_ADV = 5,
            CH_EVENT1_CNT = 6,
            CH_EVENT2_CNT = 7,
            CH_EVENT3_CNT = 8,
            CH_EVENT4_CNT = 9,
            CH_VALENTINE_CNT = 10, // 0x0000
            CHCT_G1_OUT_PLAY = 11, // 0x0000
            CH_VALENTINE = 12, // 0x0000000C
            rivalCounter = 13, // 0x0000000D
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
            None = -1, // 0xFFFFFFFF
            Ch01Normal = 0,
            Ch02Normal = 1,
            Ch03Normal = 2,
            Ch04Normal = 3,
            Ch05Normal = 4,
            Ch06Normal = 5,
            Ch07Normal = 6,
            Ch08Normal = 7,
            Ch01True = 8,
            Ch02True = 9,
            Ch03True = 10, // 0x0000000A
            Ch04True = 11, // 0x0000000B
            Ch05True = 12, // 0x0000000C
            Ch06True = 13, // 0x0000000D
            Ch07True = 14, // 0x0000000E
            Ch08True = 15, // 0x0000000F
            Ch01Second = 16, // 0x00000010
            Ch02Second = 17, // 0x00000011
            Ch03Second = 18, // 0x00000012
            Ch04Second = 19, // 0x00000013
            Ch05Second = 20, // 0x00000014
            Ch06Second = 21, // 0x00000015
            Ch07Second = 22, // 0x00000016
            Ch08Second = 23, // 0x00000017
            Ch01BSFDLove = 24, // 0x0000001
            Ch02BSFDLove = 25, // 0x0000001
            Ch03BSFDLove = 26, // 0x0000001
            Ch04BSFDLove = 27, // 0x0000001
            Ch05BSFDLove = 28, // 0x0000001
            Ch06BSFDLove = 29, // 0x0000001
            Ch07BSFDLove = 30, // 0x0000001
            Ch08BSFDLove = 31, // 0x0000001
            Ch01BSFDFriend = 32, // 0x00000
            Ch02BSFDFriend = 33, // 0x00000
            Ch03BSFDFriend = 34, // 0x00000
            Ch04BSFDFriend = 35, // 0x00000
            Ch05BSFDFriend = 36, // 0x00000
            Ch06BSFDFriend = 37, // 0x00000
            Ch07BSFDFriend = 38, // 0x00000
            Ch08BSFDFriend = 39, // 0x00000
            Ch09 = 40, // 0x00000028
            Ch25 = 41, // 0x00000029
            Ch26 = 42, // 0x0000002A
            Bad = 43, // 0x0000002B
            Ch14 = 44, // 0x0000002C
            Ch15 = 45, // 0x0000002D
            Ch10 = 46, // 0x0000002E
            Ch11 = 47, // 0x0000002F
            Ch12 = 48, // 0x00000030
            Ch13 = 49, // 0x00000031
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
            Club,
            Executives,
            Arbeit,
            Special1,
            Special2,
        }

        public enum ShopId
        {
            None = -1, // 0xFFFFFFFF
            Dixie = 0,
            Jess = 1,
            Nanami = 2,
            Sofia = 3,
            Simon = 4,
            Kurusu = 5,
            AntiqueShopChip = 6,
            Almira = 7,
            CrimsonShadow = 8,
            Freemarket = 9,
        }

        public enum DateContent
        {
            None = -1,
            ShoppingMall,
            BrickPath,
            BSBObservatory,
            TourBoat,
            AquariumNormal,
            OrcaShow,
            DolphinExhibition,
            ClassicalOrchestraKCH,
            RumbleBoys,
            VividZipperHold,
            FourSeasonsTroupeTheOpera,
            TalentedFemaleSingerOobayashiMaki,
            CAMINOMajorDebut,
            SkyGarden,
            Fireworks,
            Beach,
            Grotto,
            ParkAvenue,
            ForestParkFountains,
            ForestParkSpring,
            ForestParkCherryBlossoms,
            ForestParkSummer,
            ForestParkAutumn,
            Winter,
            BotanicalGardenNormal,
            MuseumNormal,
            MuseumGlassExhibition,
            MuseumDinosaurs,
            MuseumArtExhibition,
            MuseumMiharaShikiExhibition,
            SkatingRink,
            Pool,
            FleaMarket,
            Shop,
            Shop2,
            Shop3,
            TheatreGroupYamate,
            HumanLife,
            Needs,
            DigMouseBrothers,
            CAMINO,
            InamuraJoujiTalk,
            SmileJives,
            Bowling,
            Darts,
            GameCorner,
            MedalCorner,
            MusicCorner,
            Karaoke,
            CUTTERvsFanger,
            Stairs,
            SilentHill,
            BeetleMan,
            SPINNING2,
            Micro,
            CatherineBarnesDiary,
            LargeLove,
            OurSecret,
            Celsius,
            TheHouseNextDoor,
            CondemnedCell,
            MountainAutumn,
            MountainSkiing,
            ZooNormal,
            ZooPuppyKittenLand,
            ZooWhiteTiger,
            Exhibition,
            CastleTower,
            RollerCoaster,
            FerrisWheel,
            MerryGoRound,
            HauntedHouse,
            NightParade,
            GoKarts,
            GTRacing1,
            GTRacing2,
            GTRacing3,
            HisRoom,
            Drive = 78
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
            Saeki = 1,
            Shiba = 2,
            Hikami = 3,
            Harry = 4,
            Chris = 5,
            Amachi = 6,
            Wakaouji = 7,
            Masaki = 8,
            Akagi = 9,
            Toudou = 10, // 0x0000000A
            Onoda = 11, // 0x0000000B
            Nishimoto = 12, // 0x0000000C
            Mizushima = 13, // 0x0000000D
            Yuu = 14, // 0x0000000E
            Himeko = 15, // 0x0000000F
            Master = 16, // 0x00000010
            Arisawa = 17, // 0x00000011
            Ch18 = 18, // 0x00000012
            Ch19 = 19, // 0x00000013
            Ch20 = 20, // 0x00000014
            Ch21 = 21, // 0x00000015
            Ch22 = 22, // 0x00000016
            Ch23 = 23, // 0x00000017
            Ch24 = 24, // 0x00000018
            Komori = 25, // 0x00000019
            Majima = 26, // 0x0000001A
        }
        
        public enum ScriptWork
        {
            _SCRIPT_GLOBAL_KOMORI_LIMIT,
            _SCRIPT_GLOBAL_RAND_CHARA,
            _SCRIPT_GLOBAL_RAND04,
            _SCRIPT_GLOBAL_ENDING,
            _SCRIPT_GLOBAL_05,
            _SCRIPT_GLOBAL_06,
            _SCRIPT_GLOBAL_07,
            _SCRIPT_GLOBAL_08,
            _SCRIPT_GLOBAL_10,
            _SCRIPT_GLOBAL_GS2_00,
            _SCRIPT_GLOBAL_GS2_01,
            _SCRIPT_GLOBAL_GS2_02,
            _SCRIPT_GLOBAL_GS2_03,
            _SCRIPT_GLOBAL_GS2_04,
            _SCRIPT_GLOBAL_GS2_05,
            _SCRIPT_GLOBAL_GS2_06,
            _SCRIPT_GLOBAL_GS2_07,
            _SCRIPT_GLOBAL_GS2_08,
            _SCRIPT_GLOBAL_19,
            _SCRIPT_GLOBAL_20,
            _SCRIPT_GLOBAL_21,
            _SCRIPT_GLOBAL_22,
            _SCRIPT_GLOBAL_POSE_DEBUG,
            _SCRIPT_GLOBAL_SEC_RESULT,
            _SCRIPT_GLOBAL_DATE_PEOPLE,
            _SCRIPT_GLOBAL_POSE,
            _SCRIPT_GLOBAL_HMAN,
            _SCRIPT_GLOBAL_KOMORI,
            _SCRIPT_GLOBAL_MATARO,
            _SCRIPT_GLOBAL_AKAGISEL1_OK,
            _SCRIPT_GLOBAL_AKAGISEL2_OK,
            _SCRIPT_GLOBAL_AKAGISEL3_OK,
            _SCRIPT_GLOBAL_BESTFRIEND_CH,
            _SCRIPT_GLOBAL_CH_M8_KAGAI,
            _SCRIPT_GLOBAL_KOMORI_INTERVAL,
            _SCRIPT_GLOBAL_MATARO_INTERVAL,
        }
    }
}

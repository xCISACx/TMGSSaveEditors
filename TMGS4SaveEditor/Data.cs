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
            Stay,
            GroupDate,
            Club,
            ValentineDay1WeekAgo,
            SchoolMeal,
            Ch09,
            Ch10,
            Ch11,
        }

        public enum ClubId
        {
            None,
            Baseball,
            Athletics,
            Judo,
            Gymnastics,
            Brassband,
            Gardening,
            Handicraft,
            Executives,
        }

        public enum ArbeitId
        {
            None = 0,
            Cafe = 1,
            Flower = 2,
            Gasstand = 3,
            General = 4,
            Sweets = 5,
            Bookstore = 6,
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
            Ch21,
            Ch22,
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
            "Short Sleeve T-Shirt",
            "Long Sleeve T-Shirt",
            "Camisole",
            "Blouse",
            "Tunic",
            "Tank Top",
            "Tube Top",
            "Shirt",
            "Polo Shirt",
            "Sweatshirt",
            "Sweater",
            "Hoodie",
            "Bolero",
            "Cardigan",
            "Coat",
            "Poncho",
            "Jersey",
            "Jacket",
            "Down Jacket",
            "Vest",
            "Down Vest",
            "Mini Skirt",
            "Tight Skirt",
            "Long Skirt",
            "Hot Pants",
            "Short Pants",
            "Trousers",
            "Half Pants",
            "Long Pants",
            "Leggings",
            "Dress",
            "Jumpsuit",
            "Overalls",
        ];

        public string[] AccessoryKindId =>
        [
            "Fan",
            "Folding Fan",
            "Cap",
            "Sun Visor",
            "Hat",
            "Knit Cap",
            "Hair Accessory",
            "Scarf",
            "Stole",
            "Gloves",
            "Earrings",
            "Necklace",
            "Wristband",
            "Bracelet",
            "Bangle",
            "Japanese Hair Accessory",
            "Glasses",
            "Sunglasses",
        ];
        
        public enum PlayerFlag
        {
            GetBirthdayPresent = 0,
            BirthdayFromApproach = 1,
            BirthdayFromFriend = 2,
            OpenGarden = 3,
            StayFriendReply = 4,
            StayFriend = 5,
            Excursion = 6,
            GameWin = 7,
            Ch01FerrisWheelS = 8,
            FashionCheck = 9,
            FashionCheckItem = 10, // 0x0000000A
            RoseQueen = 11, // 0x0000000B
            FesHandicraft3 = 12, // 0x0000000C
            FesGardening3 = 13, // 0x0000000D
            NininsankyakuCh02 = 14, // 0x0000000E
            NininsankyakuCh06 = 15, // 0x0000000F
            SchoolMealCh01 = 16, // 0x00000010
            SchoolMealCh05 = 17, // 0x00000011
            Ch06PoolNotA = 18, // 0x00000012
            FirstGondola = 19, // 0x00000013
            FirstDemoted = 20, // 0x00000014
            TogetherACh08 = 21, // 0x00000015
            TogetherBCh08 = 22, // 0x00000016
        }

        public enum CharFlag
        {
            Attempt = 0,
            Christmas2 = 1,
            Christmas3 = 2,
            NameCallEvent = 3,
            NameChange = 4,
            FashionHaduki = 5,
            HearLove = 6,
            Busy = 7,
            BirthdayAccessory = 8,
            Omen = 9,
            Relied = 10, // 0x0000000A
            BombEvent1 = 11, // 0x0000000B
            BombEvent2 = 12, // 0x0000000C
            BombEvent3 = 13, // 0x0000000D
            BombEvent4 = 14, // 0x0000000E
            NewYear = 15, // 0x0000000F
            BirthdayPresentCheap = 16, // 0x00
            SchoolOutNG = 17, // 0x00000011
            DateInviteNG = 18, // 0x00000012
            RenameNG = 19, // 0x00000013
            WdateOnlyOne = 20, // 0x00000014
            HearTV = 21, // 0x00000015
            HearSchool = 22, // 0x00000016
            HearHobby = 23, // 0x00000017
            SchoolOut = 24, // 0x00000018
            HearLike = 25, // 0x00000019
            Garden = 26, // 0x0000001A
            QuitArbeit = 27, // 0x0000001B
        }

        public enum CharCounter
        {
            CHCT_B1_EXTRA = 0,
            CHCT_E8_EVENT_COUNT = 0,
            CHCT_E9_EVENT_COUNT = 0,
            CHCT_G1_WEEKDAY_EVENT1 = 0,
            CHCT_G2_WEEKDAY_EVENT1 = 0,
            CHCT_M1_BIRTHDAY_GIFT = 0,
            CHCT_M2_BIRTHDAY_GIFT = 0,
            CHCT_M3_BIRTHDAY_GIFT = 0,
            CHCT_M4_BIRTHDAY_GIFT = 0,
            CHCT_M5_BIRTHDAY_GIFT = 0,
            CHCT_M6_BIRTHDAY_GIFT = 0,
            CHCT_S1_SENIOR_POINT = 0,
            CHCT_S2_EVENT_COUNT = 0,
            CHCT_B1_EVENT_COUNT = 1,
            CHCT_E9_TALK_COUNT_01 = 1,
            CHCT_G1_WEEKDAY_EVENT2 = 1,
            CHCT_G2_WEEKDAY_EVENT2 = 1,
            CHCT_M1_WHITEDAY_GIFT = 1,
            CHCT_M2_WHITEDAY_GIFT = 1,
            CHCT_M3_WHITEDAY_GIFT = 1,
            CHCT_M4_WHITEDAY_GIFT = 1,
            CHCT_M5_WHITEDAY_GIFT = 1,
            CHCT_M6_WHITEDAY_GIFT = 1,
            CHCT_S1_DATE_COURSE = 1,
            CHCT_S2_DAY_COUNT = 1,
            CHCT_B1_FESTIVAL_COUNT = 2,
            CHCT_E9_TALK_COUNT_02 = 2,
            CHCT_G1_FESTIVAL_EVENT = 2,
            CHCT_G2_FESTIVAL_EVENT = 2,
            CHCT_M1_OMIKUJI = 2,
            CHCT_M2_OMIKUJI = 2,
            CHCT_M3_OMIKUJI = 2,
            CHCT_M4_OMIKUJI = 2,
            CHCT_M5_OMIKUJI = 2,
            CHCT_M6_OMIKUJI = 2,
            CHCT_S1_CLUB_EX_VALUE1 = 2,
            CHCT_S2_CMD_COUNT = 2,
            CHCT_E9_MISSED_COUNT = 3,
            CHCT_G1_CHOCO_EVENT = 3,
            CHCT_G2_CHOCO_EVENT = 3,
            CHCT_M1_CHOCO = 3,
            CHCT_M2_CHOCO = 3,
            CHCT_M3_CHOCO = 3,
            CHCT_M4_CHOCO = 3,
            CHCT_M5_CHOCO = 3,
            CHCT_M6_CHOCO = 3,
            CHCT_S1_CLUB_EX_REST1 = 3,
            CHCT_E9_KEEP_COUNT = 4,
            CHCT_G1_OUT_PLAY = 4,
            CHCT_G2_OUT_PLAY = 4,
            CHCT_M1_WEEKDAY_EVENT1 = 4,
            CHCT_M2_WEEKDAY_EVENT1 = 4,
            CHCT_M3_WEEKDAY_EVENT1 = 4,
            CHCT_M4_WEEKDAY_EVENT1 = 4,
            CHCT_M5_WEEKDAY_EVENT1 = 4,
            CHCT_M6_WEEKDAY_EVENT1 = 4,
            CHCT_S1_HELP_DAY_COUNT = 4,
            CHCT_E9_APPEAR_PROB = 5,
            CHCT_G1_WEEKDAY_EVENT3 = 5,
            CHCT_G2_WEEKDAY_EVENT3 = 5,
            CHCT_M1_WEEKDAY_EVENT2 = 5,
            CHCT_M2_WEEKDAY_EVENT2 = 5,
            CHCT_M3_WEEKDAY_EVENT2 = 5,
            CHCT_M4_WEEKDAY_EVENT2 = 5,
            CHCT_M5_WEEKDAY_EVENT2 = 5,
            CHCT_M6_WEEKDAY_EVENT2 = 5,
            CHCT_S1_RAND_COUNT = 5,
            CHCT_E9_LOOP_COUNT = 6,
            CHCT_G1_BIRTHDAY_GIFT = 6,
            CHCT_G2_BIRTHDAY_GIFT = 6,
            CHCT_M1_WEEKDAY_EVENT3 = 6,
            CHCT_M2_WEEKDAY_EVENT3 = 6,
            CHCT_M3_WEEKDAY_EVENT3 = 6,
            CHCT_M4_WEEKDAY_EVENT3 = 6,
            CHCT_M5_WEEKDAY_EVENT3 = 6,
            CHCT_M6_WEEKDAY_EVENT3 = 6,
            CHCT_S1_CLUB_EX_VALUE2 = 6,
            CHCT_E9_DATE_FASHION_ID = 7,
            CHCT_G1_STAY_EVTCG = 7,
            CHCT_G2_FRIEND_PLAY = 7,
            CHCT_M1_FESTIVAL_EVENT = 7,
            CHCT_M2_FESTIVAL_EVENT = 7,
            CHCT_M3_FESTIVAL_EVENT = 7,
            CHCT_M4_FESTIVAL_EVENT = 7,
            CHCT_M5_FESTIVAL_EVENT = 7,
            CHCT_M6_FESTIVAL_EVENT = 7,
            CHCT_S1_CLUB_EX_REST2 = 7,
            CHCT_E9_DATE_FASHION_TYPE = 8,
            CHCT_G1_FRIEND_PLAY = 8,
            CHCT_M1_DOKIDOKIMAX = 8,
            CHCT_M2_DOKIDOKIMAX = 8,
            CHCT_M3_DOKIDOKIMAX = 8,
            CHCT_M4_DOKIDOKIMAX = 8,
            CHCT_M5_DOKIDOKIMAX = 8,
            CHCT_M6_DOKIDOKIMAX = 8,
            CHCT_E9_FIRST_EVENT_DATE = 9,
            CHCT_M1_DAY_COUNT = 9,
            CHCT_M3_ADV6_OP = 9,
            CHCT_M3_COURSE = 10, // 0x0000000A
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
            Ch01True = 0,
            Ch01Normal = 1,
            Ch01Reversal = 2,
            Ch01GroupA = 3,
            Ch01GroupB = 4,
            Ch02True = 5,
            Ch02Normal = 6,
            Ch02Reversal = 7,
            Ch02Group = 8,
            Ch03True = 9,
            Ch03Normal = 10, // 0x0000000A
            Ch03Reversal = 11, // 0x0000000B
            Ch03Group = 12, // 0x0000000C
            Ch04True = 13, // 0x0000000D
            Ch04Normal = 14, // 0x0000000E
            Ch04Reversal = 15, // 0x0000000F
            Ch04Group = 16, // 0x00000010
            Ch05True = 17, // 0x00000011
            Ch05Normal = 18, // 0x00000012
            Ch05Reversal = 19, // 0x00000013
            Ch05Group = 20, // 0x00000014
            Ch06True = 21, // 0x00000015
            Ch06Normal = 22, // 0x00000016
            Ch06Reversal = 23, // 0x00000017
            Ch06GroupA = 24, // 0x00000018
            Ch06GroupC = 25, // 0x00000019
            Ch07True = 26, // 0x0000001A
            Ch07Normal = 27, // 0x0000001B
            Ch07Reversal = 28, // 0x0000001C
            Ch07Group = 29, // 0x0000001D
            Ch08 = 30, // 0x0000001E
            Ch09 = 31, // 0x0000001F
            Ch10 = 32, // 0x00000020
            Ch11 = 33, // 0x00000021
            GroupA = 34, // 0x00000022
            GroupB = 35, // 0x00000023
            GroupC = 36, // 0x00000024
            GroupD = 37, // 0x00000025
            Ch21 = 38, // 0x00000026
            Ch22 = 39, // 0x00000027
            Bad = 40, // 0x00000028
        }

        public enum OneYearCommandType
        {
            Rest,
            Study,
            Sports,
            Art,
            Fashion,
            Charm,
            Friend1,
            Friend2,
            Club,
            Executives,
            Arbeit,
            Habacha,
        }

        public enum ShopId
        {
            None = -1, // 0xFFFFFFFF
            Jess = 0,
            Adventure = 1,
            Pastel = 2,
            Merle = 3,
            Simon = 4,
            Mimi = 5,
            Cleo = 6,
            Maria = 7,
            Laurie = 8,
            Freemarket = 9,
        }

        public enum DateContent
        {
            None = -1, // 0xFFFFFFFF
            Shopmall1 = 0,
            Shopmall2 = 1,
            Seaside1 = 2,
            Seaside2 = 3,
            Seaside3 = 4,
            Aquarium1 = 5,
            Aquarium2 = 6,
            Aquarium3 = 7,
            Eventhall1 = 8,
            Eventhall2 = 9,
            Eventhall3 = 10, // 0x0000000A
            Eventhall4 = 11, // 0x0000000B
            Eventhall5 = 12, // 0x0000000C
            Eventhall6 = 13, // 0x0000000D
            Planetarium = 14, // 0x0000000E
            Sea1 = 15, // 0x0000000F
            Sea2 = 16, // 0x00000010
            Sea3 = 17, // 0x00000011
            Fireworks = 18, // 0x00000012
            Park = 19, // 0x00000013
            Forest1 = 20, // 0x00000014
            Forest2 = 21, // 0x00000015
            Forest3 = 22, // 0x00000016
            Forest4 = 23, // 0x00000017
            Forest5 = 24, // 0x00000018
            Plant = 25, // 0x00000019
            Museum1 = 26, // 0x0000001A
            Museum2 = 27, // 0x0000001B
            Museum3 = 28, // 0x0000001C
            Museum4 = 29, // 0x0000001D
            Museum5 = 30, // 0x0000001E
            Pool = 31, // 0x0000001F
            Skatingrink = 32, // 0x00000020
            Freemarket = 33, // 0x00000021
            Shop = 34, // 0x00000022
            Livehouse = 35, // 0x00000023
            Bowling1 = 36, // 0x00000024
            Bowling2 = 37, // 0x00000025
            Gamecenter = 38, // 0x00000026
            Karaoke = 39, // 0x00000027
            Movie1 = 40, // 0x00000028
            Movie2 = 41, // 0x00000029
            Movie3 = 42, // 0x0000002A
            Movie4 = 43, // 0x0000002B
            Movie5 = 44, // 0x0000002C
            Movie6 = 45, // 0x0000002D
            Movie7 = 46, // 0x0000002E
            Movie8 = 47, // 0x0000002F
            Movie9 = 48, // 0x00000030
            Movie10 = 49, // 0x00000031
            Movie11 = 50, // 0x00000032
            Movie12 = 51, // 0x00000033
            Mountain = 52, // 0x00000034
            Zoo1 = 53, // 0x00000035
            Zoo2 = 54, // 0x00000036
            Zoo3 = 55, // 0x00000037
            Castle1 = 56, // 0x00000038
            Castle2 = 57, // 0x00000039
            Themepark1 = 58, // 0x0000003A
            Themepark2 = 59, // 0x0000003B
            Themepark3 = 60, // 0x0000003C
            Themepark4 = 61, // 0x0000003D
            Themepark5 = 62, // 0x0000003E
            Themepark6 = 63, // 0x0000003F
            Farm1 = 64, // 0x00000040
            Farm2 = 65, // 0x00000041
            Home = 66, // 0x00000042
            NearbyPark = 67, // 0x00000043
            Beach = 68, // 0x00000044
            Cafe = 69, // 0x00000045
            Illumination = 70, // 0x00000046
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
            Kazama = 1,
            Sassa = 2,
            Honda = 3,
            Nanatsumori = 4,
            Hiiragi = 5,
            Himuro = 6,
            Mikage = 7,
            Daichi = 8,
            Kuya = 9,
            Tomoe = 10, // 0x0000000A
            Onari = 11, // 0x0000000B
            Michiru = 21, // 0x00000015
            Hikaru = 22, // 0x00000016
            Ch31 = 31, // 0x0000001F
            Ch32 = 32, // 0x00000020
            Ch33 = 33, // 0x00000021
            Ch34 = 34, // 0x00000022
            Ch35 = 35, // 0x00000023
            Ch36 = 36, // 0x00000024
            Ch37 = 37, // 0x00000025
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

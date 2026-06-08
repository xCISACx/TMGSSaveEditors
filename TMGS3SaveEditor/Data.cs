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
            RefParameter,
            Club,
            Title,
            TriangleFight,
        }

        public enum ClubId
        {
            None,
            Baseball,
            Tennis,
            Volleyball,
            Gymnastics,
            Brassband,
            Art,
            Handicraft,
            Executives,
            Judo,
        }

        public enum ArbeitId
        {
            None = 0,
            Flower = 1,
            Gasstand = 2,
            Pool = 3,
            ConvenienceStore = 4,
            Sweets = 5,
            General = 6,
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
            Ch09,
            Ch10,
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
            "Parka",
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
            "Sunvisor",
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
            PLFG_BIRTHDAY_GIFT = 0,
            PLFG_CHRISTMAS_GIFT = 1,
            PLFG_CHOCO_DUTY = 2,
            PLFG_CHOCO_HIGH = 3,
            PLFG_CHOCO_MADE = 4,
            PLFG_BIRTHDAY_FROM_MAN = 5,
            PLFG_FESTIVAL_CLASS = 6,
            PLFG_BESTFRIEND = 7,
            PLFG_JUDO_INVITE = 8,
            PLFG_NON_TIME_PROGRESS = 9,
            PLFG_M4_APPEAR_EVENT = 10, // 0x0000000A
            PLFG_PLAY_TRUANT_CLUB = 11, // 0x0000000B
            PLFG_BIRTHDAY_FROM_WOMAN = 12, // 0x0000000C
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
            PLFG_BIRTHDAY_PRESENT = 73, // 0x00000049
            PLFG_M4_APPEAR_EVENT3 = 74, // 0x0000004A
            PLFG_DATE_TROUBLE = 75, // 0x0000004B
            PLFG_THREE_DATE_RUN = 76, // 0x0000004C
            PLFG_0A_3DATE_FIREWORK = 77, // 0x0000004D
            PLFG_TRI_FRIEND_DECLARE = 78, // 0x0000004E
            PLFG_ED_LINING_UP = 79, // 0x0000004F
            PLFG_TEST_TOP = 80, // 0x00000050
            PLFG_ART_PARA = 81, // 0x00000051
            PLFG_ART_YEAR_CHECK = 82, // 0x00000052
            PLFG_FS_SKILL_UP = 83, // 0x00000053
            PLFG_BS_FOLLOW = 84, // 0x00000054
            PLFG_DTRT_S = 85, // 0x00000055
            PLFG_SACURAI_ROUTE = 86, // 0x00000056
            TOUCH_DISPLAY_KIND = 87, // 0x00000057
            BLINK_SWITCH = 88, // 0x00000058
            CHR_MOVE_STOP = 89, // 0x00000059
            PlayValentineSchoolOut = 90, // 0x0000005A
        }

        public enum CharFlag
        {
            BusyFriend = 0,
            CHFG_B1_EXTRA = 0,
            CHFG_E8_NG = 0,
            CHFG_E9_NG = 0,
            CHFG_G1_BUSY_DAY = 0,
            CHFG_G2_BUSY_DAY = 0,
            CHFG_M1_DID_DATE = 0,
            CHFG_M2_DID_DATE = 0,
            CHFG_M3_DID_DATE = 0,
            CHFG_M4_DID_DATE = 0,
            CHFG_M5_DID_DATE = 0,
            CHFG_M6_DID_DATE = 0,
            CHFG_S1_NG = 0,
            CHFG_S2_NG = 0,
            CHFG_B1_NG = 1,
            CHFG_E8_EVENT_START = 1,
            CHFG_E9_EVENT_START = 1,
            CHFG_G1_DOUBLE_DATE = 1,
            CHFG_G2_DOUBLE_DATE = 1,
            CHFG_M1_DID_SCHOOL_OUT = 1,
            CHFG_M2_DID_SCHOOL_OUT = 1,
            CHFG_M3_DID_SCHOOL_OUT = 1,
            CHFG_M4_DID_SCHOOL_OUT = 1,
            CHFG_M5_DID_SCHOOL_OUT = 1,
            CHFG_M6_DID_SCHOOL_OUT = 1,
            CHFG_S1_APPEAR = 1,
            CHFG_S2_READ_MAIL = 1,
            CHFG_B1_EVENT_START = 2,
            CHFG_E8_ENDING = 2,
            CHFG_E9_ENDING = 2,
            CHFG_G1_RELIED = 2,
            CHFG_G2_RELIED = 2,
            CHFG_M1_ATTEMPT = 2,
            CHFG_M2_ATTEMPT = 2,
            CHFG_M3_ATTEMPT = 2,
            CHFG_M4_ATTEMPT = 2,
            CHFG_M5_ATTEMPT = 2,
            CHFG_M6_ATTEMPT = 2,
            CHFG_S1_EVENT1 = 2,
            CHFG_S2_GO_MEET = 2,
            CHFG_B1_EVT_LESSON = 3,
            CHFG_E8_TOUCH = 3,
            CHFG_E9_LOOP = 3,
            CHFG_G1_TROUBLE_NOTICE = 3,
            CHFG_M1_DATE_BROKEN1 = 3,
            CHFG_M2_DATE_BROKEN1 = 3,
            CHFG_M3_DATE_BROKEN1 = 3,
            CHFG_M4_DATE_BROKEN1 = 3,
            CHFG_M5_DATE_BROKEN1 = 3,
            CHFG_M6_DATE_BROKEN1 = 3,
            CHFG_S1_EVENT2 = 3,
            CHFG_S2_GO_OUT = 3,
            CHFG_B1_EVT_STRESS = 4,
            CHFG_E9_DATE = 4,
            CHFG_M1_DATE_BROKEN2 = 4,
            CHFG_M2_DATE_BROKEN2 = 4,
            CHFG_M3_DATE_BROKEN2 = 4,
            CHFG_M4_DATE_BROKEN2 = 4,
            CHFG_M5_DATE_BROKEN2 = 4,
            CHFG_M6_DATE_BROKEN2 = 4,
            CHFG_S1_EVENT3 = 4,
            CHFG_S2_NOT_GO_OUT = 4,
            CHFG_B1_EVT_TEST = 5,
            CHFG_E9_GO_OUT = 5,
            CHFG_M1_BIRTHDAY_GIFT_ACCE = 5,
            CHFG_M2_BIRTHDAY_GIFT_ACCE = 5,
            CHFG_M3_BIRTHDAY_GIFT_ACCE = 5,
            CHFG_M4_BIRTHDAY_GIFT_ACCE = 5,
            CHFG_M5_BIRTHDAY_GIFT_ACCE = 5,
            CHFG_M6_BIRTHDAY_GIFT_ACCE = 5,
            CHFG_S1_EVENT4 = 5,
            CHFG_S2_SEL_GO_OUT = 5,
            CHFG_B1_EVT_WIN = 6,
            CHFG_E9_NOT_GO_OUT = 6,
            CHFG_M1_ILL_VISIT = 6,
            CHFG_M2_ILL_VISIT = 6,
            CHFG_M3_ILL_VISIT = 6,
            CHFG_M4_ILL_VISIT = 6,
            CHFG_M5_ILL_VISIT = 6,
            CHFG_M6_ILL_VISIT = 6,
            CHFG_S1_EVENT5 = 6,
            CHFG_S2_EVENT_START = 6,
            SickVisit = 6,
            BombEvent1 = 7,
            CHFG_B1_TOP_OTAMA = 7,
            CHFG_E9_ROUTE = 7,
            CHFG_M1_BOMB_EVENT1 = 7,
            CHFG_M2_BOMB_EVENT1 = 7,
            CHFG_M3_BOMB_EVENT1 = 7,
            CHFG_M4_BOMB_EVENT1 = 7,
            CHFG_M5_BOMB_EVENT1 = 7,
            CHFG_M6_BOMB_EVENT1 = 7,
            CHFG_S1_EVENT6 = 7,
            CHFG_S2_PROMISE_MEET = 7,
            BombEvent2 = 8,
            CHFG_B1_TOP_2NIN3KYAKU = 8,
            CHFG_M1_BOMB_EVENT2 = 8,
            CHFG_M2_BOMB_EVENT2 = 8,
            CHFG_M3_BOMB_EVENT2 = 8,
            CHFG_M4_BOMB_EVENT2 = 8,
            CHFG_M5_BOMB_EVENT2 = 8,
            CHFG_M6_BOMB_EVENT2 = 8,
            CHFG_S1_JOIN_CLUB = 8,
            CHFG_S2_MAIL_OPEN1 = 8,
            BombEvent3 = 9,
            CHFG_B1_WIN_TAMAIRE = 9,
            CHFG_M1_BOMB_EVENT3 = 9,
            CHFG_M2_BOMB_EVENT3 = 9,
            CHFG_M3_BOMB_EVENT3 = 9,
            CHFG_M4_BOMB_EVENT3 = 9,
            CHFG_M5_BOMB_EVENT3 = 9,
            CHFG_M6_BOMB_EVENT3 = 9,
            CHFG_S1_HELP = 9,
            CHFG_S2_MAIL_OPEN2 = 9,
            CHFG_B1_FESTIVAL_EVT1 = 10, // 0x0000000A
            CHFG_M1_BEST_FRIENDEVENT = 10, // 0x0000000A
            CHFG_M2_BEST_FRIENDEVENT = 10, // 0x0000000A
            CHFG_M3_BEST_FRIENDEVENT = 10, // 0x0000000A
            CHFG_M4_BEST_FRIENDEVENT = 10, // 0x0000000A
            CHFG_M5_BEST_FRIENDEVENT = 10, // 0x0000000A
            CHFG_M6_BEST_FRIENDEVENT = 10, // 0x0000000A
            CHFG_S1_LOAD = 10, // 0x0000000A
            CHFG_S2_ENDING = 10, // 0x0000000A
            CHFG_B1_FESTIVAL_EVT2 = 11, // 0x0000000B
            CHFG_M1_TRI_CANCEL = 11, // 0x0000000B
            CHFG_M2_TRI_CANCEL = 11, // 0x0000000B
            CHFG_M3_TRI_CANCEL = 11, // 0x0000000B
            CHFG_M4_TRI_CANCEL = 11, // 0x0000000B
            CHFG_M5_TRI_CANCEL = 11, // 0x0000000B
            CHFG_M6_TRI_CANCEL = 11, // 0x0000000B
            CHFG_S1_TEARS = 11, // 0x0000000B
            CHFG_B1_EVT_QUEEN = 12, // 0x0000000C
            CHFG_M1_FS_HADUKI = 12, // 0x0000000C
            CHFG_M2_FS_HADUKI = 12, // 0x0000000C
            CHFG_M3_FS_HADUKI = 12, // 0x0000000C
            CHFG_M4_FS_HADUKI = 12, // 0x0000000C
            CHFG_M5_FS_HADUKI = 12, // 0x0000000C
            CHFG_M6_FS_HADUKI = 12, // 0x0000000C
            CHFG_S1_RSVDATE = 12, // 0x0000000C
            CHFG_B1_LATTER_LESSON = 13, // 0x0000000D
            CHFG_M1_DID_DEC_DATE = 13, // 0x0000000D
            CHFG_M2_DID_DEC_DATE = 13, // 0x0000000D
            CHFG_M3_DID_DEC_DATE = 13, // 0x0000000D
            CHFG_M4_DID_DEC_DATE = 13, // 0x0000000D
            CHFG_M5_DID_DEC_DATE = 13, // 0x0000000D
            CHFG_M6_DID_DEC_DATE = 13, // 0x0000000D
            CHFG_S1_DATE = 13, // 0x0000000D
            CHFG_B1_EVT_FESTIVAL = 14, // 0x0000000E
            CHFG_M1_DID_DEC_SCHOOL_OUT = 14, // 0x0000000E
            CHFG_M2_DID_DEC_SCHOOL_OUT = 14, // 0x0000000E
            CHFG_M3_DID_DEC_SCHOOL_OUT = 14, // 0x0000000E
            CHFG_M4_DID_DEC_SCHOOL_OUT = 14, // 0x0000000E
            CHFG_M5_DID_DEC_SCHOOL_OUT = 14, // 0x0000000E
            CHFG_M6_DID_DEC_SCHOOL_OUT = 14, // 0x0000000E
            CHFG_S1_MEET = 14, // 0x0000000E
            BusyApproach = 15, // 0x0000000F
            CHFG_M1_BUSY_DAY = 15, // 0x0000000F
            CHFG_M2_BUSY_DAY = 15, // 0x0000000F
            CHFG_M3_BUSY_DAY = 15, // 0x0000000F
            CHFG_M4_BUSY_DAY = 15, // 0x0000000F
            CHFG_M5_BUSY_DAY = 15, // 0x0000000F
            CHFG_M6_BUSY_DAY = 15, // 0x0000000F
            CHFG_S1_ENDING = 15, // 0x0000000F
            CHFG_M1_DURING_WDATE = 16, // 0x00000010
            CHFG_M2_DURING_WDATE = 16, // 0x00000010
            CHFG_M3_DURING_WDATE = 16, // 0x00000010
            CHFG_M4_DURING_WDATE = 16, // 0x00000010
            CHFG_M5_DURING_WDATE = 16, // 0x00000010
            CHFG_M6_DURING_WDATE = 16, // 0x00000010
            CHFG_S1_RUN_TRAINING = 16, // 0x00000010
            BombEvent4 = 17, // 0x00000011
            CHFG_M1_BOMB_EVENT4 = 17, // 0x00000011
            CHFG_M2_BOMB_EVENT4 = 17, // 0x00000011
            CHFG_M3_BOMB_EVENT4 = 17, // 0x00000011
            CHFG_M4_BOMB_EVENT4 = 17, // 0x00000011
            CHFG_M5_BOMB_EVENT4 = 17, // 0x00000011
            CHFG_M6_BOMB_EVENT4 = 17, // 0x00000011
            CHFG_S1_HELP2 = 17, // 0x00000011
            CHFG_M1_CHRISTMAS = 18, // 0x00000012
            CHFG_M2_CHRISTMAS = 18, // 0x00000012
            CHFG_M3_CHRISTMAS = 18, // 0x00000012
            CHFG_M4_CHRISTMAS = 18, // 0x00000012
            CHFG_M5_CHRISTMAS = 18, // 0x00000012
            CHFG_M6_CHRISTMAS = 18, // 0x00000012
            CHFG_M1_NAME_CALL_EVT = 19, // 0x00000013
            CHFG_M2_NAME_CALL_EVT = 19, // 0x00000013
            CHFG_M3_NAME_CALL_EVT = 19, // 0x00000013
            CHFG_M4_NAME_CALL_EVT = 19, // 0x00000013
            CHFG_M5_NAME_CALL_EVT = 19, // 0x00000013
            CHFG_M6_NAME_CALL_EVT = 19, // 0x00000013
            CHFG_M1_NAME_CHANGE = 20, // 0x00000014
            CHFG_M2_NAME_CHANGE = 20, // 0x00000014
            CHFG_M3_NAME_CHANGE = 20, // 0x00000014
            CHFG_M4_NAME_CHANGE = 20, // 0x00000014
            CHFG_M5_NAME_CHANGE = 20, // 0x00000014
            CHFG_M6_NAME_CHANGE = 20, // 0x00000014
            NameChange = 20, // 0x00000014
            CHFG_M1_HEAR_LOVE = 21, // 0x00000015
            CHFG_M2_HEAR_LOVE = 21, // 0x00000015
            CHFG_M3_HEAR_LOVE = 21, // 0x00000015
            CHFG_M4_HEAR_LOVE = 21, // 0x00000015
            CHFG_M5_HEAR_LOVE = 21, // 0x00000015
            CHFG_M6_HEAR_LOVE = 21, // 0x00000015
            CHFG_M1_DEPART = 22, // 0x00000016
            CHFG_M2_FIGHT_GRADUATION = 22, // 0x00000016
            CHFG_M3_ADV1_OP = 22, // 0x00000016
            CHFG_M4_ADV6_OP = 22, // 0x00000016
            CHFG_M5_ADV1_OP = 22, // 0x00000016
            CHFG_M6_DECISION = 22, // 0x00000016
            CHFG_M1_CRUTCH = 23, // 0x00000017
            CHFG_M2_EVT_ICU = 23, // 0x00000017
            CHFG_M3_ADV8_OP1 = 23, // 0x00000017
            CHFG_M4_HOBBY_EVT = 23, // 0x00000017
            CHFG_M5_CS_1NAGARE = 23, // 0x00000017
            CHFG_M1_DRAMA_FESTIVAL = 24, // 0x00000018
            CHFG_M2_HOSPITAL_ROUTE = 24, // 0x00000018
            CHFG_M3_ADV8_OP2 = 24, // 0x00000018
            CHFG_M5_NON_APPEAR = 24, // 0x00000018
            CHFG_M1_DEATH_FLAG = 25, // 0x00000019
            CHFG_M3_GET_PREFAB = 25, // 0x00000019
            CHFG_M1_EVT_ICU = 26, // 0x0000001A
            CHFG_M1_HOSPITAL_ROUTE = 27, // 0x0000001B
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
            Ch01Normal = 0,
            Ch01True = 1,
            Ch01BSFDLove = 2,
            Ch01BSFDFriend = 3,
            Ch02Normal = 4,
            Ch02True = 5,
            Ch02BSFDLove = 6,
            Ch02BSFDFriend = 7,
            Ch01Ch02TriFriend = 8,
            Ch01Ch02TriLove = 9,
            Ch03Normal = 10, // 0x0000000A
            Ch03True = 11, // 0x0000000B
            Ch03BSFDLove = 12, // 0x0000000C
            Ch03BSFDFriend = 13, // 0x0000000D
            Ch04Normal = 14, // 0x0000000E
            Ch04True = 15, // 0x0000000F
            Ch04BSFDLove = 16, // 0x00000010
            Ch04BSFDFriend = 17, // 0x00000011
            Ch03Ch04TriFriend = 18, // 0x00000012
            Ch03Ch04TriLove = 19, // 0x00000013
            Ch05Normal = 20, // 0x00000014
            Ch05True = 21, // 0x00000015
            Ch05BSFDLove = 22, // 0x00000016
            Ch05BSFDFriend = 23, // 0x00000017
            Ch06Normal = 24, // 0x00000018
            Ch06True = 25, // 0x00000019
            Ch06BSFDLove = 26, // 0x0000001A
            Ch06BSFDFriend = 27, // 0x0000001B
            Ch05Ch06TriFriend = 28, // 0x0000001C
            Ch05Ch06TriLove = 29, // 0x0000001D
            Ch07 = 30, // 0x0000001E
            Ch08 = 31, // 0x0000001F
            Ch11 = 32, // 0x00000020
            Ch40 = 33, // 0x00000021
            Ch09 = 34, // 0x00000022
            Ch10 = 35, // 0x00000023
            Bad = 36, // 0x00000024
            Ch09Ch10TriFriend = 37, // 0x00000025
            Ch41Angel = 38, // 0x00000026
            Ch41Devil = 39, // 0x00000027
        }

        public enum OneYearCommandType
        {
            Rest,
            Study,
            Art,
            Fashion,
            Sports,
            Charm,
            Club,
            Executives,
            Arbeit,
            Friend1,
            Friend2,
        }

        public enum ShopId
        {
            None = -1, // 0xFFFFFFFF
            Jess = 0,
            Pamela = 1,
            Sofia = 2,
            Nenne = 3,
            Simon = 4,
            Whip = 5,
            Cocotte = 6,
            Jeanne = 7,
            CandyCane = 8,
            Freemarket = 9,
        }

        public enum DateContent
        {
            None = -1, // 0xFFFFFFFF
            Shop = 0,
            Movie1 = 1,
            Movie2 = 2,
            Movie3 = 3,
            Movie4 = 4,
            Movie5 = 5,
            Movie6 = 6,
            Movie7 = 7,
            Movie8 = 8,
            Movie9 = 9,
            Movie10 = 10, // 0x0000000A
            Movie11 = 11, // 0x0000000B
            Movie12 = 12, // 0x0000000C
            Livehouse = 13, // 0x0000000D
            Bowling1 = 14, // 0x0000000E
            Bowling2 = 15, // 0x0000000F
            Gamecenter = 16, // 0x00000010
            Karaoke = 17, // 0x00000011
            Park = 18, // 0x00000012
            Freemarket = 19, // 0x00000013
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
            Mountain1 = 33, // 0x00000021
            Mountain2 = 34, // 0x00000022
            Themepark1 = 35, // 0x00000023
            Themepark2 = 36, // 0x00000024
            Themepark3 = 37, // 0x00000025
            Themepark4 = 38, // 0x00000026
            Themepark5 = 39, // 0x00000027
            Themepark6 = 40, // 0x00000028
            Zoo1 = 41, // 0x00000029
            Zoo2 = 42, // 0x0000002A
            Zoo3 = 43, // 0x0000002B
            Castle1 = 44, // 0x0000002C
            Castle2 = 45, // 0x0000002D
            Farm = 46, // 0x0000002E
            Planetarium = 47, // 0x0000002F
            Shopmall1 = 48, // 0x00000030
            Shopmall2 = 49, // 0x00000031
            Seaside1 = 50, // 0x00000032
            Seaside2 = 51, // 0x00000033
            Seaside3 = 52, // 0x00000034
            Fireworks = 53, // 0x00000035
            Sea1 = 54, // 0x00000036
            Sea2 = 55, // 0x00000037
            Sea3 = 56, // 0x00000038
            Aquarium1 = 57, // 0x00000039
            Aquarium2 = 58, // 0x0000003A
            Aquarium3 = 59, // 0x0000003B
            Eventhall1 = 60, // 0x0000003C
            Eventhall2 = 61, // 0x0000003D
            Eventhall3 = 62, // 0x0000003E
            Eventhall4 = 63, // 0x0000003F
            Eventhall5 = 64, // 0x00000040
            Eventhall6 = 65, // 0x00000041
            HisRoom = 66, // 0x00000042
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
            Ruka = 1,
            Kou = 2,
            Fujiyama = 3,
            Niina = 4,
            Konno = 5,
            Shitara = 6,
            Kasuga = 7,
            Aizawa = 8,
            Ugajin = 9,
            Hanatsubaki = 10, // 0x0000000A
            Osako = 11, // 0x0000000B
            Ch12 = 12, // 0x0000000C
            Ch18 = 18, // 0x00000012
            Ch33 = 33, // 0x00000021
            Ch34 = 34, // 0x00000022
            Ch35 = 35, // 0x00000023
            Ch36 = 36, // 0x00000024
            Ch37 = 37, // 0x00000025
            Ch38 = 38, // 0x00000026
            Ch39 = 39, // 0x00000027
            Taira = 40, // 0x00000028
            Hasumi = 41, // 0x00000029
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

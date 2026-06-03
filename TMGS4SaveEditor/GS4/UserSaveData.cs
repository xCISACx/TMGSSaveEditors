using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace GS4
{
    // Token: 0x0200040E RID: 1038
    
    [Serializable]
    public class UserSaveData
    {
        // Token: 0x06001912 RID: 6418 RVA: 0x00002053 File Offset: 0x00000253
       

      

        // Token: 0x040017B7 RID: 6071
        
        public bool enable;

        // Token: 0x040017B8 RID: 6072
        
        public DateTime saveDate;

        // Token: 0x040017B9 RID: 6073
        
        public byte languageCode;

        // Token: 0x040017BA RID: 6074
       
        public ProgressSaveData progress;

        // Token: 0x040017BB RID: 6075
        
        public PlayerSaveData player;

        // Token: 0x040017BC RID: 6076
        
        public ApproachCharSaveData[] approachChars;

        // Token: 0x040017BD RID: 6077
        
        public FriendCharSaveData[] friendChars;

        // Token: 0x040017BE RID: 6078
       
        public AdvCharSaveData[] advChars;

        // Token: 0x040017BF RID: 6079
        
        public SdCategoryId sdCategoryId;

        // Token: 0x040017C0 RID: 6080
        public string memoString;

        // Token: 0x040017C1 RID: 6081
        public SaveDataManager.ErrorCode errorCode;
       
    }
}

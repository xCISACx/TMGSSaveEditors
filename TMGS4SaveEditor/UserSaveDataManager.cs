using GS4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TMGS4SaveEditor;
using TMGSSaveEditor.Core;

namespace TMGSSaveEditor
{
    public partial class UserSaveDataManager : ISaveDataManager
    {
        string password = "wZ3jKy6WQ5qD4u7z";

        string salt = "uV4MpbvWd";
        
        RijndaelManaged rijndael;

        public string[] ApproachCharacterNames => new string[]
        {
            "Kazama", "Sassa", "Honda", "Nanatsumori", "Hiiragi", "Himuro", "Mikage", "Daichi"
        };

        public string[] FriendCharacterNames => new string[]
        {
            "Michiru", "Hikaru"
        };

        public string[] AdvCharacterNames => new string[]
        {
            "Kuya", "Tomoe", "Onari"
        };

        public string[] ParameterNames => new string[]
        {
            "Intelligence",
            "Art",
            "Exercise",
            "Social",
            "Fashion",
            "Charm",
            "Stress",
            "Cash"
        };

        private ClothesManager _clothesManager = new ClothesManager(typeof(UserSaveDataManager).Assembly.GetName().Name);
        public string[] ClothingNames => _clothesManager.GetClothingNames();

        public UserSaveDataManager()
        {
            rijndael = new RijndaelManaged();
            rijndael.KeySize = 0x80;
            rijndael.BlockSize = 0x80;

            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt));
            rfc2898DeriveBytes.IterationCount = 0x3e8;

            rijndael.Key = rfc2898DeriveBytes.GetBytes(getTransformedKeySizeForRijndael(rijndael.KeySize));
            rijndael.IV = rfc2898DeriveBytes.GetBytes(getTransformedKeySizeForRijndael(rijndael.BlockSize));
        }

        byte[] Decrypt(byte[] data)
        {
            var decryptor = rijndael.CreateDecryptor();
            byte[] result;
            using (MemoryStream msDecrypt = new MemoryStream(data))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var writeStream = new MemoryStream())
                    {
                        csDecrypt.CopyTo(writeStream);
                        result = writeStream.ToArray();
                    }
                }
            }
            return result;
        }

        byte[] Encrypt(byte[] data)
        {
            var encryptor = rijndael.CreateEncryptor();
            byte[] result;


            using (MemoryStream msEncrypt = new MemoryStream(data))
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Read))
                {
                    using (var writeStream = new MemoryStream())
                    {
                        csEncrypt.CopyTo(writeStream);
                        result = writeStream.ToArray();
                    }
                }
            }
            
            return result;
        }


        sealed class MyAsemblyBinder : SerializationBinder
        {
            public override Type BindToType(string assemblyName, string typeName)
            {
                string myAsm = Assembly.GetExecutingAssembly().FullName;

                Type foundType = Type.GetType(String.Format("{0}, {1}", typeName, myAsm), true);

                return foundType;
            }
            public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
            {
                // Change the assembly name to a new value
                assemblyName = @"Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

                // Use the default binding behavior for the type name
                typeName = null;
            }
        }

        byte[] decryptedSave; 

        public Object Load(string loadPath)
        {
            byte[] bytes = File.ReadAllBytes(loadPath);

            byte[] decrypted = Decrypt(bytes);
            decryptedSave = decrypted;

#if DEBUG
            File.WriteAllBytes(loadPath + "decl", decryptedSave);
#endif

            return loadFromDecryptedBytes(decrypted);
        }

        private static object loadFromDecryptedBytes(byte[] decrypted)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(decrypted))
            {
                using (BinaryReader br = new BinaryReader(ms))
                {

                    int version = br.ReadInt32();
                    if (version != 0x78)
                    {
                        throw new Exception("Unsupported file");
                    }
                    bf.Binder = new MyAsemblyBinder();
                    Object o = bf.Deserialize(ms);
                                       
                    return o;
                }

            }
        }

        public void Save(string savePath, Object data) { 
            BinaryFormatter bf = new BinaryFormatter();
            
            bf.Binder = new MyAsemblyBinder();

            byte[] saveData;
            using (MemoryStream ms = new MemoryStream())
            {
                int version = 0x78;
                var versionBuf = BitConverter.GetBytes(version);
                ms.Write(versionBuf, 0, versionBuf.Length);
                bf.Serialize(ms, data);
                                
                saveData = ms.ToArray();
                /*if (ms.Position < 0x10000)
                {
                    Array.Resize(ref saveData, 0x10000);
                }*/
            }

            if (decryptedSave != null && saveData.Length != decryptedSave.Length)
            {
                Array.Resize(ref saveData, decryptedSave.Length);
            }

#if DEBUG
            File.WriteAllBytes(savePath + "decs", saveData);
#endif

            byte[] encryptedData = Encrypt(saveData);
            File.WriteAllBytes(savePath, encryptedData);

            /*object o = loadFromDecryptedBytes(saveData);

            bool equal = AreObjectsEqual(o, data, new HashSet<object>());

            for (int i = 0; i< saveData.Length; i++)
            {
                byte original = decryptedSave[i];
                byte ours = saveData[i];
                if (original != ours)
                {
                    continue;   
                }

            }*/
            


        }

        public static bool AreObjectsEqual(object o1, object o2, HashSet<object> visited)
        {
            if (o1 == null && o2 == null)
            {
                return true;
            }
            if (o1 == null || o2 == null)
            {
                return false;
            }
            if (o1.GetType() != o2.GetType())
            {
                return false;
            }
            if (visited.Contains(o1) || visited.Contains(o2))
            {
                return true;
            }
            visited.Add(o1);
            visited.Add(o2);

            Type type = o1.GetType();
            if (type.IsPrimitive || type == typeof(string))
            {
                return o1.Equals(o2);
            }

            if (type == typeof(DateTime))
            {
                return ((DateTime)o1).ToBinary() == ((DateTime)o2).ToBinary();
            }

            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                object value1 = property.GetValue(o1, null);
                object value2 = property.GetValue(o2, null);
                if (!AreObjectsEqual(value1, value2, visited))
                {
                    return false;
                }
            }

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                object value1 = field.GetValue(o1);
                object value2 = field.GetValue(o2);
                if (!AreObjectsEqual(value1, value2, visited))
                {
                    return false;
                }
            }

            return true;
        }



        private int getTransformedKeySizeForRijndael(int keysize)
        {
            int x8_34;
            var x8_33 = keysize + 7;
            if (keysize < 0)
            {
                x8_34 = x8_33;
            }
            else
            {
                x8_34 = keysize;
            }
            return x8_34 >> 3;
        }
    }
}

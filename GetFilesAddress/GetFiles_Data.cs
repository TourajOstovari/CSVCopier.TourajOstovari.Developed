using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GetFilesAddress
{
    [Serializable]
    public class Temp_GetFile_Data
    {
        #region SeriousInfo_temp
        public  System.Collections.ArrayList GetAddress = new System.Collections.ArrayList(); //Source File(s) that we want copy them each second ...
        public  List<string> GridData = new List<string>(); // Source File's folder info ...
        public  string dest_AddressFolder { get; set; } = null; // destination folder that files would copy there each second ...
        #endregion
    }


    public class GetFiles_Data:Object
    {
        #region SeriousInfo
        public static System.Collections.ArrayList GetAddress = new System.Collections.ArrayList(); //Source File(s) that we want copy them each second ...
        public static List<string> GridData = new List<string>(); // Source File's folder info ...
        public static string dest_AddressFolder { get; set; } = null; // destination folder that files would copy there each second ...
        #endregion

        /// <summary>
        /// saving data into a file according binary format and it's encrypting it too ... "Serialization USED"
        /// </summary>
        /// <param name="Information">Using Generic Collection type of String variable ...</param>
        /// <returns>Returns True if there was not any problem ...</returns>
        public static void SaveDataGridViewData(List<string> Information)
        {
            GridData.Clear();
            GridData = (Information);
            if(dest_AddressFolder != "" && dest_AddressFolder != " " && System.IO.Directory.Exists(dest_AddressFolder) && !string.IsNullOrWhiteSpace(dest_AddressFolder) && !string.IsNullOrEmpty(dest_AddressFolder))
            {
                if(GridData.Count > 0 || GetAddress.Count > 0)
                {
                    if (SaveData_ImportData.SaveData() == true) { System.Windows.Forms.MessageBox.Show("Settings saved succesfullu ...  \nPath:\t"+Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + "CSVSettings.db","Info",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information); }
                }
            }
        }


        public static Temp_GetFile_Data SerializationProc()
        {
            Temp_GetFile_Data tempData = new Temp_GetFile_Data();
            tempData.dest_AddressFolder = GetFiles_Data.dest_AddressFolder;
            tempData.GetAddress = (ArrayList)GetFiles_Data.GetAddress.Clone();
            tempData.GridData = GetFiles_Data.GridData;
            return tempData;
        }

        public static bool DeSerializationProc()
        {
            Temp_GetFile_Data list =  SaveData_ImportData.ImportData();
            //if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CSVSettings.dbDECTEST")) System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CSVSettings.dbDECTEST");
            GetFiles_Data.dest_AddressFolder = list.dest_AddressFolder;
            GetFiles_Data.GetAddress = list.GetAddress;
            GetFiles_Data.GridData = list.GridData;
            return true;
        }

    }
    /// <summary>
    /// Just this class is access ability inside of this project ...
    /// </summary>
    #region SavingDataProcess
    internal class SaveData_ImportData
    {
        public static string ads = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CSVSettings.db";
        public static bool SaveData()
        {
            try
            {

                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream binaryWriter = new System.IO.FileStream(ads,System.IO.FileMode.OpenOrCreate);
                formatter.Serialize(binaryWriter, GetFiles_Data.SerializationProc());
                binaryWriter.Dispose();

                #region Encoding_Operations
                byte[] readData = System.IO.File.ReadAllBytes(ads);
                string res = Convert.ToBase64String(readData, Base64FormattingOptions.None);
                #region checks_if_exists_removes_tries_that
#if true
                if (System.IO.File.Exists(ads) == true) System.IO.File.Delete(ads);
#endif
                #endregion
                System.IO.File.WriteAllText(ads, res);
                #endregion

                return true;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message,"ERROR !!!");
                return false;
            }
        }
        public static Temp_GetFile_Data ImportData()
        {
            try
            {
                #region Decrypting_Operation
                string readData = System.IO.File.ReadAllText(ads);
                byte[] res = Convert.FromBase64String(readData);
                //if (System.IO.File.Exists(ads + "DECTEST") == true) System.IO.File.Delete(ads + "DECTEST");
                System.IO.File.WriteAllBytes(ads + "DECTEST", res);
                #endregion

                #region gets_readyFor_Import_Data
                GetFiles_Data.dest_AddressFolder = null;
                GetFiles_Data.GetAddress.Clear();
                GetFiles_Data.GridData.Clear();
                #endregion

                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream streamReader = new System.IO.FileStream(ads + "DECTEST",System.IO.FileMode.OpenOrCreate);
                Temp_GetFile_Data tmps = (Temp_GetFile_Data)formatter.Deserialize(streamReader);
                streamReader.Close();
                return tmps;
            }
            
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message, "ERROR !!!");
                Temp_GetFile_Data arr = new Temp_GetFile_Data();
                return arr;
            }
        }
    }
    #endregion
}

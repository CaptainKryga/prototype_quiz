using System;
using System.IO;
using UnityEngine;

namespace Model
{
    public class UploadFile: MonoBehaviour
    {
        public string Upload(string file)
        {
            string line, res = "";
            try
            {
                StreamReader sr = new StreamReader(Application.streamingAssetsPath + '/' + file);
                line = sr.ReadLine();
                while (line != null)
                {
                    res += line;
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch(Exception e)
            {
                Debug.Log("Exception: " + e.Message);
            }
            finally
            {
                Debug.Log("Executing finally block.");
            }
            
            return res;
        }
    }
}
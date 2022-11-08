using System;
using UnityEngine;

namespace Model
{
    public class ParserFile: MonoBehaviour
    {
        [SerializeField] private UploadFile _uploadFile;

        public string[] GetData(string path)
        {
            string res = Filter(_uploadFile.Upload(path));

            return res.Split(' ');
        }

        private string Filter(string file)
        {
            char[] filter = new char[76];
            for (int x = 0, ascii = 0; x < filter.Length; x++, ascii++)
            {
                // '\n' and ' '
                if (ascii == 10 || ascii == 32)
                    continue;
                //ABC
                if (ascii == 65)
                    ascii = 91;
                //abc
                if (ascii == 97)
                    ascii = 123;

                filter[x] = (char) ascii;
            }
            
            foreach (char c in filter) {
                file = file.Replace(c.ToString(), String.Empty);
            }
            file = file.Replace('\n', ' ');
 
            return file;
        }
    }
}
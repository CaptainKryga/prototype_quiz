using UnityEngine;

namespace Model
{
    public class ParserFile
    {
        [SerializeField] private UploadFile _uploadFile;

        public string[] GetData()
        {
            _uploadFile.Upload();

            return new string[1];
        }
    }
}
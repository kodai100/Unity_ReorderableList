using UnityEngine;

namespace ProjectBlue.ReorderableLists
{
    public class SampleData
    {
        public string userName = "";

        public SampleData(string userName)
        {
            this.userName = userName;
        }

        public void UpdateData(SampleData data)
        {
            this.userName = data.userName;
        }
        
    }
}
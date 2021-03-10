using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ProjectBlue.ReorderableLists
{

    public class SampleList : ReorderableList<SampleListComponent, SampleData>
    {

        private List<SampleData> sampleDataList = new List<SampleData>()
        {
            new SampleData("Alice"),
            new SampleData("Bob"),
            new SampleData("Chris"),
            new SampleData("David"),
            new SampleData("Elliot")
        };

        protected override void Start()
        {
            base.Start();

            RecreateAllItem(sampleDataList);
        }

        protected override void OnSaveButtonClicked(IEnumerable<SampleData> items)
        {
            Debug.Log("== Saved.");
            sampleDataList = items.ToList();
            foreach (var sampleData in sampleDataList)
            {
                Debug.Log(sampleData.userName);   
            }
        }

        protected override void OnUpdateList(IEnumerable<SampleData> items)
        {
            Debug.Log("== Updated.");
            foreach (var sampleData in items)
            {
                Debug.Log(sampleData.userName);   
            }
        }
        
    }
    
}
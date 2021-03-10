using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectBlue.ReorderableLists
{
    
    public class SampleListComponent : ReorderableListComponent<SampleData>
    {
        
        [SerializeField] private InputField nameInputField;
        
        public override SampleData Data => instance;
        
        private SampleData instance = new SampleData("");
        
        
        private void Start()
        {
            nameInputField.OnValueChangedAsObservable().Subscribe(value =>
            {
                instance.userName = value;
            }).AddTo(this);
        }

        public override void UpdateView(SampleData data)
        {
            nameInputField.text = data.userName;
            
            instance.UpdateData(data);
        }

    }

}
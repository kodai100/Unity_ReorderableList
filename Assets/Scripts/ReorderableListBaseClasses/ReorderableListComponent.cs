using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace ProjectBlue.ReorderableLists
{
    public abstract class ReorderableListComponent<T> : MonoBehaviour
    {

        [SerializeField] protected Text indexText;
        [SerializeField] protected Button upButton;
        [SerializeField] protected Button deleteButton;
        [SerializeField] protected Button downButton;

        private int index = 0;

        /// <summary>
        /// Default data instance
        /// </summary>
        public abstract T Data { get; }
        
        public int Index
        {
            get => index;
            set
            {
                index = value;
                OnChangeIndex();
            }
        }

        public void Initialize(Action onDeleteAction, Action onUpAction, Action onDownAction)
        {
            deleteButton.OnClickAsObservable().Subscribe(_ =>
            {
                onDeleteAction?.Invoke();
            }).AddTo(this);

            upButton.OnClickAsObservable().Subscribe(_ =>
            {
                onUpAction?.Invoke();
            }).AddTo(this);

            downButton.OnClickAsObservable().Subscribe(_ =>
            {
                onDownAction?.Invoke();
            }).AddTo(this);
        }

        private void OnChangeIndex()
        {
            indexText.text = $"{Index+1:D2}";
        }
        
        public abstract void UpdateView(T data);

    }

}
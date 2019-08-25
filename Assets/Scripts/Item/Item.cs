using System;
using UnityEngine;
using UniRx;

namespace Assets.Scripts.Item
{
    public abstract class Item : MonoBehaviour
    {
        private readonly Subject<Collider> OnGotThisItem = new Subject<Collider>();
        protected IObservable<Collider> OnGot
        {
            get
            {
                return OnGotThisItem;
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<IItemGetter>() != null)
            {
                OnGotThisItem.OnNext(other);
                OnGotThisItem.OnCompleted();
                Destroy(gameObject);
            }
        }
    }
    public interface IItemGetter
    {

    }
}
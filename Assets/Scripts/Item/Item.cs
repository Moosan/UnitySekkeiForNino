using System;
using UnityEngine;
using UnityEngine.Events;
using Assets.Scripts.Score;
namespace Assets.Scripts.ItemConponent
{
    public class Item : MonoBehaviour,IScoreProvider
    {
        public IObservable<int> OnScore => throw new NotImplementedException();
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}
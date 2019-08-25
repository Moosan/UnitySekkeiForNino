using UnityEngine;
using Assets.Scripts.Item;
using System;
using UniRx;
namespace Assets.Scripts.Score
{
    public class ScoreProviderByCollider : MonoBehaviour, IScoreProvider, IScoreCollider
    {
        private readonly Subject<ScoreType> OnAddScoreSubject = new Subject<ScoreType>();
        public void AddScore(ScoreType type)
        {
            OnAddScoreSubject.OnNext(type);
        }
        public IObservable<ScoreType> OnAddScoreAsObservable()
        {
            return OnAddScoreSubject;
        }
    }
}
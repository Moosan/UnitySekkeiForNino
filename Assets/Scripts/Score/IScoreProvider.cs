using System;
using Assets.Scripts.Item;
namespace Assets.Scripts.Score
{
    public interface IScoreProvider
    {
        IObservable<ScoreType> OnAddScoreAsObservable();
    }
}
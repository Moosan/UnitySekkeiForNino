using System;
namespace Assets.Scripts.Score
{
    public interface IScoreProvider
    {
        IObservable<int> OnScore { get; }
    }
}
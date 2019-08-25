using UnityEngine;
using UniRx;

namespace Assets.Scripts.Score
{
    public class ScoreHolder : MonoBehaviour
    {
        private readonly ReactiveProperty<int> Score = new ReactiveProperty<int>();
        public IReadOnlyReactiveProperty<int> GetScore => Score;
        private IScoreProvider ScoreProvider;
        private void Awake()
        {
            if ((ScoreProvider = GetComponent<IScoreProvider>()) != null)
            {
                ScoreProvider.OnAddScoreAsObservable().Subscribe(type =>
                {
                    Score.Value += (int)type;
                });
            }
        }
    }
    public enum ScoreType
    {
        normal = 30, rare = 50, super = 100
    }
}
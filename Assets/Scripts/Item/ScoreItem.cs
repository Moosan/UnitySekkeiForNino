using UnityEngine;
using Assets.Scripts.Score;
using UniRx;
namespace Assets.Scripts.Item
{
    public class ScoreItem : Item
    {
        [SerializeField]
        private ScoreType ScoreType = ScoreType.normal;
        private void Awake()
        {
            OnGot?.Subscribe(other => {
                IScoreCollider scoreCollider;
                if ((scoreCollider = other.GetComponent<IScoreCollider>()) != null)
                {
                    scoreCollider.AddScore(ScoreType);
                }
            });
        }
    }
}
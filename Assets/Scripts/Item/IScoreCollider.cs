using UnityEngine;
using Assets.Scripts.Score;
namespace Assets.Scripts.Item
{
    public interface IScoreCollider
    {
        void AddScore(ScoreType type);
    }
}
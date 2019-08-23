using UnityEngine;
namespace Assets.Scripts.PlayerComponent.PlayerMove
{
    //インターフェースは、利用する側が定義してあげる
    //こうすることで、Input側にどんな修正があっても、利用する側は変更がいらない
    public interface IPlayerMoveInput
    {
        Vector2 GetDirection();
    }
}
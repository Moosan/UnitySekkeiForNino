using UnityEngine;
using Assets.Scripts.PlayerComponent.PlayerMove;
namespace Assets.Scripts.PlayerComponent.PlayerInput
{
    public class PlayerInputByKeyboard : MonoBehaviour, IPlayerMoveInput
    {
        private Vector2 InputValue;
        public Vector2 GetDirection()
        {
            return InputValue;
        }
        void Update()
        {
            InputValue = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}
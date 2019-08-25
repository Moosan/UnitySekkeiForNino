using UnityEngine;

namespace Assets.Scripts.Player.PlayerMove
{
    [RequireComponent(typeof(Rigidbody), typeof(IPlayerMoveInput))]
    public class PlayerMover : MonoBehaviour
    {
        public float speed = 10;
        private IPlayerMoveInput PlayerInput;
        private Rigidbody Rigidbody;
        private void Awake()
        {
            Rigidbody = GetComponent<Rigidbody>();
            PlayerInput = GetComponent<IPlayerMoveInput>();
        }
        void FixedUpdate()
        {
            Move(PlayerInput?.GetDirection() ?? Vector2.zero);
        }
        void Move(Vector2 direction)
        {
            direction.Normalize();
            direction *= speed;
            Rigidbody?.AddForce(direction.x, 0, direction.y);
        }
    }
}
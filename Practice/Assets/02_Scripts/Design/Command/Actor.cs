using UnityEngine;

namespace Design.Command
{
    public class Actor : MonoBehaviour
    {
        public float moveSpeed = 1f;

        public void Move(Vector3 moveDirection)
        {
            transform.position += moveDirection * moveSpeed;
        }
    }
}
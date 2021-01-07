using UnityEngine;

namespace Project.Components
{
    internal sealed class MovementComponent : ComponentBase
    {
        [HideInInspector] public Transform Transform;
        public float MinSpeed = 5f;
        public float MaxSpeed = 10f;

        [HideInInspector] public float Speed;

        private void Awake()
        {
            Transform = GetComponent<Transform>();

            Speed = (int)Random.Range(MinSpeed, MaxSpeed);
        }
    }
}

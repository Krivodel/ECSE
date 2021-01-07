using UnityEngine;

namespace Project
{
    public class MovementObjectsSpawner : MonoBehaviour
    {
        public GameObject Prefab;
        public int Count = 5000;
        public Vector3 MinPosition = new Vector3(-30, -30f, -30f);
        public Vector3 MaxPosition = new Vector3(30f, 30f, 30f);

        private void Start()
        {
            Generate();
        }

        private void Generate()
        {
            for (int i = 0; i < Count; i++)
                Entities.Instance.CreateEntity(Prefab, GetRandomPosition());
        }

        private Vector3 GetRandomPosition()
        {
            return new Vector3()
            {
                x = Random.Range(MinPosition.x, MaxPosition.x),
                y = Random.Range(MinPosition.y, MaxPosition.y),
                z = Random.Range(MinPosition.z, MaxPosition.z)
            };
        }
    }
}

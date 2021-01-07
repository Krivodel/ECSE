using Project.Components;

namespace Project.Systems
{
    internal sealed class MovementSystem : SystemBase, IUpdatable
    {
        private MovementComponent Current;

        protected override void OnCreate()
        {
            Components = Entities.Instance.With<MovementComponent>();
        }

        public void OnUpdate(float deltaTime)
        {
            for (int i = 0; i < Components.Count; i++)
            {
                Current = (MovementComponent)Components[i];

                Current.Transform.position += Current.Transform.forward * Current.Speed * deltaTime;
            }
        }
    }
}

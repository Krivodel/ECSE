namespace Project.Systems
{
    public interface ILateUpdatable
    {
        void OnLateUpdate(float deltaTime);
    }
}

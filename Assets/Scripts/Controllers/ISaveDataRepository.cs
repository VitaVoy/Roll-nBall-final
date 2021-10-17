namespace RollAndBall
{
    public interface ISaveDataRepository
    {
        void Save(Player player);
        void Load(Player player);
    }
}

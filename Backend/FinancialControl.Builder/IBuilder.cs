namespace FinancialControl.FinancialControl.Builder
{
    public interface IBuilder
    {
        void Create<Things>(Things thing);
        void Read();
        void Read(string key);
        void Read<Things>(Things sql);
        void ReadById(int id);
        void Read(int key);
        void Update<Thing>(Thing thing);
        void Delete<Things>(Things sql);
    }
}

namespace FinancialControl.FinancialControl.ConcreteBuilder
{
    public class ConcreteCategoryBuilder : IBuilder
    {
        public void Create<Things>(Things thing)
        {
            throw new NotImplementedException();
        }

        public void Delete<Things>(Things sql)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Read(string key)
        {
            throw new NotImplementedException();
        }

        public void Read<Things>(Things sql)
        {
            throw new NotImplementedException();
        }

        public void Read(int key)
        {
            throw new NotImplementedException();
        }

        public void ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update<Thing>(Thing thing)
        {
            throw new NotImplementedException();
        }
    }
}
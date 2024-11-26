namespace FinancialControl.FinancialControl.DirectorClass
{
    public class Director
    {
        private IBuilder? _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void Create<Things>(Things thing)
        {
            _builder?.Create(thing);
        }

        public void Delete<Thing>(Thing thing)
        {
            _builder?.Delete(thing);
        }

        public void Read() => _builder?.Read();

        public void Read(string key) => _builder?.Read(key);

        public void Read(int key) => _builder?.Read(key);
        public void ReadById(int id) => _builder?.ReadById(id);

        public void Update<Thing>(Thing thing) => _builder?.Update(thing);
    }
}
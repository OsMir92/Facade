namespace Facade
{
    class Customer
    {
        private readonly string _name;
        // Constructor
        public Customer(string name)
        {
            this._name = name;
        }
        // Agarra el nombre
        public string Name
        {
            get { return _name; }
        }
    }
}

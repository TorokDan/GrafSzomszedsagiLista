namespace GrafSzomszedsagiLista
{
    class Person
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Person(string name) => _name = name;

        public override string ToString() => _name;
    }
}
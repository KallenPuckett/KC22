namespace Knowledgecheck2
{
    internal class Dog: Animal
    {
        public bool IsPug { get; set; }

        public Dog(bool isPug, string name) : base(name)
        {
            IsPug = isPug;
        }

        public override string ToString()
        {
            return base.ToString() + $": is {(IsPug ? "" : "not")} a Pug";
        }
    }
}

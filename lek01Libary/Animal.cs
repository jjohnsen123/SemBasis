namespace lek01Libary
{
    public interface IAnimal
    {
        bool IsDog();
    }

    public class Animal : IAnimal 
    {
        public string species;
        public string name;

        public Animal(string species, string name)
        {
            this.species = species;
            this.name = name;
        }

        public bool IsDog()
        {
            if (species.ToLower().Equals("hund"))
            {
                return true;
            } else
            {
                return false;
            }
        }

        override
            public String ToString()
        {
            return "Animal is a " + species.ToLower() + " named " + name;
        }
    }
}

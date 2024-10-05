namespace lek10bilerMVC.Model
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }

        public List<Bil> Biler { get; set; }
    }
}

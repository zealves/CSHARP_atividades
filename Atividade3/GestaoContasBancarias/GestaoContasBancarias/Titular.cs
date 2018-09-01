namespace GestaoContasBancarias
{
    public class Titular
    {
        public long TitularId { get; set; }
        public string Nome { get; set; }

        public Titular(long id, string n)
        {
            TitularId = id;
            Nome = n;
        }
        public override string ToString()
        {
            return "TitularId: " + TitularId + "Nome:" + Nome;
        }
    }
}
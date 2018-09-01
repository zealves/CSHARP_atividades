namespace ConsoleAppProj2
{
    public class Departamento
    {
        public int DepartId { get; set; }
        public string Designacao { get; set; }

        public Departamento(int i,string d)
        {
            DepartId = i;
            Designacao = d;
        }

        public override string ToString()
        {
            return "DepartId: " + DepartId + "  Designação: " + Designacao;
        }

       
    }
}
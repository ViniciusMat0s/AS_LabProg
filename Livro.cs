//Herança de classe
public class Livro : ItemBiblioteca
{
    //Adicionando atributo Autor
    public string Autor { get; }

    //Construtor
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor; //Adicionando autor
    }

    //Construtor
       public Livro(int id, string titulo, string autor, string descricaoInterna) : base(id, titulo)
    {
        DescricaoInterna = descricaoInterna;
    }

    //Implementando método ExibirDescricaoInterna
    public override void ExibirDescricaoInterna()
    {
        Console.WriteLine($"(Descrição do livro)");
    }
}

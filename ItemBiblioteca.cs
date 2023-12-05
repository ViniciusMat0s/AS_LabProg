//Criando classe abstrata ItemBiblioteca
public abstract class ItemBiblioteca
{
    public int Id { get; }
    public string Titulo { get; }
    protected string DescricaoInterna { get; set; } //Protegendo atributo DescricaoInterna

    //Construtor
    public ItemBiblioteca(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        DescricaoInterna = "(Descrição do livro)";
    }

    //Classe para chamar DescricaoInterna
    public abstract void ExibirDescricaoInterna();
}

Biblioteca Biblioteca = new Biblioteca();

//Instanciando os livros
Livro l1 = new Livro(1, "Livro 1", "Autor 1");
Livro l2 = new Livro(2, "Livro 2", "Autor 2");

//Adicionando livros
Biblioteca.AdicionarItem(l1);
Biblioteca.AdicionarItem(l2);

Console.WriteLine("Buscar livro por:\n[1] Título\n[2] Id");
int escolha = Convert.ToInt32(Console.ReadLine());

if (escolha == 1)
{
    //Buscando por título
    Console.Write("\nDigite o titulo do livro: ");
    string buscarTitulo = Console.ReadLine();
    ItemBiblioteca livroEncontradoTit = Biblioteca.BuscarTitulo(buscarTitulo);

    //Condicional para verificar se o livro é existente
    if (livroEncontradoTit != null)
    {
        Console.WriteLine($"\nLivro [{buscarTitulo}] encontrado.");
        livroEncontradoTit.ExibirDescricaoInterna();
    }
    else
    {
        Console.WriteLine($"\nLivro [{buscarTitulo}] não encontrado.");
    }   
}
else if (escolha == 2)
{
    //Buscar por ID
    Console.WriteLine("\nDigite o ID do livro: ");
    int buscarId = Convert.ToInt32(Console.ReadLine());
    ItemBiblioteca livroEncontradoId = Biblioteca.BuscarId(buscarId);

    //Condicional para verificar se o livro é existente
    if (livroEncontradoId != null) 
    {
        Console.WriteLine($"\nLivro [{buscarId}] encontrado.");
        livroEncontradoId.ExibirDescricaoInterna(); 
    }
    else
    {
        Console.WriteLine($"\nLivro [{buscarId}] não encontrado.");
    }
}
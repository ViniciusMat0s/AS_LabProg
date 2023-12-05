//Criando classe biblioteca
public class Biblioteca
{
    //Criando coleção
    List<ItemBiblioteca> Colecao;

    public Biblioteca()
    {
        Colecao = new List<ItemBiblioteca>();
    }

    //Método para adicionar item
    public void AdicionarItem(ItemBiblioteca item)
    {
        Colecao.Add(item);
    }

    //Método para remover item
    public void RemoverItem(ItemBiblioteca item)
    {
        Colecao.Remove(item);
    }

    //Método para buscar por título
    public ItemBiblioteca BuscarTitulo(string titulo)
    {
        return Colecao.Find(item => item.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    //Método para buscar por ID
    public ItemBiblioteca BuscarId(int id)
    {
        return Colecao.Find(item => item.Id == id);
    }
}


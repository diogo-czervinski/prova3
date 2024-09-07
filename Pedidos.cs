using prova3;


public class Pedido
{
    
    private List<Produto> produtos;
    private List<Cliente> clientes;

    public Pedido()
    {
        produtos = new List<Produto>();
        clientes = new List<Cliente>();
    }

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }


    public void AdicionarCliente(Cliente cliente)
    {
        clientes.Add(cliente);
    }

  
    public object Buscar(string nome)
    {
        
        foreach (Produto produto in produtos)
        {
            if (produto.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return produto;
            }
        }

       
        foreach (Cliente cliente in clientes)
        {
            if (cliente.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                return cliente;
            }
        }

        return -1; 
}
}
namespace prova3;
public class Produto
{
  
	private string nome;
	private decimal preco;

	
	public string Nome
	{
		get { return nome; }
		set { nome = value; }
	}

	public decimal Preco
	{
		get { return preco; }
		set { preco = value; }
	}

	public Produto(string nome, decimal preco)
	{
		this.nome = nome;
		this.preco = preco;
	}
}

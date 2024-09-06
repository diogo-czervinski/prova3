public class Pilha<T> {
	private List<T> elementos = new List<T> ();
	
	public void push (T item)
	{
		elementos.Add (item);
	}
	
	public T pop ()
	{
		if (isEmpty())
		{
			throw new InvalidOperationException ("Esta vazia");
		}
		var item = elementos[elementos.Count - 1];
		elementos.RemoveAt (elementos.Count-1);
		return elementos[elementos.Count -1];
	}
	public T peek()
	{
		if (isEmpty())
		{
			throw new InvalidOperationException ("Esta vazia");
		}
		return elementos[0];
	}
	
	public bool isEmpty()
	{
		return elementos.Count == 0;
	}
}
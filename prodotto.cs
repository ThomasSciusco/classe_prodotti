using System;


public class prodotto
{
	private string nome;
	private double prezzo;

	public prodotto()
	{
		nome = "prodotto sconosciusto";
		prezzo= 0.0;
	
	}

	public prodotto(string nome, double prezzo)
	{
		this.nome = nome;
		this.prezzo = prezzo;

	}

	public string getNome() 
	{ 
		return nome; 
	}

	public double getPrezzo() 
	{
		return prezzo;	
	}




}

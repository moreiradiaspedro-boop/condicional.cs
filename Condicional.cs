using System;
					
public class Program
{
	public static void Main()
	{
	 //DECLARAÇÃO DE VARIAVEIS
		string nome;
		string sobrenome;
		int idade;
		int ano;
		
		//COLETA DAS VARIAVEIS
		Console.WriteLine("insira o nome");
		nome = Console.ReadLine();
		Console.WriteLine("insira sobrenome");
		sobrenome = Console.ReadLine();
		Console.WriteLine("insira a idade");
		idade = Convert.ToInt16(Console.ReadLine());
		
		//OPRAÇÕES
		ano = 2026 - idade;
			
	    //EXIBIÇÃO E TRATAMENTO DE DADOS
		Console.WriteLine("ola " + nome + sobrenome);
		Console.WriteLine("sua idade é: " + idade);
		if (idade >= 18){
			Console.WriteLine("você é maior de idade");
		}
			else {
				Console.WriteLine("você é menor de idade");}
		
		
						  
						  
						  
	    		
		
		
	}
}
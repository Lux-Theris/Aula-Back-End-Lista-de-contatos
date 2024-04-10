using System.Net.NetworkInformation;

namespace VSD;

public class Contato
{
    public static void MenuContatos(List<string> contatos)
    {
        Console.WriteLine("------ Menu de Contatos ------");
        Console.WriteLine("Digite 1 para adicionar um novo contato \n Digite 2 para exibir os contatos cadastrados \n Digite 3 para exibir os contatos cadastrados na ordem inversa");

        switch (Console.ReadLine())
        {
            case "1": AdicionarContatos(contatos); break;
            case "2": ListarContatos(contatos); break;
            case "3": ListarContatosDecrescente(contatos);break;
            case "4": ListarContatosOrdemAlfabetica(contatos); break;
            default: Console.WriteLine("Opção invalida!!"); break;
        }
    }

    public static void AdicionarContatos(List<string> contatos)
    {
        Console.WriteLine("------ Adicionar Contatos ------");
        Console.WriteLine("Digite o nome do contato: ");
        string nome = Console.ReadLine();
        contatos.Add(nome);

        Console.WriteLine($"O contato {nome} foi adicionado!!");
    }

        public static void ListarContatos(List<string> contatos)
    {
        Console.WriteLine("------ Lista de Contatos ------");
        for (int i = 0; i < contatos.Count; i++)
        {
            Console.WriteLine("Número do contato: " + (i+1) + " Nome: " + contatos[i]);
        };
        
    }

    public static void ListarContatosDecrescente(List<string> contatos)
    {
        Console.WriteLine("------ Lista de Contatos ------");
        for (int i = contatos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine("Número do contato: " + (i+1) + " Nome: " + contatos[i]);
        };
    }

    public static void ListarContatosOrdemAlfabetica(List<string> contatos)
    {
        Console.WriteLine("------ Lista de Contatos ------");
        
    }
}
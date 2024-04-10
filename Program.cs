namespace VSD;

class Program
{
    static void Main(string[] args)
    {
        bool pararExecucao = false;
        List<string> contatos = new List<string>();

        while (!pararExecucao)
        {

            Console.WriteLine(@"
            Digite 1 para Verificar se o numero é par ou ímpar \n
            Digite 2 para acessar o menu de contatos ");
            switch (Console.ReadLine())
            {
                case "1": VerificaParImpar.VerificarNumero(); break;
                case "2": Contato.MenuContatos(contatos); break;
                default: Console.WriteLine("Nenhuma opção existente!!"); break;
            }
        
            Console.Write("Deseja continuar a execução do software ?");

            if (Console.ReadLine() == "n")
            {
                pararExecucao = true;
            }
        }
    }
}

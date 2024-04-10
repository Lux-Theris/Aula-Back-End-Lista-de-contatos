namespace VSD;

public class VerificaParImpar
{
    public static void VerificarNumero()
    {
        Console.WriteLine("Digite o número a ser verificado: ");
        
        int numero = Convert.ToInt32(Console.ReadLine());

        if  (numero % 2 > 0)
        {
           Console.WriteLine($"O Número {numero} é Ímpar");
        }else
        {
            Console.WriteLine($"O Número {numero} é Par");
        }
    }
}
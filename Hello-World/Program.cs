using System.Threading;

string option = " ";
bool optionInvalid = false;

    Console.WriteLine("Bem-vindo! Por favor, diga o seu nome: ");
    string nome = Console.ReadLine();

do 
{

    Console.Clear();
    Console.WriteLine("Olá, " + nome + "!");
    Console.WriteLine("\nComo podemos lhe ajudar hoje? ");
    Console.WriteLine("1 - Resolvendo um problema matemático");
    Console.WriteLine("2 - Resolvendo um problema de programação");
    Console.WriteLine("3 - Como usar o programa");
    Console.WriteLine("\nQual seria sua escolha? ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("\nAqui está um site útil para resolver problemas de matemática: https://www.professorferretto.com.br");
            Thread.Sleep(3000);
            optionInvalid = false;
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("\nVocê pode encontrar ajuda para programação em https://www.cursoemvideo.com");
            Thread.Sleep(3000);
            optionInvalid = false;
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("\nPara obter ajuda geral sobre o uso do programa, poderá consultar a documentação disponível online.");
            Thread.Sleep(3000);
            optionInvalid = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine("\nOpção não válida. Tente novamente!");
            Thread.Sleep(3000);
            optionInvalid = true;
            break;
    }

    if (optionInvalid)
    {
    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu.");
    Console.ReadKey();
    }

    Console.Clear();
}
while (option != "1" && option != "2" && option != "3");

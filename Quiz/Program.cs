//Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.


Dictionary<string, string> Quiz = new Dictionary<string, string>();


Quiz.Add ("Qual a cor do ceu?", "azul");
Quiz.Add("Em qual ano estamos??", "2024");

MenuQuiz();

void MenuQuiz()
{
    Console.WriteLine("Programa de quiz do Atair");
    Console.WriteLine("\nDigite qualquer tecla para começar o quiz");
    Console.ReadKey();
    QuizPerguntas();
}

void QuizPerguntas()
{
    Console.Clear();
    foreach(string pergunta in Quiz.Keys)
    {
        Console.WriteLine(pergunta);
        string resposta = Console.ReadLine()!;
        if (resposta.ToLower() == Quiz[pergunta].ToLower())
        {
            Console.WriteLine("Certa resposta!!");
            Console.WriteLine("Pressione qualquer tecla para ir para próxima pergunta");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine("EROOOUUU!!");
            Console.WriteLine("Pressione qualquer tecla para tentar mais uma vez!");
            Console.ReadKey();
            QuizPerguntas();
        }
    }
    Console.WriteLine("Obrigado por jogar meu jogo");
    Console.WriteLine("Pressione qualquer tecla para jogar novamente");
    Console.ReadKey();
    MenuQuiz();
}
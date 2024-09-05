internal class Program {
    static void Main(string[] args) {
        // Entrada do usuário
        Console.Write("Digite algo: ");
        string value = Console.ReadLine().ToLower();

        // Obtendo número de ocorrência do caractere e fazendo a validação caso não tenha nenhuma ocorrência
        int count = value.Count(i => i == 'a');
        if (count > 0) {
            Console.WriteLine($"Há {count} ocorrências do caractere 'a'");
        }
        else { Console.WriteLine("Não há nenhuma ocorrência do caractere 'a'"); }
    }
}

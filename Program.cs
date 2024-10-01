

# Minha Aplicação

## O que foi utilizado
- **Linguagem**: C#
- **Framework**: .NET 6
- **IDE**: Visual Studio Code

## Etapas implementadas
1. **Criação do Projeto**
   - Utilizando o comando `dotnet new console -n MinhaAplicacao`.
2. **Desenvolvimento da Lógica**
   - Implementação da mensagem de boas-vindas no arquivo `Program.cs`.
3. **Execução da Aplicação**
   - Testes realizados com o comando `dotnet run`.

## Backlog
- [ ] Implementar novas funcionalidades, como entrada de usuário.
- [ ] Criar tratamento de erros.
- [ ] Adicionar testes unitários.

## Conclusão
A aplicação foi desenvolvida como um projeto inicial utilizando C# e .NET. As funcionalidades básicas foram implementadas e a estrutura do projeto está pronta para receber novas melhorias. Prints da aplicação em execução estão incluídos abaixo:

c:\Users\Alunos\Pictures\IMAGEM.png

using System; // Importa o namespace System, que contém classes básicas do .NET

namespace ParaMeuCurriculo // Define o namespace da aplicação
{
    class Program // Define a classe Program
    {
        static void Main(string[] args) // Método principal da aplicação
        {
            // Solicita ao usuário seu nome
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine(); // Lê a entrada do usuário e armazena na variável 'nome'

            // Solicita ao usuário sua profissão
            Console.Write("Digite sua profissão: ");
            string profissao = Console.ReadLine(); // Lê a entrada do usuário e armazena na variável 'profissao'

            // Solicita ao usuário sua experiência
            Console.Write("Digite sua experiência profissional: ");
            string experiencia = Console.ReadLine(); // Lê a entrada do usuário e armazena na variável 'experiencia'

            // Exibe o currículo formatado
            Console.WriteLine("\n--- Currículo ---");
            Console.WriteLine($"Nome: {nome}"); // Exibe o nome do usuário
            Console.WriteLine($"Profissão: {profissao}"); // Exibe a profissão do usuário
            Console.WriteLine($"Experiência: {experiencia}"); // Exibe a experiência do usuário

            // Finaliza a aplicação
			Console.WriteLine("");
            Console.WriteLine("Aqui está seu curriculo! ");
        }
    }
}

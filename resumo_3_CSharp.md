## 1. Funções e Métodos

A ideia aqui é dividir um trabalho em tarefas menores. Imagine que queremos pedir o nome e o ano de nascimento de alguém e depois exibir uma saudação e a idade aproximada da pessoa.

São duas tarefas separadas: 1) Saudar. 2) Calcular a idade.

```csharp
using System;

class Program
{
    // O "Gerente". Ele só pede as informações e chama os especialistas.
    static void Main(string[] args)
    {
        Console.Write("Qual é o seu nome? ");
        string nomeUsuario = Console.ReadLine();

        Console.Write("Em que ano você nasceu? ");
        int anoNascimento = Convert.ToInt32(Console.ReadLine());

        // Tarefa 1: Chama o especialista em saudar.
        SaudarPessoa(nomeUsuario);

        // Tarefa 2: Chama o especialista em calcular idade e recebe a resposta.
        int idadeAproximada = CalcularIdade(anoNascimento);

        Console.WriteLine($"Você tem ou fará aproximadamente {idadeAproximada} anos.");
    }

    // --- NOSSOS ESPECIALISTAS ---

    // ESPECIALISTA 1: Apenas saúda. Não devolve nenhuma resposta (void).
    // Ele recebe o nome como "ingrediente" para poder trabalhar.
    public static void SaudarPessoa(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Que bom te ver por aqui.");
    }

    // ESPECIALISTA 2: Calcula a idade. Ele devolve uma resposta (um número inteiro 'int').
    // Ele recebe o ano de nascimento como "ingrediente".
    public static int CalcularIdade(int ano)
    {
        int anoAtual = 2025; // Estamos usando o ano atual para o cálculo
        int idade = anoAtual - ano;
        return idade; // Devolve a resposta
    }
}
```
**O que aprendemos aqui:**
* **`SaudarPessoa`** é uma função **`void`**: ela faz uma ação (escreve na tela), mas não retorna nenhum valor.
* **`CalcularIdade`** é uma função **`int`**: ela faz um cálculo e **`return`** (retorna) um resultado que pode ser guardado em uma variável.

---

## 2. Ordenação e Busca

Vamos usar um cenário bem simples: uma pequena lista de pontuações de um jogo.

### Ordenação: Colocando Pontuações em Ordem

Usaremos o **Bubble Sort**. A ideia é "empurrar" o maior número para o final da lista, passo a passo, comparando elementos vizinhos.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] pontuacoes = { 8, 3, 9, 5 };

        Console.WriteLine("Pontuações originais: 8, 3, 9, 5");

        // Chama a função para colocar em ordem
        OrdenarVetor(pontuacoes);

        Console.Write("Pontuações ordenadas: ");
        foreach (int p in pontuacoes)
        {
            Console.Write(p + ", "); // Saída: 3, 5, 8, 9,
        }
    }

    public static void OrdenarVetor(int[] vetor)
    {
        int tamanho = vetor.Length;
        for (int i = 0; i < tamanho - 1; i++)
        {
            for (int j = 0; j < tamanho - 1; j++)
            {
                // Compara um elemento com o seu vizinho da direita
                if (vetor[j] > vetor[j + 1])
                {
                    // Se o da esquerda for maior, eles trocam de lugar
                    int temp = vetor[j];      // Guarda o 8 temporariamente
                    vetor[j] = vetor[j + 1];  // Põe o 3 no lugar do 8
                    vetor[j + 1] = temp;      // Põe o 8 (que estava guardado) no lugar do 3
                }
            }
        }
    }
}
```
**Como `OrdenarVetor` funciona (na 1ª passagem):**
1. Vetor inicial: `{ 8, 3, 9, 5 }`
2. Compara `8` e `3`. `8 > 3`, então troca: `{ 3, 8, 9, 5 }`
3. Compara `8` e `9`. `8 < 9`, não faz nada: `{ 3, 8, 9, 5 }`
4. Compara `9` e `5`. `9 > 5`, então troca: `{ 3, 8, 5, 9 }`. O `9` (maior número) já foi "empurrado" para o final.

O processo se repete até que tudo esteja em ordem.

### Busca: Procurando por uma Pontuação (Busca Linear)

Esta é a busca mais simples. Ela percorre a lista do início ao fim, um por um, até encontrar o que procura.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] pontuacoes = { 3, 8, 5, 9 };
        int pontuacaoProcurada = 5;

        // Chama a função que procura
        bool achou = EncontrarPontuacao(pontuacoes, pontuacaoProcurada);

        if (achou)
        {
            Console.WriteLine($"Sim, a pontuação {pontuacaoProcurada} está na lista!");
        }
        else
        {
            Console.WriteLine($"Não, a pontuação {pontuacaoProcurada} não foi encontrada.");
        }
    }

    // Esta função retorna 'true' se encontrar o número, e 'false' se não encontrar.
    public static bool EncontrarPontuacao(int[] vetor, int alvo)
    {
        // Percorre cada elemento do vetor
        foreach (int pontuacao in vetor)
        {
            // Se o elemento atual for o que estamos procurando...
            if (pontuacao == alvo)
            {
                return true; // ...encontramos! Retorna 'true' e a função para.
            }
        }

        // Se o loop terminar e não tivermos encontrado, retorna 'false'.
        return false;
    }
}
```

---

## 3. Recursão

Vamos fazer uma **contagem regressiva**. A função vai se chamar para contar o próximo número até chegar a zero. Toda função recursiva precisa de:

* **Caso Base:** A condição que PARA a recursão.
* **Passo Recursivo:** Onde a função chama a si mesma com um problema menor.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando contagem regressiva...");
        ContagemRegressiva(5); // Começa a contagem a partir de 5
    }

    public static void ContagemRegressiva(int numero)
    {
        // 1. Caso Base: A condição que PARA a recursão.
        // Se o número for zero ou menos, a contagem acaba.
        if (numero <= 0)
        {
            Console.WriteLine("Lançar!");
            return; // 'return' aqui para a execução da função atual.
        }

        // Ação da função: mostra o número atual
        Console.WriteLine(numero);

        // 2. Passo Recursivo: A função chama a si mesma,
        // mas com um problema menor (numero - 1).
        ContagemRegressiva(numero - 1);
    }
}
```
**O que acontece quando chamamos `ContagemRegressiva(5)`:**
1.  `ContagemRegressiva(5)` imprime "5" e chama `ContagemRegressiva(4)`.
2.  `ContagemRegressiva(4)` imprime "4" e chama `ContagemRegressiva(3)`.
3.  `ContagemRegressiva(3)` imprime "3" e chama `ContagemRegressiva(2)`.
4.  `ContagemRegressiva(2)` imprime "2" e chama `ContagemRegressiva(1)`.
5.  `ContagemRegressiva(1)` imprime "1" e chama `ContagemRegressiva(0)`.
6.  `ContagemRegressiva(0)` entra no `if`, imprime "Lançar!" e para. A "cascata" de chamadas termina.

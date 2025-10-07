## 1. Coleções: Formas de Guardar Vários Dados

Pense nas coleções como "caixas" especiais para guardar e organizar múltiplos itens. Cada tipo de "caixa" tem um jeito diferente de organizar, o que a torna melhor para certas tarefas.

---

### `List<T>` (A Lista Telefônica Moderna)
É a coleção mais usada e versátil. É como uma lista numerada e flexível.

* **O que faz?** Guarda uma sequência de itens. Você pode adicionar, remover e acessar qualquer item rapidamente se souber sua posição (o índice).
* **Analogia:** Uma lista de compras. Você pode adicionar itens no final, riscar itens do meio e ver o que é o item número 3 da lista.
* **Quando usar?** Quase sempre que você precisar de uma lista de coisas. É o seu "padrão".

```csharp
// Criando uma lista de textos (strings)
List<string> nomes = new List<string>();

// Adicionando itens
nomes.Add("Louise");
nomes.Add("Juliana");
nomes.Add("Marcela");

// Acessando pelo índice (posição)
Console.WriteLine(nomes[0]); // Saída: Louise

// Removendo um item
nomes.Remove("Juliana");
```

> **E o `ArrayList`?** O `ArrayList` é o "avô" do `List<T>`. Ele fazia a mesma coisa, mas de um jeito menos seguro e eficiente. **Hoje em dia, sempre prefira usar `List<T>`**.

---

### `LinkedList<T>` (O Trem ou Caça ao Tesouro)
É uma lista onde cada item está "ligado" ao próximo e ao anterior.

* **O que faz?** É otimizado para adicionar e remover itens no meio da lista muito, muito rápido.
* **Analogia:** Um trem de carga. Para adicionar ou remover um vagão do meio, você só precisa desengatar e reengatar duas conexões. Mas para encontrar um vagão específico, você precisa passar por todos desde o início.
* **Quando usar?** Em situações raras onde você adiciona/remove itens do meio da lista com muita frequência.

---

### `Dictionary<TKey, TValue>` (O Dicionário de Verdade)
Guarda itens em pares de "Chave" e "Valor".

* **O que faz?** Permite encontrar um valor instantaneamente se você souber a sua chave única.
* **Analogia:** Um dicionário de português. Você procura a *chave* (a palavra "Abacaxi") para encontrar o *valor* (a definição da fruta).
* **Quando usar?** Quando você precisa fazer buscas muito rápidas por um identificador único.

```csharp
// Criando um dicionário [int, string] -> (RA do aluno, Nome do aluno)
Dictionary<int, string> alunos = new Dictionary<int, string>();

// Adicionando itens (Chave, Valor)
alunos.Add(1234, "Louise");
alunos.Add(5678, "Ralf");

// Buscando um valor pela chave
Console.WriteLine(alunos[1234]); // Saída: Louise
```

---

### `Queue<T>` (A Fila do Banco)
Funciona no sistema **"Primeiro a Entrar, Primeiro a Sair" (FIFO - First-In, First-Out)**.

* **O que faz?** Garante que os itens sejam processados na ordem exata em que chegaram.
* **Analogia:** Uma fila para o caixa do supermercado. Quem chegou primeiro é atendido primeiro.
* **Operações:** `Enqueue()` (entrar no final da fila) e `Dequeue()` (atender e remover quem está no início).

```csharp
Queue<string> filaAtendimento = new Queue<string>();

filaAtendimento.Enqueue("Cliente A"); // Cliente A entrou
filaAtendimento.Enqueue("Cliente B"); // Cliente B entrou

Console.WriteLine(filaAtendimento.Dequeue()); // Saída: Cliente A (foi atendido e saiu)
```

---

### `Stack<T>` (A Pilha de Pratos)
Funciona no sistema **"Último a Entrar, Primeiro a Sair" (LIFO - Last-In, First-Out)**.

* **O que faz?** Permite acesso rápido apenas ao item mais recente que foi adicionado.
* **Analogia:** Uma pilha de pratos. Você coloca um prato no topo e, na hora de pegar, você pega o do topo primeiro. O botão "Desfazer" (Ctrl+Z) em programas funciona assim.
* **Operações:** `Push()` (empilhar um item no topo) e `Pop()` (remover o item do topo).

```csharp
Stack<string> historicoNavegacao = new Stack<string>();

historicoNavegacao.Push("google.com");
historicoNavegacao.Push("youtube.com");

Console.WriteLine(historicoNavegacao.Pop()); // Saída: youtube.com (última página visitada)
```

---

## 2. Manipulação de Textos, Números e Datas

### Textos (`string`)
Algumas funções úteis para trabalhar com textos:
```csharp
string frase = "   Estudando C# na terça-feira   ";

// Tirar espaços em branco do início e do fim
Console.WriteLine(frase.Trim()); // "Estudando C# na terça-feira"

// Deixar tudo em maiúsculo ou minúsculo
Console.WriteLine(frase.ToUpper()); // "   ESTUDANDO C# NA TERÇA-FEIRA   "
Console.WriteLine(frase.ToLower()); // "   estudando c# na terça-feira   "

// Trocar uma parte do texto por outra
Console.WriteLine(frase.Replace("terça-feira", "quarta-feira"));

// Verificar se o texto contém uma palavra
bool contemCSharp = frase.Contains("C#"); // Retorna true

// Pegar um pedaço do texto
string palavra = "Programando";
Console.WriteLine(palavra.Substring(0, 7)); // Pega do índice 0 até 7 caracteres -> "Program"
```

### Números
Além das operações básicas, é comum formatar números para exibição:
```csharp
double valor = 1250.75;

// Formato de moeda (usa o R$ do sistema)
Console.WriteLine(valor.ToString("C")); // Saída: R$ 1.250,75

// Formato com 2 casas decimais fixas
Console.WriteLine(valor.ToString("F2")); // Saída: 1250,75

// Funções matemáticas úteis
Console.WriteLine(Math.Round(19.8));   // Arredonda para 20
Console.WriteLine(Math.Max(10, 20));     // Pega o maior número -> 20
```

### Datas (`DateTime`)
Para trabalhar com datas e horas:
```csharp
// Pega a data e hora atual
DateTime agora = DateTime.Now;

Console.WriteLine(agora);

// Adicionar 5 dias a partir de hoje
DateTime daqui5dias = agora.AddDays(5);
Console.WriteLine(daqui5dias);

// Formatar a data para o padrão brasileiro
Console.WriteLine(agora.ToString("dd/MM/yyyy"));       // Saída: 07/10/2025
Console.WriteLine(agora.ToString("HH:mm:ss"));          // Saída: 13:54:27
```

---

## 3. Tratamento de Exceção (`try-catch`)

* **O que é?** É uma "rede de segurança" para o seu código. Erros (exceções) podem acontecer e, sem tratamento, seu programa quebra.
* **Como funciona?**
    * **`try`**: Você coloca o código "perigoso" dentro deste bloco.
    * **`catch`**: Se um erro acontecer dentro do `try`, o programa pula para o `catch`, onde você pode tratar o erro sem que o programa quebre.
    * **`finally`**: (Opcional) O código aqui dentro sempre executa, não importa se deu erro ou não.

```csharp
Console.WriteLine("Digite sua idade:");
string entrada = Console.ReadLine();

try
{
    // Tenta executar o código perigoso
    int idade = Convert.ToInt32(entrada);
    Console.WriteLine($"Daqui a 10 anos você terá {idade + 10} anos.");
}
catch (Exception ex)
{
    // Se der erro na conversão, o código pula para cá
    Console.WriteLine("Ops, você não digitou um número válido!");
}
finally
{
    Console.WriteLine("O programa terminou a verificação.");
}
```

---

## 4. Enums

* **O que é?** É uma forma de criar um tipo com um conjunto limitado de valores nomeados. Ele dá "nomes amigáveis" para números, tornando o código mais legível.

```csharp
// Definindo o enum
public enum StatusMatricula
{
    Ativa,
    Inativa,
    Trancada,
    Concluida
}

// Usando o enum no código
StatusMatricula status = StatusMatricula.Ativa;

if (status == StatusMatricula.Ativa)
{
    Console.WriteLine("O aluno está com a matrícula ativa.");
}
```

---

## 5. Gerenciador de Pacotes NuGet

* **O que é?** É a "loja de aplicativos" para programadores .NET.
* **Analogia:** Imagine que você precisa de uma funcionalidade específica (ex: criar um PDF). Em vez de programar do zero, você vai no NuGet, procura por um "pacote" de código pronto que faz isso, e instala no seu projeto com um clique.

---

## 6. Manipulação de Arquivo TXT

Para ler e escrever em arquivos de texto (`.txt`), o C# torna tudo muito simples.

```csharp
using System.IO; // Necessário para manipular arquivos

// --- ESCREVENDO EM UM ARQUIVO ---
string caminhoArquivo = "meu_resumo.txt";
string conteudo = "Linha 1 do meu resumo.\nLinha 2 do meu resumo.";

// Escreve todo o conteúdo no arquivo. Se não existir, ele cria. Se já existir, ele sobrescreve!
File.WriteAllText(caminhoArquivo, conteudo);

Console.WriteLine("Arquivo salvo com sucesso!");


// --- LENDO DE UM ARQUIVO ---
if (File.Exists(caminhoArquivo))
{
    // Lê todo o conteúdo do arquivo para uma única string
    string conteudoLido = File.ReadAllText(caminhoArquivo);
    Console.WriteLine("\nConteúdo lido do arquivo:");
    Console.WriteLine(conteudoLido);
}
```

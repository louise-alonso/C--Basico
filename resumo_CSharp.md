# Lógica e Algoritmos com C#

### **Conceitos Fundamentais**

* **Linguagem C#:** É a linguagem de programação que você usa para escrever os comandos e a lógica do seu programa. Foi criada e é mantida pela Microsoft.
* **.NET:** É a plataforma (ou *framework*) onde seu código C# é executado. Ele fornece um conjunto de ferramentas e bibliotecas de código prontas que facilitam a criação de aplicações.
    > **O que é um Framework?** Pense no framework como uma "caixa de ferramentas" gigante para o programador. Em vez de construir tudo do zero, você usa as ferramentas (códigos prontos) que o .NET oferece para criar seu sistema de forma mais rápida e segura.
* **Lógica:** É a habilidade de organizar o pensamento de forma estruturada para resolver um problema. É o "como fazer algo?" de maneira eficiente.
* **Algoritmo:** É a sequência de passos, o "passo a passo" detalhado, que o computador deve seguir para executar a lógica que você definiu.

---

### **Comandos Básicos de Terminal (CLI)**

* **Criar um novo projeto:**
    ```bash
    dotnet new console -n NOME_DO_PROJETO
    ```
    * `dotnet`: Comando principal do .NET.
    * `new`: Ação de criar um novo projeto.
    * `console`: Tipo de projeto (uma aplicação de texto, que roda no terminal).
    * `-n NOME_DO_PROJETO`: Define o nome do seu projeto.

* **Executar o projeto:**
    ```bash
    dotnet run
    ```
    * `run`: Compila e executa o código do seu projeto.

---

### **Escrevendo na Tela (Saída de Dados)**

* **`Console.WriteLine()`**: Escreve um texto e "quebra a linha" (o próximo texto aparecerá na linha de baixo).
    ```csharp
    Console.WriteLine("Olá, Mundo!");
    Console.WriteLine("Estou em uma nova linha.");
    ```
* **`Console.Write()`**: Escreve um texto, mas **não** quebra a linha (o próximo texto aparecerá ao lado).
    ```csharp
    Console.Write("Olá, ");
    Console.Write("Mundo!"); // Isso aparecerá na mesma linha: "Olá, Mundo!"
    ```

---

### **Variáveis e Constantes**

Variáveis são "caixinhas" na memória para guardar dados que podem mudar durante a execução do programa.

* **Tipos de Variáveis:**
    ```csharp
    // Textos (string)
    string nome = "Louise";

    // Apenas uma letra (char), usa aspas simples ''
    char primeiraLetra = 'L';

    // Números inteiros (int)
    int idade = 21;

    // Números com casas decimais (double ou float)
    double altura = 1.65;

    // Verdadeiro ou Falso (bool)
    bool estaEstudando = true;
    ```

* **Constantes:** O valor é definido uma vez e **não pode** ser alterado.
    ```csharp
    const string PAIS = "Brasil";
    // Tentar fazer PAIS = "Argentina"; daria um erro.
    ```

---

### **Manipulando Textos (Strings)**

* **Concatenação com `+`:** Juntar textos usando o sinal de mais.
    ```csharp
    string nome = "Louise";
    string cidade = "São Paulo";
    Console.WriteLine(nome + " mora em " + cidade);
    ```

* **Interpolação com `$`:** Uma forma mais moderna e legível de juntar textos e variáveis.
    ```csharp
    Console.WriteLine($"{nome} mora em {cidade}");
    ```

---

### **Lendo Dados do Usuário (Entrada de Dados)**

* **`Console.ReadLine()`**: Pausa o programa e espera o usuário digitar algo e apertar Enter. O que foi digitado é retornado como `string`.
    ```csharp
    Console.WriteLine("Qual é o seu nome?");
    string? nomeUsuario = Console.ReadLine();
    Console.WriteLine($"Olá, {nomeUsuario}!");
    ```

* **Convertendo Tipos:** Como `ReadLine()` sempre retorna texto, você precisa converter se quiser um número.
    ```csharp
    Console.WriteLine("Informe o primeiro número:");
    int numero1 = Convert.ToInt32(Console.ReadLine()); // ToInt32 é mais comum que ToInt16

    Console.WriteLine("Informe o segundo número:");
    int numero2 = Convert.ToInt32(Console.ReadLine());

    int soma = numero1 + numero2;
    Console.WriteLine($"A soma de {numero1} + {numero2} é {soma}");
    ```

---

### **Operadores**

* **Aritméticos:**
    ```csharp
    int numero1 = 30;
    int numero2 = 4;

    Console.WriteLine(numero1 + numero2); // Soma: 34
    Console.WriteLine(numero1 - numero2); // Subtração: 26
    Console.WriteLine(numero1 * numero2); // Multiplicação: 120
    Console.WriteLine(numero1 / numero2); // Divisão (inteira): 7
    Console.WriteLine(numero1 % numero2); // Módulo (resto da divisão): 2
    ```

* **Incremento (`++`) e Decremento (`--`)**
    ```csharp
    int contador = 10;
    contador++; // contador agora vale 11
    contador--; // contador volta a valer 10
    ```
    > **Qual a diferença de `++contador` para `contador++`?**
    > * `contador++` (pós-incremento): Usa o valor atual do `contador` na operação e **depois** soma 1.
    > * `++contador` (pré-incremento): Primeiro soma 1 ao `contador` e **depois** usa o novo valor na operação.

* **Relacionais (Comparações):** Retornam `true` ou `false`.
    ```csharp
    int a = 5;
    int b = 8;
    Console.WriteLine(a > b);  // Maior que? -> False
    Console.WriteLine(a < b);  // Menor que? -> True
    Console.WriteLine(a >= b); // Maior ou igual? -> False
    Console.WriteLine(a <= b); // Menor ou igual? -> True
    Console.WriteLine(a == b); // Igual a? -> False
    Console.WriteLine(a != b); // Diferente de? -> True
    ```

* **Lógicos:** Usados para combinar expressões lógicas.
    ```csharp
    double nota1 = 7.0;
    double nota2 = 5.0;

    // Operador E (&&): As duas condições devem ser verdadeiras.
    Console.WriteLine(nota1 >= 7 && nota2 >= 7); // False

    // Operador OU (||): Pelo menos uma condição deve ser verdadeira.
    Console.WriteLine(nota1 >= 7 || nota2 >= 7); // True

    // Operador NÃO (!): Inverte o resultado lógico.
    Console.WriteLine(!(nota1 >= 7)); // False (porque nota1 >= 7 é True)
    ```

---

### **Estruturas Condicionais**

* **`if / else` (Se / Se não):** Executa um bloco de código se uma condição for verdadeira, e outro bloco se for falsa.
    ```csharp
    int idade = 19;
    if (idade >= 18)
    {
        Console.WriteLine("Pode obter a CNH.");
    }
    else
    {
        Console.WriteLine("Não pode obter a CNH.");
    }
    ```

* **`if / else if / else` (Encadeada):** Testa várias condições em sequência.
    ```csharp
    double media = 8.0;
    if (media >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else if (media >= 5)
    {
        Console.WriteLine("Em exame");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
    ```

* **Operador Ternário:** Uma forma compacta de escrever um `if/else` simples.
    ```csharp
    double media = 8.0;
    string situacao = media >= 7 ? "Aprovado" : "Reprovado";
    Console.WriteLine(situacao); // Imprime "Aprovado"
    ```

* **`switch` (Estrutura de Escolha):** Compara uma única variável com vários valores possíveis.
    ```csharp
    string linguagem = "C#";
    switch (linguagem)
    {
        case "HTML":
            Console.WriteLine("Linguagem de marcação.");
            break;
        case "C#":
            Console.WriteLine("Linguagem de programação.");
            break;
        default:
            Console.WriteLine("Linguagem desconhecida.");
            break;
    }
    ```
    > **Diferença entre `if` e `switch`?**
    > * Use `if/else` para checar intervalos (`idade > 18`) ou múltiplas condições complexas (`media >= 7 && faltas < 10`).
    > * Use `switch` quando for testar uma única variável contra uma lista de valores exatos e constantes ("HTML", "C#", 1, 2, 3...). Geralmente, o código fica mais limpo.

---

### **Estruturas de Repetição (Loops)**

* **`while` (Enquanto):** Repete um bloco de código **enquanto** uma condição for verdadeira. A condição é testada no início.
    ```csharp
    int indice = 1;
    while (indice <= 5)
    {
        Console.WriteLine(indice);
        indice++;
    }
    ```

* **`do-while` (Faça-Enquanto):** Garante que o bloco de código seja executado **pelo menos uma vez**, pois a condição é testada no final.
    ```csharp
    int indice = 1;
    do
    {
        Console.WriteLine(indice);
        indice++;
    } while (indice <= 5);
    ```

* **`for` (Para):** Ideal quando você sabe exatamente quantas vezes quer repetir.
    ```csharp
    // for (inicialização; condição; incremento)
    for (int indice = 1; indice <= 5; indice++)
    {
        Console.WriteLine(indice);
    }
    ```
    > **Qual loop usar?**
    > * `for`: Quando você sabe o número de repetições (ex: "repita 10 vezes").
    > * `while`: Quando você não sabe quantas vezes vai repetir, mas tem uma condição de parada (ex: "repita enquanto o usuário não digitar 'sair'").
    > * `do-while`: Igual ao `while`, mas quando você precisa que o código execute ao menos uma vez antes de checar a condição.

---

### **Estruturas de Dados Simples**

* **Vetor (Array):** Uma coleção de variáveis do mesmo tipo, acessadas por um índice (que começa em 0).
    ```csharp
    // Criando um vetor de nomes
    string[] nomes = { "Louise", "Juliana", "Marcela" };

    // Acessando um item específico
    Console.WriteLine(nomes[0]); // Exibe "Louise"

    // Percorrendo o vetor com um for
    for (int indice = 0; indice < nomes.Length; indice++)
    {
        Console.WriteLine(nomes[indice]);
    }
    ```

* **`foreach` (Para cada):** Uma forma mais simples de percorrer todos os itens de uma coleção, sem se preocupar com o índice.
    ```csharp
    string[] cores = { "Verde", "Rosa", "Vermelho" };

    // foreach (Tipo apelido in coleção)
    foreach (string cor in cores)
    {
        Console.WriteLine(cor);
    }
    ```
    > **O que é `cor` em `string cor in cores`?** A cada repetição, a variável `cor` recebe, temporariamente, uma cópia de um dos itens do vetor `cores`. É como dizer "para cada `cor` que existe dentro da coleção `cores`, faça algo".

* **Matriz (Array 2D):** É como um vetor de vetores, organizado em linhas e colunas, como uma tabela.
    > **Diferença entre Vetor e Matriz:** Um vetor tem apenas uma dimensão (uma linha). Uma matriz tem duas dimensões (linhas e colunas).
    ```csharp
    // Matriz com 2 linhas e 2 colunas
    string[,] dados = {
        { "Ralf", "Curitiba" },
        { "Louise", "São Paulo" }
    };

    // Acessando um item (linha 0, coluna 1)
    Console.WriteLine(dados[0, 1]); // Exibe "Curitiba"
    ```

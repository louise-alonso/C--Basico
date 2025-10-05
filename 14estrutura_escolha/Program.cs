// //variavel
 string linguagem = "HTML";

// //estrutura de escolha
// switch (linguagem1)
// {
//     case "HTML":
//         Console.WriteLine("Linguagem HTML");
//         break;

//     case "CSS":
//         Console.WriteLine("Linguagem CSS");
//         break;

//     case "JavaScript":
//         Console.WriteLine("Linguagem JavaScript");
//         break;

//     default:
//         Console.WriteLine("Linguagem não encontrada");
//         break;
// }

//expressao switch
string retorno = linguagem switch
{
    "HTML"       => "Linguagem HTML",
    "CSS"        => "Linguagem CSS",
    "JavaScript" => "Linguagem JavaScript",
    _            => "Linguagem não encontrada"

};
Console.WriteLine(retorno);
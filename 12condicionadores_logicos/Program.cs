//variaveis
double valor = 500;
string pagamento = "a vista";

//condicional
if (valor >= 100 && pagamento == "a vista" ) 
{
    Console.WriteLine($"desconto de 10%: {valor * 0.9}");
} else {
    Console.WriteLine("sem desconto");
}
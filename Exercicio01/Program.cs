static void Imc()
{
    Console.WriteLine("----------------");
    Console.WriteLine("Bem vindo!");
    Console.WriteLine("----------------");
    Console.WriteLine("Digite o seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("----------------");
    Console.WriteLine("Digite o ano que voce nasceu: ");
    int idade = 2024 - int.Parse(Console.ReadLine());
    Console.WriteLine("----------------");
    Console.WriteLine("Digite seu peso: ");
    double peso = double.Parse(Console.ReadLine());
    Console.WriteLine("----------------");
    Console.WriteLine("Digite sua altura: ");
    double altura = double.Parse(Console.ReadLine());
    Console.WriteLine("----------------");
    double imc = peso / (altura * altura);
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade: " + idade);
    Console.WriteLine("Peso: " + peso);
    Console.WriteLine("ALtura: " + altura);
    Console.WriteLine("IMC: " + imc);
}

System.Text.StringBuilder a = new System.Text.StringBuilder();

a.AppendLine("cu")
.AppendLine("cu2")
.AppendLine("cu3");

Console.Write("Digite um numero para saber se é impar ou par: ");
int numero = int.Parse(Console.ReadLine());
if (numero > 0 && numero % 2 == 0)
{
    Console.WriteLine("O número é positivo e par.");
}
else
{
    Console.WriteLine("O número não é positivo ou não é par.");
}
Console.Write("Digite algum ano de preferencia: ");
int ano = int.Parse(Console.ReadLine());
if (ano % 4 == 0) {
    Console.WriteLine("O ano é bissexto.");
} else {
    Console.WriteLine("O ano não é bissexto.");
}

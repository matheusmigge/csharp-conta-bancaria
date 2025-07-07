using ContaBancaria;

Console.WriteLine("Bem vinda ao sistema de Conta Bancaria");
Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações com Conta <<<\n");
Conta c1 = new Conta("001", "Joana", 2000);
c1.ExibirSaldo();
c1.Sacar(1000m);
c1.ExibirSaldo();

Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações com ContaCorrente <<<\n");
ContaCorrente cc1 = new ContaCorrente("001", "Vinicius", 1000.00m, 500);
cc1.ExibirSaldo();
cc1.Depositar(500.00m);
cc1.ExibirSaldo();

Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações em Conta Poupança <<<\n");
ContaPoupanca cp = new ContaPoupanca("CP-001", "José Santos", 6000, 0.05m); // 5% de juros
cp.ExibirSaldo();
cp.Sacar(5000);
cp.AdicionarJuros();
cp.ExibirSaldo();

Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações com lista <<<\n");

List<Conta> todasAsContas = new List<Conta>();

todasAsContas.Add(new ContaCorrente("001", "João Silva", 1000, 500));
todasAsContas.Add(new ContaPoupanca("001", "Maria Oliveira", 2000, 5.0m)); 

double valorSaque = 300;

foreach (Conta conta in todasAsContas)
{
    conta.ExibirSaldo();
    conta.Sacar((decimal)valorSaque);
    conta.ExibirSaldo();
}

Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações com Seguro <<<\n");

ContaCorrente contaCorrente = new ContaCorrente("CC-001", "João Silva", 1000m, 500);
ContaPoupanca contaPoupanca = new ContaPoupanca("CP-002", "Maria Oliveira", 2000m, 5);

var seguro = new SeguroDeVida();

//lista do tipo interface
List<ITributavel> listaDeTributaveis = new List<ITributavel>();

listaDeTributaveis.Add(contaCorrente);
listaDeTributaveis.Add(seguro);
//listaDeTributaveis.Add(contaPoupanca);

Console.WriteLine("Calculando impostos de todos os tributáveis:");
double totalImpostos = 0;

foreach (var item in listaDeTributaveis)
{
    double tributoDoItem = item.CalcularImposto();
    totalImpostos += tributoDoItem;
    Console.WriteLine($"Tributo para o item {item.GetType().Name}: {tributoDoItem:C}");
}

Console.WriteLine($"Total de impostos: {totalImpostos:C}");



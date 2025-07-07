using ContaBancaria;

Console.WriteLine("Bem vinda ao sistema de Conta Bancaria");
Console.WriteLine("=======================================");
Console.WriteLine(">>> Operações com ContaCorrente <<<");
Conta cc1 = new Conta("001", "Vinicius", 1000.00m);
cc1.ExibirSaldo();
cc1.Depositar(500.00m);
cc1.ExibirSaldo();

Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações em Conta Poupança <<<");
ContaPoupanca cp = new ContaPoupanca("CP-001", "José Santos", 5000, 0.05m); // 5% de juros
cp.ExibirSaldo();
cp.Sacar(1000);
// Usando o método específico da Conta Poupança
cp.AdicionarJuros();
cp.ExibirSaldo();

Console.WriteLine("\n-----------------------------------------------------\n");
Console.WriteLine(">>> Operações com lista <<<");

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



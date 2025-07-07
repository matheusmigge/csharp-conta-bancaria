using ContaBancaria;

Console.WriteLine("Bem vinda ao sistema de Conta Bancaria");
Console.WriteLine("=======================================");
Console.WriteLine("Operações com ContaCorrente");

Conta cc1 = new Conta("001", "Vinicius", 1000.00m);

cc1.ExibirSaldo();
cc1.Depositar(500.00m);
cc1.ExibirSaldo();

Console.WriteLine("\n-----------------------------------------------------\n");

// Criando e usando uma Conta Poupança
Console.WriteLine(">>> Operações em Conta Poupança <<<");
ContaPoupanca cp = new ContaPoupanca("CP-001", "José Santos", 5000, 0.05m); // 5% de juros
cp.ExibirSaldo();
cp.Sacar(1000);
// Usando o método específico da Conta Poupança
cp.AdicionarJuros();
cp.ExibirSaldo();
using bytebank;
using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Boas vindas ao ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Fernando";
//conta1.conta = "123456-X";
//conta1.agencia = 1000;
//conta1.nomeAgencia = "Agência Pacaembu";
//conta1.saldo = 1000;

//ContaCorrente conta2 = new ContaCorrente();
//conta1.saldo = 1000;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Agência: " + conta1.agencia);
//Console.WriteLine("Nome da agência: " + conta1.nomeAgencia);
//Console.WriteLine("Saldo: R$" + conta1.saldo);

//conta1.Sacar(50);
//Console.WriteLine("Saldo: R$" + conta1.saldo);

//conta1.Depositar(150);
//Console.WriteLine("Saldo: R$" + conta1.saldo);

//conta1.Transferir(500, conta2);
//Console.WriteLine("Saldo: R$" + conta1.saldo);

Cliente cliente = new Cliente();
cliente.Nome = "Fernando";
cliente.Cpf = "123.456.789-00";
cliente.Profissao = "Programador";

ContaCorrente conta2 = new ContaCorrente(1000, "123456-X");
conta2.NomeAgencia = "Agência Pacaembu";

//Console.WriteLine(conta2.NomeAgencia);
//Console.WriteLine(conta2.Agencia);
//Console.WriteLine(conta2.Conta);

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();



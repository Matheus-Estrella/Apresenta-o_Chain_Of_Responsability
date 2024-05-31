using Chain_Of_Responsability;

Console.Write("\nDigite o valor do seu saldo bancário: ");
float saldo = float.Parse(Console.ReadLine());

Console.WriteLine("\nDigite abaixo a quantidade de notas que deseja sacar");

Console.Write("\n[ 200,00 ] : ");
int qnt_duzentos = int.Parse(Console.ReadLine());
Console.Write("\n[ 100,00 ] : ");
int qnt_cem = int.Parse(Console.ReadLine());
Console.Write("\n[ 50,00 ] : ");
int qnt_cinquenta = int.Parse(Console.ReadLine());
Console.Write("\n[ 20,00 ] : ");
int qnt_vinte = int.Parse(Console.ReadLine());
Console.Write("\n[ 10,00 ] : ");
int qnt_dez = int.Parse(Console.ReadLine());
Console.Write("\n[ 5,00 ] : ");
int qnt_cinco = int.Parse(Console.ReadLine());
Console.Write("\n[ 2,00 ] : ");
int qnt_dois = int.Parse(Console.ReadLine());

Duzentos duzentos = new Duzentos(qnt_duzentos);
Cem cem = new Cem(qnt_cem);
Cinquenta cinquenta = new Cinquenta(qnt_cinquenta);
Vinte vinte = new Vinte(qnt_vinte);
Dez dez = new Dez(qnt_dez);
Cinco cinco = new Cinco(qnt_cinco);
Dois dois = new Dois(qnt_dois);

duzentos.Prox(cem);
cem.Prox(cinquenta);
cinquenta.Prox(vinte);
vinte.Prox(dez);
dez.Prox(cinco);
cinco.Prox(dois);

duzentos.LiberarTroco(saldo);
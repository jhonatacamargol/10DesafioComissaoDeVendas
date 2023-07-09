Console.WriteLine("##Comissão de Vendedores##\n");

Console.WriteLine("Nome do Vendedor: ");

var vendedorNome = Console.ReadLine();

Console.Write("Código da peça: ");
var codigoPeca = Console.ReadLine();

Console.Write("Preço unitário da peça: ");
decimal precoUnitario = Convert.ToDecimal(Console.ReadLine());

Console.Write("Quantidade vendida: ");
int quantidadeVendida = Convert.ToInt32(Console.ReadLine());

decimal totalVenda = precoUnitario * quantidadeVendida;
decimal comissao = Convert.ToInt32(totalVenda) * 0.05m;

Console.WriteLine("\n--- Relatório de Comissão ---");
Console.Write($"Vendedor: {vendedorNome}\nCódigo da peça: {codigoPeca}\nPreço unitário: {precoUnitario}\n" +
    $"Quantidade vendida: {quantidadeVendida}\nTotal da venda: {totalVenda}\nComissão: {comissao}");

    
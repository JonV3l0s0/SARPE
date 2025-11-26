using SARPE.Models;

public class ProdutoPaginadoViewModel
{
    public List<Produto> Produtos { get; set; } = new();
    public int PaginaAtual { get; set; }
    public int TamanhoPagina { get; set; }
    public int TotalItens { get; set; }
    public int TotalPaginas => (int)Math.Ceiling((double)TotalItens / TamanhoPagina);
}
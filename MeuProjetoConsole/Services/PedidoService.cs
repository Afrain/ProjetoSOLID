public class PedidoService
{
    private readonly INotificacao _notificacao;

    public PedidoService(INotificacao notificacao)
    {
        _notificacao = notificacao;
    }

    public void RegistrarPedido(Pedido pedido)
    {
        // Lógica para registrar o pedido
        System.Console.WriteLine($"Pedido registrado: Produto={pedido.Produto}, Preço={pedido.Preco}");

        // Enviar notificação
        _notificacao.Enviar($"Pedido registrado: {pedido.Produto} - {pedido.Preco:C}");
    }

}
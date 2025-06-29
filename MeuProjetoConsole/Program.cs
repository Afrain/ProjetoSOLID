var notificacao = new NotificacaoSMS(); // ou new NotificacaoEmail()
var pedido = new PedidoComum { Produto = "Notebook", Preco = 3500 };

var pedidoService = new PedidoService(notificacao);
pedidoService.RegistrarPedido(pedido);

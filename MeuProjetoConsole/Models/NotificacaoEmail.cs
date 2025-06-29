public class NotificacaoEmail : INotificacao
{
    public void Enviar(string mensagem)
    {
        System.Console.WriteLine($"Enviando Email: {mensagem}");
    }
}
public class NotificacaoSMS : INotificacao
{
    public void Enviar(string mensagem)
    {
        System.Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}
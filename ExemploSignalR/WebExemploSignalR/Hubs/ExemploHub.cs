using Microsoft.AspNet.SignalR;

namespace WebExemploSignalR.Hubs
{
    public class ExemploHub : Hub
    {
        public void MensagemParaTodos(string mensagem)
        {
            Clients.All.ExibirMensagem(mensagem);
        }
    }
}
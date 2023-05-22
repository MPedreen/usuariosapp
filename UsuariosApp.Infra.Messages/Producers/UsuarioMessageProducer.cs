using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using UsuariosApp.Application.Interfaces.Producers;
using UsuariosApp.Application.Models.Producers;
using UsuariosApp.Infra.Messages.Settings;

namespace UsuariosApp.Infra.Messages.Producers
{
    public class UsuarioMessageProducer : IUsuarioMessageProducer
    {
        private readonly MessageSettings? _messageSettings;

        public UsuarioMessageProducer(IOptions<MessageSettings>? messageSettings)
        {
            _messageSettings = messageSettings?.Value;
        }

        public void Send(UsuarioMessageDTO dto)
        {
            var _connectionFactory = new ConnectionFactory() { Uri = new Uri(_messageSettings?.Url) };
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var model = connection.CreateModel())
                {
                    model.QueueDeclare(
                        queue: _messageSettings?.Queue, //nome da fila
                        durable: true, //não apagar a fila quando o servidor do RabbitMQ for desligado
                        exclusive: false, //permitir conexões simultaneas
                        autoDelete: false, //somente a aplicação que irá remover itens da fila
                        arguments: null
                        );
                }
            }
        }
    }
}
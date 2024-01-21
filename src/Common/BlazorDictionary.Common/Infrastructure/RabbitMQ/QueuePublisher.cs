using System.Text.Json;
using System.Text;
using RabbitMQ.Client;

namespace BlazorDictionary.Common.Infrastructure.RabbitMQ
{
    public class QueuePublisher : BaseQueue
    {
        public QueuePublisher(string exchange, string queue, string routingKey, string exchangeType = "direct") :
        base(exchange, queue, routingKey, exchangeType)
        {
            base.AutoDeclare(e => e.QueueDeclare().ExchangeDeclare().BindQueue());
        }
        public void Publish(object body)
        {
            var message = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(body));
            Channel.BasicPublish(this.Exchange, base.Queue, null, message);
        }
    }


}

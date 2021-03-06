﻿using Newtonsoft.Json;
using Rabbit.BLL.Rabbitmq;
using Rabbit.MODELS.Entities;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitConsumer
{
    public class Consumer
    {
        private readonly RabbitMqService _rabbitMqService;
        public EventingBasicConsumer ConsumerEvent;
        public Consumer(string queueName)
        {
            _rabbitMqService = new RabbitMqService();
            var connection = _rabbitMqService.GetRabbitMqConnection();
            var channel = connection.CreateModel();
            ConsumerEvent = new EventingBasicConsumer(channel);
            // Received event'i sürekli listen modunda olacaktır.
            ConsumerEvent.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);
                //var data = $"{queueName} isimli queue üzerinden gelen mesaj: \"{message}\"";
                if (queueName == "MailLog")
                {
                    var data = JsonConvert.DeserializeObject<List<MailLog>>(message);
                    //işlemler
                }
                else if (queueName == "Customer")
                {
                    var data = JsonConvert.DeserializeObject<List<Customer>>(message);
                    //işlemler
                }
            };
            channel.BasicConsume(queueName, true, ConsumerEvent);
        }
    }
}

﻿using Newtonsoft.Json.Linq;
using StoreDashboard.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithBackgroundWorker.Common.Messaging;

namespace WebApiWithBackgroundWorker.Subscriber.Messaging
{
    public class InMemoryMessagesRepository : IMessagesRepository
    {
        private readonly ConcurrentQueue<MessageWrapper> _messages;

        public InMemoryMessagesRepository()
        {
            _messages = new ConcurrentQueue<MessageWrapper>();
        }

        public void Add(MessageWrapper message) 
        {
            _messages.Enqueue(message ?? throw new ArgumentNullException(nameof(message)));
        }

        public IReadOnlyCollection<MessageWrapper> GetMessages()
        {
            return _messages.ToArray();
        }


        public IEnumerable<MessageWrapper> GetMessagesEnumerable()
        {
            var x = _messages.ToList();
            return x ;
        }
    }
}
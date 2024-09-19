using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0;
        public Queue<IncomingCall> ? Calls { get; set; }
        
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();  
        }

        // Método para abertura de chamados
        public void Call(int clientId)
        {
            incomingCall call = new IncomingCall()
            {
                id = ++_counter,
                clientId = clientId,
                CallTime = DateTime.Now
            };

            Calls!.Enqueue(call);
        }

        public IncomingCall Answer(string consultant)
        {
            // Validação: verificar se tem atendimentos na Fila
            if(Calls!.count > 0)
            {
                IncomingCall call = new Calls.Dequeue();
                call.consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }
            
            return null!;        
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return (Calls!.count > 0);
        }


    }


}
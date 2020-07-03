using Proekt_Aspa.Models;
using Proekt_Aspa.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt_Aspa.Services
{
    public class ClientsService : IBaseModelClients<Clients>
    {
        public Clients GetClientsByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}

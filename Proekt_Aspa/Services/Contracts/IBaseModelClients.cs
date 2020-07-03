using System;
using System.Collections.Generic;
using System.Text;

namespace Proekt_Aspa.Services.Contracts
{
    public interface IBaseModelClients<T>
    {
        T GetClientsByID(int ID);
    }
}

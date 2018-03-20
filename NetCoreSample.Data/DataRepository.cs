using NetCoreSample.Data.Contracts;
using System;

namespace NetCoreSample.Data
{
    public class DataRepository : IDataRepository
    {
        public string Get()
        {
            return "Repodan dönüyor";
        }
    }
}

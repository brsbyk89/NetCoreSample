using NetCoreSample.Business.Contracts;
using NetCoreSample.Data.Contracts;
using System;

namespace NetCoreSample.Business
{
    public class BusinessEngine : IBusinessEngine
    {
        private IDataRepository _IDataRepository;
        public BusinessEngine(IDataRepository IDataRepository)
        {
            _IDataRepository = IDataRepository;
        }
        public string Get()
        {
            return _IDataRepository.Get();
        }
    }
}

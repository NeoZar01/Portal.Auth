using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoE.Auth.Api
{
    using Lsm.Data.Repositories;

    public class BaseApiController : ApiController
    {
        protected readonly RepositoryStoreManager _dataStoreManager;
        public BaseApiController(RepositoryStoreManager dataStoreManager)
        {
            this._dataStoreManager = dataStoreManager;
        }
    }
}
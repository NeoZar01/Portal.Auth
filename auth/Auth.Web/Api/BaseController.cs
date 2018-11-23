using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoE.Auth.Api
{
    using Lsm.Data.Repositories;

    public class BaseController : Controller
    {
        protected readonly IRepositoryStoreManager _dataStoreManager;
        public BaseController(IRepositoryStoreManager dataStoreManager)
        {
            this._dataStoreManager = dataStoreManager;
        }

    }
}
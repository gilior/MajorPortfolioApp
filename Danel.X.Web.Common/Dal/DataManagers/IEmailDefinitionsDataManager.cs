﻿using Danel.Common.Api.Request;
using Danel.WebApp.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Danel.WebApp.Dal.DataManagers
{
    public interface IEmailDefinitionsDataManager
    {
        EmailDefinitionsRequest GetRequset(EmptyRequest req);
    }
}
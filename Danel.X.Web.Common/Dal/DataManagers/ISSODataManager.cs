﻿using Danel.Common.Api;
using Danel.Common.Api.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Danel.WebApp.DataManagers
{
    public interface ISSODataManager
    {
        SSORequest GetRequset(SSOInterface.SSOItem ssoItem);

    }
}
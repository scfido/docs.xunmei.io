using System;
using System.Collections.Generic;
using System.Text;
using Xunmei.Docs.Localization;
using Volo.Abp.Application.Services;

namespace Xunmei.Docs
{
    /* Inherit your application services from this class.
     */
    public abstract class DocsAppService : ApplicationService
    {
        protected DocsAppService()
        {
            LocalizationResource = typeof(DocsResource);
        }
    }
}

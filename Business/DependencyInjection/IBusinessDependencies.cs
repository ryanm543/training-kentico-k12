﻿using Business.Repository.Company;
using Business.Repository.Culture;
using Business.Repository.Menu;
using Business.Repository.Social;
using Business.Services.Cache;
using Business.Services.Context;

namespace Business.DependencyInjection
{
    public interface IBusinessDependencies
    {
        IMenuRepository MenuRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        ICultureRepository CultureRepository { get; }
        ISiteContextService SiteContextService { get; }
        ISocialLinkRepository SocialLinkRepository { get; }
        ICacheService CacheService { get; }
    }
}

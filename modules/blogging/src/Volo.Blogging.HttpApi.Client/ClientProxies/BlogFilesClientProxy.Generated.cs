// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Blogging.Files;

// ReSharper disable once CheckNamespace
namespace Volo.Blogging.ClientProxies
{
    [Dependency(ReplaceServices = true)]
    [ExposeServices(typeof(IFileAppService), typeof(BlogFilesClientProxy))]
    public partial class BlogFilesClientProxy : ClientProxyBase<IFileAppService>, IFileAppService
    {
        public virtual async Task<RawFileDto> GetAsync(string name)
        {
            return await RequestAsync<RawFileDto>(nameof(GetAsync), name);
        }

        public virtual async Task<FileUploadOutputDto> CreateAsync(FileUploadInputDto input)
        {
            return await RequestAsync<FileUploadOutputDto>(nameof(CreateAsync), input);
        }
    }
}

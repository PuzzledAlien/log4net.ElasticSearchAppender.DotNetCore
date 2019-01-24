using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using log4net.ElasticSearchAppender.Configuration;

namespace log4net.ElasticSearchAppender.ElasticClient
{
    public interface IElasticsearchClient : IDisposable
    {
        ServerDataCollection Servers { get; }
        bool Ssl { get; }
        bool AllowSelfSignedServerCert { get; }
        void PutTemplateRaw(string templateName, string rawBody);
        void IndexBulk(IEnumerable<InnerBulkOperation> bulk);
        Task IndexBulkAsync(IEnumerable<InnerBulkOperation> bulk);
    }
}
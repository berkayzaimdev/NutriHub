using Nest;
using NutriHub.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriHub.Persistence.Services
{
    public class SearchService
    {
        private readonly IElasticClient _elasticClient;

        public SearchService(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task IndexProductAsync(Product product)
        {
            var response = await _elasticClient.IndexDocumentAsync(product);
            if (!response.IsValid)
            {
                throw new Exception();
            }
        }

        public async Task<ISearchResponse<Product>> SearchProductsAsync(string query)
        {
            var response = await _elasticClient.SearchAsync<Product>(s => s
                .Query(q => q
                    .MultiMatch(m => m
                        .Fields(f => f
                            .Field(p => p.Name)
                            .Field(p => p.Description))
                        .Query(query)
                    )
                )
            );

            return response;
        }
    }
}

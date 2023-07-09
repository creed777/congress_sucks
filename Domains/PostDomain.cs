using congress_sucks.Data.Models;
using congress_sucks.Repositories;

namespace congress_sucks.Domains
{
    public class PostDomain : IPostDomain
    {
        private readonly IPostRepository Repository;

        public PostDomain(IPostRepository repository)
        {
            this.Repository = repository;
        }

        public async Task<List<BlogPost>> GetGetNewestPostsAsync()
        {
            return await Repository.GetNewestPostsAsync();
        }
    }
}

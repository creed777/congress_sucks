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

        public async Task<BlogPost> GetBlogPostAsync(int postId)
        {
            return await Repository.GetBlogPostAsync(postId);
        }

        public async Task<bool> CreateBlogPostAsync(BlogPost post)
        {
            return await Repository.CreateBlogPostAsync(post);
        }
    }
}

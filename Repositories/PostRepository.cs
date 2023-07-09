using congress_sucks.Data;
using congress_sucks.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace congress_sucks.Repositories
{
    public class PostRepository : IPostRepository
    {
        private ApplicationDbContext Context { get; set; }


        public PostRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public async Task<BlogPost> GetBlogPostAsync(int postId)
        {
            var result = await Context.BlogPost
                .Where(x => x.Id == postId)
                .SingleOrDefaultAsync()
                .ConfigureAwait(false);

            return result ?? new();
        }
          
        public async Task<List<BlogPost>> GetNewestPostsAsync()
        {
            var result = await Context.BlogPost
                .OrderByDescending(x => x.Updated)
                .Take(3)
                .ToListAsync()
                .ConfigureAwait(false);

            return result ?? new();
        }
    }
}

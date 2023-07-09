using congress_sucks.Data.Models;
using congress_sucks.Domains;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace congress_sucks.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IPostDomain PostDomain { get; set; }

        public List<BlogPost> BlogPosts { get; set; } = new ();

        public IndexModel(ILogger<IndexModel> logger, IPostDomain postDomain )
        {
            PostDomain = postDomain;
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            BlogPosts = await PostDomain.GetGetNewestPostsAsync().ConfigureAwait(false);
        }
    }
}
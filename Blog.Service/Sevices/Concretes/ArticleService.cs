using Blog.Entity.Entities;
using Blog.Service.Sevices.Abstractions;
using Blog.Data.UnitOfWorks.Abstraction;

namespace Blog.Service.Sevices.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Article>> GetAllArticleAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}

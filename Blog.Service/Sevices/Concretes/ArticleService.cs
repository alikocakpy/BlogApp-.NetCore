using Blog.Entity.Entities;
using Blog.Service.Sevices.Abstractions;
using Blog.Data.UnitOfWorks.Abstraction;
using AutoMapper;
using Blog.Entity.DTOs.Articles;

namespace Blog.Service.Sevices.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}

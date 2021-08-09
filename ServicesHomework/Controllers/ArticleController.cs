using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace ServicesHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IAddContentService _addContent;
        private readonly ICheckArticleService _checkArticle;
        private readonly IPublishArticleService _publishArticle;

        public ArticleController(IAddContentService addContent, ICheckArticleService checkArticle, IPublishArticleService publishArticle)
        {
            _addContent = addContent;
            _checkArticle = checkArticle;
            _publishArticle = publishArticle;
        }

        [HttpGet("{property}")]
        public void CheckArticle(string property)
        {
            _checkArticle.CheckArticle(property);
        }

        [HttpPost]
        public void PublishArticle(string content)
        {
            _addContent.AddContent(content);
            _publishArticle.PublishArticle();
        }
    }
}

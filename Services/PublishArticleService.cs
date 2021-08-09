using System;
using Interfaces;

namespace Services
{
    public class PublishArticleService : IPublishArticleService
    {
        private readonly ISaveInfoService _saveInfo;
        private readonly IUploadArticleService _uploadArticle;

        public PublishArticleService(ISaveInfoService saveInfo, IUploadArticleService uploadArticle)
        {
            _saveInfo = saveInfo;
            _uploadArticle = uploadArticle;
        }

        public void PublishArticle()
        {
            _saveInfo.SaveInfo();
            _uploadArticle.UploadArticle();
            Console.WriteLine("Published article");
        }
    }
}

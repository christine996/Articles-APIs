using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskAPIs1.Models;

namespace TaskAPIs1.Controllers
{
    public class ArticlesApiController : ApiController
    {
        [HttpGet]
        [Route("api/getAllArticles")]
        public object getAllArticles()
        {


            using (var context = new DB_USERSEntities())
            {
                var articles = (from a in context.Articles

                                select new
                                {
                                    Id = a.Id,
                                    articleName = a.ArticleName,
                                    articleCategory = a.ArticleCategory,
                                    articleContent = a.ArticleContent,
                                    articleComment = a.Comments,
                                    commentApproval = a.commentApproval,
                                    Reason = a.Reason

                                }).ToArray();
                return Json(articles);
            }
        }


        [HttpPost]
        [Route("api/addArticle")]
        public object addArticle([FromBody] ArticlesViewModel model)
        {


            using (var context = new DB_USERSEntities())
            {
                try
                {
                    var article = new Article
                    {
                        ArticleName = model.ArticleName,
                        ArticleCategory = model.ArticleCategory,
                        ArticleContent = model.ArticleContent,
                        Comments = model.Comments


                    };
                    context.Articles.Add(article);
                    context.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

            }
        }

        [HttpPost]
        [Route("api/editArticle")]
        public object editArticle([FromBody] ArticlesViewModel model)
        {


            using (var context = new DB_USERSEntities())
            {
                try
                {
                    var article = context.Articles.First(a => a.Id == model.Id);

                    if (article != null)
                    {



                        article.ArticleName = model.ArticleName;
                        article.ArticleCategory = model.ArticleCategory;
                        article.ArticleContent = model.ArticleContent;
                        article.Comments = model.Comments;




                    }

                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

            }
        }
        [HttpPost]
        [Route("api/addComment")]
        public object addComment([FromBody] ArticlesViewModel model)
        {


            using (var context = new DB_USERSEntities())
            {
                try
                {
                    var article = context.Articles.First(a => a.Id == model.Id);

                    if (article != null)
                    {

                        article.Comments = model.Comments;

                    }

                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

            }
        }
        [HttpPost]
        [Route("api/commentApproval")]
        public object commentApproval([FromBody] ArticlesViewModel model)
        {


            using (var context = new DB_USERSEntities())
            {
                try
                {
                    var article = context.Articles.First(a => a.Id == model.Id);

                    if (article != null)
                    {

                        article.Comments = model.Comments;
                        article.commentApproval = model.commentApproval;
                        article.Reason = model.Reason;

                    }

                    context.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest);
                }

            }
        }
    }
}

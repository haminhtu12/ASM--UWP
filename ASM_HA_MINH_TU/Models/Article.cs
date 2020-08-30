using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ASM_HA_MINH_TU.Models.Article;

namespace ASM_HA_MINH_TU.Models
{
    public enum NewsCategory
    {
        TinMoiNhat,
        TheThao,
        KinhTe,
        GiaiTri,
        XemNhieuNhat
    }

    public class Article
    {
        public string title { get; set; }
        public string description { get; set; }
        public string ImageFile { get; set; }
        public NewsCategory Category { get; set; }

        public Article(string title,string description, NewsCategory category)
        {
            this.title = title;
            this.description = description;
            Category = category;
            ImageFile = String.Format("/Assets/Images/{0}/{1}.jpg", category, title);

        }
    }

    public class ArticleManager
    {
        public static List<Article> getArticles()
        {
            var articles = new List<Article>();

            articles.Add(new Article("messi", "Messi muốn rời Barca từ vài tháng trước",   NewsCategory.TheThao));
            articles.Add(new Article("aoden", "Vua áo đen” trong lịch sử bóng đá thế giới", NewsCategory.TheThao));
            articles.Add(new Article("san", "Top 10 sân vận động lớn nhất ở châu Á", NewsCategory.TheThao));
            articles.Add(new Article("newer", "Neuer cắt lưới ăn mừng chức vô địch Champions League", NewsCategory.TheThao));
            articles.Add(new Article("caulong", "Hot girl cầu lông Việt Nam giành ngôi Á quân trên đất Áo", NewsCategory.TheThao));
            articles.Add(new Article("manc", "Man City vô địch Cúp Liên đoàn Anh 2020", NewsCategory.TheThao));



            return articles;

        }
        public static void GetAllArticles(ObservableCollection<Article> articles)
        {
            List<Article> allarticle = getArticles();
            articles.Clear();
            allarticle.ForEach(p => articles.Add(p));


        }
        public static void GetArticleByCategory(ObservableCollection<Article> articles, NewsCategory newsCategory)
        {
            var allarticle = getArticles();
            var filetedArticles = allarticle.Where(p => p.Category == newsCategory).ToList();
        }
        public static void GetSoundByname(ObservableCollection<Article> articles, string title)
        {
            var allarticle = getArticles();
            var filetedArticles = allarticle.Where(p => p.title == title).ToList();
            articles.Clear();
            filetedArticles.ForEach(p => articles.Add(p));
        }
    }
    public class MenuItem
    {
        public string ImageFile { get; set; }
        public NewsCategory Category { get; set; }
    }

}

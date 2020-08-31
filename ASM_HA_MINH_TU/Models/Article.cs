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
        TheThao,
        KinhTe,
        GiaiTri,
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

            articles.Add(new Article("kc", "Chadwick Boseman - chiến binh kiên cường", NewsCategory.GiaiTri));
            articles.Add(new Article("hoahau", "Hoa hậu Cộng hòa Dominica đeo khẩu trang nhận vương miện", NewsCategory.GiaiTri));
            articles.Add(new Article("vnjl", "Nhan sắc Hoa hậu Trái đất Venezuela 2020", NewsCategory.GiaiTri));
            articles.Add(new Article("aodai", "Áo dài của Trương Thị May được đấu giá 220 triệu đồng", NewsCategory.GiaiTri));
            articles.Add(new Article("agl", "Angelina Jolie chuộng khẩu trang sản xuất ở Việt Nam", NewsCategory.GiaiTri));
            articles.Add(new Article("cd", "Chân dung văn nghệ sĩ một thời", NewsCategory.GiaiTri));



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
            List<Article> allarticle = getArticles();
            var filetedArticles = allarticle.Where(p => p.Category == newsCategory).ToList();
            filetedArticles.ForEach(p => articles.Add(p));

        }
        public static void GetArticleByname(ObservableCollection<Article> articles, string title)
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

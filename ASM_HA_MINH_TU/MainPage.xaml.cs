using ASM_HA_MINH_TU.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static ASM_HA_MINH_TU.Models.Article;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ASM_HA_MINH_TU
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string title = "haha";
        private ObservableCollection<Article> ArticleTheThao;
        private ObservableCollection<Article> ArticleGiaiTri;
        private ObservableCollection<Article> ArticleKinhTe;
        private List<MenuItem> MenuIems;
        private List<String> Suggestions;

        public MainPage()
        {
            this.InitializeComponent();
            ArticleTheThao = new ObservableCollection<Article>();
            ArticleGiaiTri = new ObservableCollection<Article>();
            ArticleKinhTe = new ObservableCollection<Article>();
            ArticleManager.GetArticleByCategory(ArticleTheThao, NewsCategory.TheThao );
            ArticleManager.GetArticleByCategory(ArticleGiaiTri, NewsCategory.GiaiTri);
            ArticleManager.GetArticleByCategory(ArticleKinhTe, NewsCategory.KinhTe);
            MenuIems = new List<MenuItem>();
            MenuIems.Add(new MenuItem { ImageFile = "Assets/Images/thethao/1.jpg", Category = NewsCategory.TheThao });
            MenuIems.Add(new MenuItem { ImageFile = "Assets/Images/thethao/2.jpg", Category = NewsCategory.TheThao });
            MenuIems.Add(new MenuItem { ImageFile = "Assets/Images/thethao/3.jpg", Category = NewsCategory.TheThao });
            MenuIems.Add(new MenuItem { ImageFile = "Assets/Images/thethao/4.jpg", Category = NewsCategory.TheThao });
        }

        private void toggleSwitch2_Toggled(object sender, RoutedEventArgs e)
        {
            // create a new toggle switch item from sender object
            ToggleSwitch toggleSwitch2 = sender as ToggleSwitch;

            // if the toggle switch exists
            if (toggleSwitch2 != null)
            {
                // if toggle switch is on, change to light theme
                if (toggleSwitch2.IsOn == true)
                {
                    rootPivot.Background = new SolidColorBrush(Colors.DarkGray);
                    stackpanel.Background = new SolidColorBrush(Colors.DarkGray);
                    stackpanel2.Background = new SolidColorBrush(Colors.DarkGray);
                    stackpanel3.Background = new SolidColorBrush(Colors.DarkGray);
                    stackpanel4.Background = new SolidColorBrush(Colors.DarkGray);

                }
                // if not, change to dark theme
                else
                {
                    rootPivot.Background = new SolidColorBrush(Colors.MidnightBlue);
                    stackpanel.Background = new SolidColorBrush(Colors.MidnightBlue);
                    stackpanel2.Background = new SolidColorBrush(Colors.MidnightBlue);
                    stackpanel3.Background = new SolidColorBrush(Colors.MidnightBlue);
                    stackpanel4.Background = new SolidColorBrush(Colors.MidnightBlue);
                }


            }
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {

        }

        private void SearchKeyword_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }
    }
}

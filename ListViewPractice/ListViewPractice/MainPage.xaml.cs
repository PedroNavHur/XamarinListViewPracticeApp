using ListViewPractice.Models;
using ListViewPractice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewPractice
{
    public partial class MainPage : ContentPage
    {

        private SearchService searchService;
        private List<SearchGroup> searchGroups;


        public MainPage()
        {
            searchService = new SearchService();



            InitializeComponent();

            PopulateListView(searchService.GetSearches());
        }

        private void OnSearchTextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            PopulateListView(searchService.GetSearches(e.NewTextValue));
        }

        private void PopulateListView(IEnumerable<Search> searches)
        {
            searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Busquedas Recientes", searches)
            };

            placesListView.ItemsSource = searchGroups;

        }

        private void OnRefreshing(object sender, System.EventArgs e)
        {
            PopulateListView(searchService.GetSearches(searchBar.Text));

            placesListView.EndRefresh();
        }


    }
}

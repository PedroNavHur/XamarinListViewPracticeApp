using ListViewPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListViewPractice.Service
{
    public class SearchService
    {

        List<Search> searches = new List<Search> {
            new Search
            {
                Id = 0,
                Location = "San Juan del Sur",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31)
            },
            new Search
            {
                Id = 1,
                Location = "San Juan del Norte",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 2,
                Location = "Playa la Flor",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 3,
                Location = "Playa Maderas",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 4,
                Location = "Playa Majagual",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 5,
                Location = "Playa Marsella",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 6,
                Location = "Playa Ocosme",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 7,
                Location = "Playa Mechapa",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
            new Search
            {
                Id = 8,
                Location = "Playa Santa maria",
                CheckIn = new DateTime(2017, 12, 24),
                CheckOut = new DateTime(2017, 12, 31) },
        };

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return searches;

            return searches.Where(s => s.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }

        void DeleteSearch(int searchId)
        {
            searches.Remove(searches.Single(s => s.Id == searchId));
        }
    }
}

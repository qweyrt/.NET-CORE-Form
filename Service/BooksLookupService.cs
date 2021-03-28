using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Ctrlr.Service
{
    public class BooksLookupService
    {
        public List<string> GetGenres()
        {
            return new List<string>()
            {
                "Fiction",
                "Thriller",
                "Comedy",
                "Autobiography"

            };
        }
    }
}
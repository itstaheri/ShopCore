using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Application.Contract.ArticleCategory
{
    public class ArticleCategoryViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CreateionDate { get; set; }
        public bool IsRemoved { get; set; }
        public long ArticleCount { get; set; }
    }
}

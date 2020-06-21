using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.BookStore.Application.Contracts.Blog
{
    public class QueryCategoryDto : CategoryDto
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Count { get; set; }
    }
}

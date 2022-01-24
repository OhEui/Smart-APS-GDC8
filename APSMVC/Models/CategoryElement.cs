using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APSMVC.Models
{
    public class CategoryElement
    {
        public string category { get; set; }
        public CategoryElement(string category)
        {
            this.category = category;
        }
    }
}
using DotNetCoreDemos.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreDemos.MyHelper
{
    [HtmlTargetElement("category-list")]
    public class CategoryTagHelper:TagHelper
    {
        List<Category> categories;
        public CategoryTagHelper()
        {
            categories = new List<Category>
            {
                new Category{Id=1,Name="Programlama"},
                new Category{Name="Yapay Zeka",Id=2},
                new Category{Id=3,Name   ="Tasarım"}
            };
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            StringBuilder strHtml = new StringBuilder();


            foreach (var item in categories)
            {
                strHtml.AppendFormat($"<h2> <a href='/employee/detail/{item.Id}'>{item.Name}</a>  </h2>");
            }

            output.Content.SetHtmlContent(strHtml.ToString());

            base.Process(context, output);
        }

    }

}

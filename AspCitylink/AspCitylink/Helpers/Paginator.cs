using AspCitylink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AspCitylink.Helpers
{
    public static class  Paginator
    {
        // бюджетная версия
        public static MvcHtmlString PageLinks(this HtmlHelper html, int count)
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                sb.AppendFormat("<a href=\"Page{0}\">{0}</a>",i);
            }

            return new MvcHtmlString(sb.ToString());
        }

        // продвинутая
        public static MvcHtmlString PageLinksBootstrap(this HtmlHelper html, PageModel model)
        {
            // пагинация в стиле Bootstrap 3.0
            var tagUl = new TagBuilder("ul");
            tagUl.AddCssClass("pagination"); // <ul class="pagination"></ul>

            var sb = new StringBuilder();
            for (int i = 1; i <= model.PageCount; i++)
            {
                var tagLi = new TagBuilder("li"); // <li></li>

                var tagA = new TagBuilder("a"); // <a></a>
                tagA.MergeAttribute("href", $"Page{i}"); // <a href="Page1"></a>
                tagA.InnerHtml = i+""; // <a href="Page1"> 1 </a>

                tagLi.InnerHtml = tagA.ToString();

                if (i == model.ActivePage)
                {
                    tagLi.AddCssClass("active");
                }

                sb.Append(tagLi.ToString());
            }

            tagUl.InnerHtml = sb.ToString();

            return new MvcHtmlString(tagUl.ToString());
        }

        public static MvcHtmlString PageLinksAdvanced(this HtmlHelper html, PageModel model)
        {
            // пагинация в стиле Bootstrap 3.0
            var tagUl = new TagBuilder("ul");
            tagUl.AddCssClass("pagination"); // <ul class="pagination"></ul>

            int left = model.ActivePage-5 <= 0 
                ? 1 
                : model.ActivePage - 5;

            int right = model.ActivePage+5 > model.PageCount 
                ? model.PageCount
                : model.ActivePage + 5;

            var sb = new StringBuilder();

            if (left > 1)
                sb.Append(GenerateLink(1, model));

            for (int i = left; i <= right; i++)
            {
                sb.Append(GenerateLink(i, model));
            }

            if (right < model.PageCount)
                sb.Append(GenerateLink(model.PageCount, model));

            tagUl.InnerHtml = sb.ToString();

            return new MvcHtmlString(tagUl.ToString());
        }

        private static string GenerateLink(int i, PageModel model)
        {
            var tagLi = new TagBuilder("li"); // <li></li>

            var tagA = new TagBuilder("a"); // <a></a>
            tagA.MergeAttribute("href", $"/{model.ActiveCategoryName}/Page{i}"); // <a href="Page1"></a>
            tagA.InnerHtml = $"{i:d2}"; // <a href="Page1"> 1 </a>

            tagLi.InnerHtml = tagA.ToString();

            if (i == model.ActivePage)
            {
                tagLi.AddCssClass("active");
            }

            return tagLi.ToString();
        }
    }
}
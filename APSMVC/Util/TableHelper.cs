using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace APSMVC
{
    public static class TableHelper
    {
        public static HtmlString Table(this HtmlHelper helper, List<List<string>> data, List<string> headers, string htmlClass= null)
        {
            //Tags
            TagBuilder table = new TagBuilder("table");
            TagBuilder tr = new TagBuilder("tr");
            TagBuilder td = new TagBuilder("td");
            TagBuilder th = new TagBuilder("th");
            TagBuilder thead = new TagBuilder("thead");
            TagBuilder tbody = new TagBuilder("tbody");

            //Inner html of table
            StringBuilder sb = new StringBuilder();

            if (htmlClass != null) 
                table.MergeAttribute("class", htmlClass);


            //Add headers
            foreach (var s in headers)
            {
                th.InnerHtml = s;               // <th> s </th>
                tr.InnerHtml += th.ToString(); // <tr> <th> ... </tr>
            }

            thead.InnerHtml = tr.ToString(); // <thead> <tr> ... </thead>
            sb.Append(thead.ToString()); 
            
            //Add data
            foreach (var d in data)
            {
                tr.InnerHtml = ""; // <tr> </tr>
                foreach (var h in d)
                {
                    td.InnerHtml = h; // <td> data </td>
                    tr.InnerHtml += td.ToString(); // <tr> <td> ... </tr>
                }
                tr.Attributes.Clear();
                tr.MergeAttribute("class", $"testClass");
                tr.MergeAttribute("id", $"{d.First()}");
                tbody.InnerHtml += tr.ToString(); // <tbody> <tr> ... </tbody>
            }

            sb.Append(tbody.ToString());
            table.InnerHtml = sb.ToString();
            return new HtmlString(table.ToString());
        }

        public static HtmlString Table(this HtmlHelper helper, List<List<string>> data, string htmlClass = null)
        {
            List<string> headers = data.First();
            List<List<string>> body = data.Skip(1).ToList();
            return Table(helper, body, headers, htmlClass);
        }
    }
}
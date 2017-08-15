using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using DaSite.Models;


namespace DaSite.Helpers
{
    public static class ProfileViewHelper
    {
        public static HtmlString VeiwerPhotoSchedule(this HtmlHelper helper, string id)
        {
            var builder = new TagBuilder("table");

            StringBuilder innerHtml = new StringBuilder();

            builder.GenerateId(id);
            builder.AddCssClass("profileimages");

            if (HttpContext.Current.Session["pId"] != null)
            {
                //get target's id from db
                var pId = HttpContext.Current.Session["pId"];

                //get target's photos
                var db = new ApplicationDbContext();
                var items = db.Photos.Where(i => i.EmailId == (string)pId);

                innerHtml.Append("<tbody>");
                innerHtml.Append("<tr>");

                //html append each photo
                foreach (var item in items)
                {
                    innerHtml.Append("<th id='" + item.PathId + "' class='image-thumb' onclick=\"selected('" + item.PathId + "')\"  data-target='#imgModal' data-toggle='modal' style='float: left; margin - bottom: 15px; padding - left: 24px;' >");
                    innerHtml.Append("<img src='/Content/" + item.PathId + "' width='110' height='110' style='padding: 20px;'>");
                    innerHtml.Append("</th>");
                }

                innerHtml.Append("</tr>");
                innerHtml.Append("</tbody>");
            }
            else
            {
                innerHtml.Append("<i>Error - No items to display...</i>");
            }
            builder.InnerHtml = innerHtml.ToString();
            return new HtmlString(builder.ToString());
        }
    }
}
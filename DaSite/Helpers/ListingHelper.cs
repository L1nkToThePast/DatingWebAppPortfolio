using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using DaSite.Models;
using System.Collections.Generic;


namespace DaSite.Helpers
{
    public static class ListingHelper
    {
        public static HtmlString ListingSchedule(this HtmlHelper helper, string id)
        {
            var builder = new TagBuilder("div");
            StringBuilder innerHtml = new StringBuilder();

            builder.GenerateId(id);
            builder.AddCssClass("userimages");


            //get photos from db
            var userId = HttpContext.Current.Session["UserId"];

            //get user photos
            var db = new ApplicationDbContext();

            var User = db.Users.FirstOrDefault(i => i.Id == (string)userId);

            //var items = db.Users;

            IQueryable<ApplicationUser> userList;

            if (HttpContext.Current.Session["UserId"] == null)
            {
                userList = db.Users;
             }
             else
             {
                 //if user is signed in , match results to a their region
                 userList = db.Users.Where(i => i.Country == User.Country);
              }

            if (userList.Any() == true)
            {
                foreach (var item in userList)
                {
                    //html appends
                    innerHtml.Append("<a href=\"/Home/ViewProfile?profileID=" + item.Id + "\">");

                    if (item.ProfilePic == null && item.Gender == "Male")
                        innerHtml.Append("<img src='/Content/blankm.png' width='110' height='110' style='padding: 20px;'>");
                    else if (item.ProfilePic == null && item.Gender == "Female")
                        innerHtml.Append("<img src='/Content/blankf.png' width='110' height='110' style='padding: 20px;'>");
                    else
                        innerHtml.Append("<img src='/Content/" + item.ProfilePic + "' width='110' height='110' style='padding: 20px;'>");

                    innerHtml.Append("</a>");
                }
            }
            else
            {
                innerHtml.Append("<i>Error - No user in the DB, Please make some...</i>");
            }

            
            builder.InnerHtml = innerHtml.ToString();
            return new HtmlString(builder.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dev_Card___Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev_Card___Mvc.View_Component
{
    public class ProjectViewComponenet : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id : 1 ,name : "پروژه فروشگاه ماشین" , description : "این فروشگاه برای فروش ماشین های لوکس و مدرن و مدل بالا  و با پرفورمنس خیلی بالا است که میتوانیم از آن استفاده کنیم...", client :"ایمان مدائنی" ),
                new Project(id : 2 ,name : "پروژه قالب فروشی" , description : "این فروشگاه برای فروش ماشین های لوکس و مدرن و مدل بالا  و با پرفورمنس خیلی بالا است که میتوانیم از آن استفاده کنیم...", client :"علی برجی" ),
                new Project(id : 3 ,name : "پروژه گلدان فروشی " , description : "این فروشگاه برای فروش ماشین های لوکس و مدرن و مدل بالا  و با پرفورمنس خیلی بالا است که میتوانیم از آن استفاده کنیم...", client :"حسین احمدی" ),
                new Project(id : 4 ,name : "پروژه مشاور املاک" , description : "این فروشگاه برای فروش ماشین های لوکس و مدرن و مدل بالا  و با پرفورمنس خیلی بالا است که میتوانیم از آن استفاده کنیم...", client :"ایمان پندی" ),

            };

            return View("_Project2", projects);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemoPage.Models;
namespace MVCDemoPage.Controllers
{
    public class HomeController : Controller
    {
        List<Order> list = new List<Order> 
        {
           new Order{Id=1,OrderNo="2016050501",WayFee =20,EMS="C01111"},
           new Order{Id=2,OrderNo="2016050502",WayFee =10,EMS="C01112"},
           new Order{Id=3,OrderNo="2016050503",WayFee =10,EMS="C01112"},
           new Order{Id=4,OrderNo="2016050504",WayFee =10,EMS="C01112"},
           new Order{Id=5,OrderNo="2016050505",WayFee =10,EMS="C01112"},
           new Order{Id=6,OrderNo="2016050506",WayFee =10,EMS="C01112"},
        };
        private const int PageSize = 2;
        private int count;
        public ActionResult Index(int pageIndex = 0)
        {
            count = list.Count();
            list = list.Skip(PageSize * pageIndex).Take(PageSize).ToList();
            PageOfList<Order> _orderList = new PageOfList<Order>(list, pageIndex, PageSize, count);
            return View(_orderList);
        }
	}
}
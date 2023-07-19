using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.JSInterop;
using ShopApp.Models.Design;

namespace ShopApp.Data.Process
{
    public class MenuProcess
    {
        public static List<MenuItem> GetMenu()
        {
            ShopAppDBContext database = new ShopAppDBContext();
            var AllMenuItems = database.Menu.ToList();
            var suns = AllMenuItems.Where(x => x.FatherId != null).ToList();
            var fathers = AllMenuItems.Where(x => x.FatherId == null).ToList();
            foreach (var father in fathers)
            {
                father.Suns = new List<MenuItem>();
                foreach (var sun in suns)
                {
                    if (sun.FatherId == father.Id)
                    {
                        father.Suns.Add(sun);
                    }
                }
            }
            List<MenuItem> result = (from item in AllMenuItems
                                     join father in fathers
                                     on item.Id equals father.Id
                                     select new MenuItem
                                     {
                                         Classes = father.Classes,
                                         Id = father.Id,
                                         Path = father.Path,
                                         Title = father.Title,
                                         Suns = father.Suns.OrderBy(x => x.Index).ToList(),
                                     }).OrderBy(x => x.Index).ToList();

            return result;
        }

        public static List<MenuItem> GetDefaultData()
        {
            var db = new ShopAppDBContext();
            List<MenuItem> menu = new List<MenuItem>
            {
                new MenuItem
                {
                    Title="خانه",
                    Classes="fa-regular fa-house",
                    Path="/Admin/Index",
                    Index=0,
                },new MenuItem
                {
                    Title="محصولات",
                    Classes="fa-regular fa-shop",
                    Index=1,
                    Suns=new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Title="فهرست",
                            Path="/Admin/Products/Index",
                            Index=0,
                            FatherId=2,
                        },new MenuItem
                        {
                            Title="افزودن",
                            Path="/Admin/Products/Create",
                            Index=1,
                            FatherId=2,
                        },
                    }
                },new MenuItem
                {
                    Title="دسته‌بندی ها",
                    Classes="fa-regular fa-layer-group",
                    Index=2,
                    Suns=new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Title="فهرست",
                            Path="/Admin/Categories/Index",
                            Index=0,
                            FatherId=5,
                        },new MenuItem
                        {
                            Title="افزودن",
                            Path="/Admin/Categories/Create",
                            Index=1,
                            FatherId=5,
                        },

                    }
                },new MenuItem
                {
                    Title="کاربران",
                    Classes="fa-regular fa-users",
                    Index=3,
                    Suns=new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Title="فهرست",
                            Path="/Admin/Users/Index",
                            Index=0,
                            FatherId=8,
                        },new MenuItem
                        {
                            Title="افزودن",
                            Path="/Admin/Users/Create",
                            Index=1,
                            FatherId=8,
                        },

                    }
                },new MenuItem
                {
                    Title="برچسب‌ها",
                    Classes="fa-regular fa-hashtag",
                    Path="/Admin/Tags/Index",
                    Index=4,
                },new MenuItem
                {
                    Title="نظرات",
                    Classes="fa-regular fa-hashtag",
                    Index=5,
                    Suns=new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Title="فهرست",
                            Path="/Admin/Comments/Index",
                            Index=0,
                            FatherId=12,
                        },new MenuItem
                        {
                            Title="بررسی",
                            Path="/Admin/Comments/Check",
                            Index=1,
                            FatherId=12,
                        },


                    }
                },new MenuItem
                {
                    Title="سفارشات",
                    Classes="fa-brands fa-shopify",
                    Index=6,
                    Suns=new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Title="فهرست",
                            Path="/Admin/Orders/Index",
                            Index=0,
                            FatherId=15,
                        },new MenuItem
                        {
                            Title="بررسی",
                            Path="/Admin/Orders/Recent",
                            Index=1,
                            FatherId=15,
                        },new MenuItem
                        {
                            Title="افزودن",
                            Path="/Admin/Orders/Create",
                            Index=2,
                            FatherId=15,
                        },
                    }
                },new MenuItem
                {
                    Title="منو",
                    Classes="fa-regular fa-square-list",
                    Index=7,
                    Suns=new List<MenuItem>
                    {
                        new MenuItem
                        {
                            Title="منوی کاربران",
                            Path="/Admin/Menu/User",
                            Index=0,
                            FatherId=19,
                        },new MenuItem
                        {
                            Title="منوی ادمین",
                            Path="/Admin/Menu/Admin",
                            Index=1,
                            FatherId=19,
                        }
                    }
                }
            };
            return menu;
        }
    }
}

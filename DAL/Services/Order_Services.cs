using DAL.DTOs;
using DAL.Migrations;
using DAL.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using static DAL.Services.Order_Services;

namespace DAL.Services
{
    public class Order_Services
    {

        public Order_Services() { }

        public void Insert(Order order, long UserID)
        {
            DB db = new DB();
            Random random = new Random();

            List<string> codeFactors = db.orders.Select(x => x.Order_Code).ToList();

            string Code = Convert.ToString(random.Next(10000000, 100000000));


            Order Model = new Order()
            {
                Device_Type = order.Device_Type,
                Brand = order.Brand,
                Address = order.Address,
                Order_Desc = order.Order_Desc,
                Order_PhoneNumber = order.Order_PhoneNumber,
                Order_Request_Date = Helpers.TimeUtility.ToJalali(DateTime.Now),
                Order_State = (int)EorderState.Baarasi,
                State = order.State,
                User_ID = UserID,
                BuildServiceType = order.BuildServiceType,
                OrderType = order.OrderType,



            };

            string FinalCode = Code.Replace(Code.Substring(0, 4), Model.Order_Request_Date);


            if (!codeFactors.Any(k => k == FinalCode))
            {
                Model.Order_Code = FinalCode;
            }
            else
            {
                Model.Order_Code = FinalCode + "Du";
            }


            db.orders.Add(Model);
            db.SaveChanges();
            db.user_Orders.Add(new Models.User_Order
            {
                Order_ID = db.orders.Where(x => x.Order_Code == Model.Order_Code).Select(x => x.Order__ID).FirstOrDefault(),
                User_ID = Model.User_ID,
            });
            db.SaveChanges();
        }
        public void Delete(Order order)
        {
            DB db = new DB();
            Models.User_Order orderUsers = db.user_Orders.Where(x => x.Order_ID == order.Order__ID).Single();

            db.orders.Remove(order);
            db.user_Orders.Remove(orderUsers);
            db.SaveChanges();
        }
        public void Edit(Order order)
        {
            DB db = new DB();
            db.orders.Update(order);
            db.SaveChanges();

        }
        public DTOs.OrderViewModel GetOrder(long OrderID)
        {
            DB db = new DB();
            Models.User_Order orderUsers = db.user_Orders.Where(x => x.Order_ID == OrderID).FirstOrDefault();
            User user = db.users.Where(x => x.User__ID == orderUsers.User_ID).FirstOrDefault();

            return db.orders.Where(x => x.Order__ID == OrderID).Select(x => new OrderViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = x.Address,
                State = x.State,
                Order__ID = x.Order__ID,
                User_ID = user.User__ID,
                PhoneNumber = user.PhoneNumber,
                Order_State = x.Order_State,
                Order_Request_Date = x.Order_Request_Date,
                Order_Repair_Date = x.Order_Repair_Date,
                Order_PhoneNumber = x.Order_PhoneNumber,
                Order_Desc = x.Order_Desc,
                Order_Code = x.Order_Code,
                Brand = x.Brand,
                Email = user.Email,
                Device_Type = x.Device_Type,
                Device_Type_Desc = x.Device_Type > 0 ? HomeService().Where(k => k.Id == x.Device_Type).Select(x => x.Desc).FirstOrDefault() : string.Empty,
                Brand_Desc = Brand().Where(k => k.Id == x.Brand).Select(x => x.Desc).FirstOrDefault(),
                BuildServiceType = x.BuildServiceType,
                BuildServiceType_Desc = x.BuildServiceType > 0 ? BuildService().Where(k => k.Id == x.BuildServiceType).Select(x => x.Desc).FirstOrDefault() : string.Empty,
                Order_State_Desc = OrderState().Where(k => k.Id == x.Order_State).Select(x => x.Desc).FirstOrDefault(),
                OrderType = x.OrderType,
                OrderType_Desc = OrderType().Where(k => k.Id == x.OrderType).Select(x => x.Desc).FirstOrDefault(),
                Instagram = user.Instagram,
                JoinDate = user.JoinDate,
            }).FirstOrDefault();
        }
        public List<DTOs.OrderViewModel> GetOrders(long UserID)
        {
            DB db = new DB();
            Models.User_Order orderUsers = db.user_Orders.Where(x => x.User_ID == UserID).FirstOrDefault();
            User user = db.users.Where(x => x.User__ID == UserID).FirstOrDefault();
            List<Order> orders = db.orders.Where(x => x.User_ID == UserID).ToList();

            bool IsCheck = db.orders.Where(x => x.User_ID == UserID).Any();

            if (IsCheck)
            {
                List<OrderViewModel> OrderView = new List<OrderViewModel>();

                foreach (var i in orders)
                {
                    OrderView.Add(new OrderViewModel
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Address = i.Address,
                        State = i.State,
                        Order__ID = i.Order__ID,
                        User_ID = user.User__ID,
                        PhoneNumber = user.PhoneNumber,
                        Order_State = i.Order_State,
                        Order_Request_Date = i.Order_Request_Date,
                        Order_Repair_Date = i.Order_Repair_Date,
                        Order_PhoneNumber = i.Order_PhoneNumber,
                        Order_Desc = i.Order_Desc,
                        Order_Code = i.Order_Code,
                        Brand = i.Brand,
                        Email = user.Email,
                        Device_Type = i.Device_Type,
                        Device_Type_Desc = i.Device_Type > 0 ? HomeService().Where(k => k.Id == i.Device_Type).Select(i => i.Desc).FirstOrDefault() : string.Empty,
                        Brand_Desc = Brand().Where(k => k.Id == i.Brand).Select(i => i.Desc).FirstOrDefault(),
                        BuildServiceType = i.BuildServiceType,
                        BuildServiceType_Desc = i.BuildServiceType > 0 ? BuildService().Where(k => k.Id == i.BuildServiceType).Select(i => i.Desc).FirstOrDefault() : string.Empty,
                        Order_State_Desc = OrderState().Where(k => k.Id == i.Order_State).Select(i => i.Desc).FirstOrDefault(),
                        OrderType = i.OrderType,
                        OrderType_Desc = OrderType().Where(k => k.Id == i.OrderType).Select(x => x.Desc).FirstOrDefault(),
                        Instagram = user.Instagram,
                        JoinDate = user.JoinDate,

                    });

                }
                return OrderView;
            }
            return new List<OrderViewModel>();




        }
        public List<DTOs.OrderViewModel> GetViewModelList()
        {
            DB db = new DB();

            List<Order> orders = db.orders.ToList();

            List<OrderViewModel> OrderView = new List<OrderViewModel>();

            foreach (var i in orders)
            {
                Models.User_Order orderUsers = db.user_Orders.Where(x => x.Order_ID == i.Order__ID).FirstOrDefault();
                if (orderUsers != null)
                {
                    User user = db.users.Where(x => x.User__ID == orderUsers.User_ID).FirstOrDefault();
                    bool IsCheck = db.orders.Where(x => x.User_ID == user.User__ID).Any();
                    if (IsCheck)
                    {
                        OrderView.Add(new OrderViewModel
                        {
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Address = i.Address,
                            State = i.State,
                            Order__ID = i.Order__ID,
                            User_ID = user.User__ID,
                            PhoneNumber = user.PhoneNumber,
                            Order_State = i.Order_State,
                            Order_Request_Date = i.Order_Request_Date,
                            Order_Repair_Date = i.Order_Repair_Date,
                            Order_PhoneNumber = i.Order_PhoneNumber,
                            Order_Desc = i.Order_Desc,
                            Order_Code = i.Order_Code,
                            Brand = i.Brand,
                            Email = user.Email,
                            Device_Type = i.Device_Type,
                            Device_Type_Desc = i.Device_Type > 0 ? HomeService().Where(k => k.Id == i.Device_Type).Select(i => i.Desc).FirstOrDefault() : string.Empty,
                            Brand_Desc = Brand().Where(k => k.Id == i.Brand).Select(i => i.Desc).FirstOrDefault(),
                            BuildServiceType = i.BuildServiceType,
                            BuildServiceType_Desc = i.BuildServiceType > 0 ? BuildService().Where(k => k.Id == i.BuildServiceType).Select(i => i.Desc).FirstOrDefault() : string.Empty,
                            Order_State_Desc = OrderState().Where(k => k.Id == i.Order_State).Select(i => i.Desc).FirstOrDefault(),
                            OrderType = i.OrderType,
                            OrderType_Desc = OrderType().Where(k => k.Id == i.OrderType).Select(x => x.Desc).FirstOrDefault(),
                            Instagram = user.Instagram,
                            JoinDate = user.JoinDate,

                        });

                    }
                }


            }
            return OrderView;
        }
        public int CountOrder()
        {
            DB db = new DB();
            return db.orders.Count();
        }


        public List<DTOs.OrderViewModel> ListOrder()
        {
            DB db = new DB();
            List<Models.User_Order> orderUsers = db.user_Orders.ToList();
            List<OrderViewModel> orders = new List<OrderViewModel>();

            foreach (var i in orderUsers)
            {
                User user = db.users.Where(x => x.User__ID == i.User_ID).FirstOrDefault();

                orders.Add(db.orders.Where(x => x.Order__ID == i.Order_ID).Select(x => new OrderViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = x.Address,
                    State = x.State,
                    Order__ID = x.Order__ID,
                    User_ID = user.User__ID,
                    PhoneNumber = user.PhoneNumber,
                    Order_State = x.Order_State,
                    Order_Request_Date = x.Order_Request_Date,
                    Order_Repair_Date = x.Order_Repair_Date,
                    Order_PhoneNumber = x.Order_PhoneNumber,
                    Order_Desc = x.Order_Desc,
                    Order_Code = x.Order_Code,
                    Brand = x.Brand,
                    Email = user.Email,
                    Device_Type = x.Device_Type,
                    Device_Type_Desc = x.Device_Type > 0 ? HomeService().Where(k => k.Id == x.Device_Type).Select(x => x.Desc).FirstOrDefault() : string.Empty,
                    Brand_Desc = Brand().Where(k => k.Id == x.Brand).Select(x => x.Desc).FirstOrDefault(),
                    BuildServiceType = x.BuildServiceType,
                    BuildServiceType_Desc = x.BuildServiceType > 0 ? BuildService().Where(k => k.Id == x.BuildServiceType).Select(x => x.Desc).FirstOrDefault() : string.Empty,
                    Order_State_Desc = OrderState().Where(k => k.Id == x.Order_State).Select(x => x.Desc).FirstOrDefault(),
                    OrderType = x.OrderType,
                    OrderType_Desc = OrderType().Where(k => k.Id == x.OrderType).Select(x => x.Desc).FirstOrDefault(),
                    Instagram = user.Instagram,
                    JoinDate = user.JoinDate,
                }).FirstOrDefault());
            }

            return orders;
        }
        public List<Order> ListUserOrders(long userID)
        {
            DB db = new DB();
            return db.orders.Where(x => x.User_ID == userID).ToList();
        }


        public enum EorderState
        {
            Baarasi = 0,
            TamaasBaShoma = 1,
            EzzamKarShenas = 2,
            Repair = 3,
            NotRepair = 4,
            DarhaalTamiir = 5

        }


        public enum EOrderType
        {
            Home = 0,
            bulding = 1
        }

        public enum EBrnad
        {
            Snowa = 1,
            LG = 2,
            Absal = 3,
            Samsung = 4,
            Bosch = 5,
            PaakShoma = 6,
            Panasonic = 7,
            Otehr = 8

        }

        //BuildServiceType
        public enum EBuildService
        {
            BarqKeshi = 1,
            LoleKeshiAb = 2,
            LoleKeshiGaz = 3,
            SystemEtfaeeHariq = 4,
            BazSaziDakheli = 5,
        }
        //deviceType
        public enum EHomeService
        {
            KolerGazi = 1,
            KolerAbi = 2,
            LebasShoii = 3,
            YakhChaal = 4,
            ZarfShoii = 5,
            AbSardKon = 6,

        }

        public static List<KeyValClass> OrderState()

        {
            return new List<KeyValClass>()
            {
                new KeyValClass
                {
                    Id=(int)EorderState.Baarasi,
                    Desc=  "در حال برسی درخواست شما"
                },
                new KeyValClass
                {
                    Id=(int)EorderState.TamaasBaShoma,
                    Desc=  "تماس کارشناس با شما"
                },
                new KeyValClass
                {
                  Id=(int)EorderState.EzzamKarShenas,
                  Desc="اعزام کارشناس",

                },
                new KeyValClass
                {
                    Id=(int)(EorderState.Repair),
                    Desc= "تعمیر شده",

                },
                new KeyValClass
                {
                    Id=(int)EorderState.NotRepair,
                    Desc=   "تعمیر نشده"
                },
                new KeyValClass
                {
                    Id=(int)EorderState.DarhaalTamiir,
                    Desc=  "در حال تعمیر"
                }
            };
        }
        public static List<KeyValClass> OrderType()
        {
            return new List<KeyValClass>()
            {
                new KeyValClass
                {
                    Id=(int)EOrderType.Home,
                    Desc="تعمیرات لوازم خانگی"
                },
                new KeyValClass
                {
                    Id=(int)EOrderType.bulding,
                    Desc="تاسیسات ساختمان"
                }
            };
        }
        public static List<KeyValClass> Brand()
        {
            return new List<KeyValClass>()
            {
                new KeyValClass
                {
                    Id=(int)EBrnad.Snowa,
                    Desc="اسنوا"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.LG,
                    Desc="ال جی"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.Samsung,
                    Desc="سامسونگ"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.Bosch,
                    Desc="بوش"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.PaakShoma,
                    Desc="پاکشوما"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.Panasonic,
                    Desc="پاناسونیک"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.Absal,
                    Desc="آبسال"
                },
                new KeyValClass
                {
                    Id=(int)EBrnad.Otehr,
                    Desc="غیره"
                }
            };
        }


        public static List<KeyValClass> BuildService()
        {
            return new List<KeyValClass>()
            {
            new KeyValClass
            {
                Id=(int)EBuildService.BarqKeshi,
                Desc="برق کشی ساختمان"
            },
            new KeyValClass
            {
                Id=(int)EBuildService.LoleKeshiAb,
                Desc="لوله کشی آب"
            },
            new KeyValClass
            {
                Id = (int)EBuildService.LoleKeshiGaz,
                Desc="لوله کشی گاز"
            },
            new KeyValClass
            {
                Id=(int)EBuildService.SystemEtfaeeHariq,
                Desc="سیستم اعلام و اطفا حریق"
            },
            new KeyValClass
            {
                Id=(int)EBuildService.BazSaziDakheli,
                Desc="بازسازی داخلی"
            }
            };
        }

        public static List<KeyValClass> HomeService()
        {
            return new List<KeyValClass>()
            {
                new KeyValClass
                {
                Id=(int)EHomeService.KolerGazi,
                Desc="کولر گازی"
                } ,
                new KeyValClass
                {
                    Id=(int)EHomeService.KolerAbi,
                    Desc="کولر آبی"
                },
                new KeyValClass
                {
                    Id=(int)EHomeService.LebasShoii,
                    Desc="لباسشویی"
                },
                new KeyValClass
                {
                    Id=(int)EHomeService.YakhChaal,
                    Desc="یخچال"
                },
                new KeyValClass
                {
                    Id=(int)EHomeService.ZarfShoii,
                    Desc="ظرفشویی"
                },
                new KeyValClass
                {
                    Id=(int)EHomeService.AbSardKon,
                    Desc = "آب سرد کن"
                }
            };
        }
    }
}






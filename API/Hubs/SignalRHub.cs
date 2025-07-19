using Microsoft.AspNetCore.SignalR;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;

namespace API.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;
        public SignalRHub (ICategoryService categoryService, IProductService productService,IMoneyCaseService moneyCaseService,IOrderService orderService,IMenuTableService menuTableService,
            IBookingService bookingService,INotificationService notificationService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _moneyCaseService = moneyCaseService;
            _orderService = orderService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }

        public static int clientCount { get; set; } = 0;
        public async Task SendStatistic()
        {
            var value = _categoryService.TCategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

            var value2 = _productService.TProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", value2);

            var value3 = _categoryService.TActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);

            var value4 = _categoryService.TPassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);

            var value5 = _productService.TProductCountByCategoryNameDöner();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", value5);

            var value6 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value6);

            var value7 = _productService.TProductPriceAVG();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value7.ToString("0.00") + "₺");

            var value8 = _productService.TMaxProductPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);

            var value9 = _productService.TMinProductPrice();
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);

            var value10 = _productService.TAvgDönerPrice();
            await Clients.All.SendAsync("ReceiveProductAvgPriceByHamburger", value10.ToString("0.00") + "₺");

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = _orderService.TActiveOrders();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00") + "₺");

            var value14 = _moneyCaseService.TTotalMoney();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00") + "₺");

            var value16 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value16);
        }
        public async Task SendProgress()
        {
            var value = _moneyCaseService.TTotalMoney();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value.ToString("0.00") + "₺");

            var value2 = _orderService.TActiveOrders();
            await Clients.All.SendAsync("ReceiveTActiveOrderCount", value2);

            var value3 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value3);

            var value5 = _productService.TProductPriceAVG();
            await Clients.All.SendAsync("ReceiveProductPriceAvg", value5);

            var value6 = _productService.TAvgDönerPrice();
            await Clients.All.SendAsync("ReceiveAvgPriceByHamburger", value6);

            var value7 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value7);

            var value8 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value8);

            //var value9 = _productService.TProductPriceBySteakBurger();
            //await Clients.All.SendAsync("ReceiveProductPriceBySteakBurger", value9);

            //var value10 = _productService.TTotalPriceByDrinkCategory();
            //await Clients.All.SendAsync("ReceiveTotalPriceByDrinkCategory", value10);

            //var value11 = _productService.TTotalPriceBySaladCategory();
            //await Clients.All.SendAsync("ReceiveTotalPriceBySaladCategory", value11);
        }
        public async Task GetBookingList()
        {
            var values = _bookingService.TGetListAll();
            await Clients.All.SendAsync("ReceiveBookingList", values);
        }
        public async Task SendNotification()
        {
            var value = _notificationService.TNotificationCountByStatusFalse();
            await Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);

            var notificationListByFalse = _notificationService.TGetAllNotificationByFalse();
            await Clients.All.SendAsync("ReceiveNotificationListByFalse", notificationListByFalse);
        }
        public async Task GetMenuTableStatus()
        {
            var value = _menuTableService.TGetListAll();
            await Clients.All.SendAsync("ReceiveMenuTableStatus", value);
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}

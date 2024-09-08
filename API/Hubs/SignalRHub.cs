using Microsoft.AspNetCore.SignalR;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Concreate;

namespace API.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
        }
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
            await Clients.All.SendAsync("Receiveproductcountbycategorynamedöner", value5);

            var value6 = _productService.TProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("Receiveproductcountbycategorynamedrink", value6);

            var value7 = _productService.TProductPriceAVG();
            await Clients.All.SendAsync("Receiveproductpriceavg", value7.ToString("0.00"+"₺"));

            var value8 = _productService.TMaxProductPrice();
            await Clients.All.SendAsync("ReceiveMaxProductPrice", value8);

            var value9 = _productService.TMinProductPrice();
            await Clients.All.SendAsync("ReceiveMinProductPrice", value9);

            var value10 = _productService.TAvgDönerPrice();
            await Clients.All.SendAsync("ReceiveAvgDönerPrice", value10);

            var value11 = _orderService.TTotalOrderCount();
            await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);

            var value12 = _orderService.TActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);

            var value13 = _orderService.TLastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", value13.ToString("0.00"+"₺"));

            var value14 = _moneyCaseService.TTotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14.ToString("0.00"+"₺"));

            var value16 = _menuTableService.TMenuTableCount();
            await Clients.All.SendAsync("ReceiveMenuTableCount", value16);

        }
       public async Task SendProgress() { }
    }
}

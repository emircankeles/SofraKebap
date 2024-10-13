using Microsoft.AspNetCore.SignalR;
using SofraKebab.DataAccessLayer.Concreate;

namespace API.Hubs
{
    public class SignalRHub:Hub
    {
        SofraKebabContext context =new SofraKebabContext();

        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);

        }
    }
}

using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZarzadzanieSerwisem.Startup))]
namespace ZarzadzanieSerwisem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}

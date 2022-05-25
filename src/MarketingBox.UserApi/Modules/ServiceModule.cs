using Autofac;
using MarketingBox.Auth.Service.Client;

namespace MarketingBox.UserApi.Modules
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAuthServiceClient(Program.Settings.AuthServiceUrl);
        }
    }
}
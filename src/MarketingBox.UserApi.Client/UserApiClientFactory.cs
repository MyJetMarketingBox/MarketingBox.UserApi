using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;

namespace MarketingBox.UserApi.Client
{
    [UsedImplicitly]
    public class UserApiClientFactory: MyGrpcClientFactory
    {
        public UserApiClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }
    }
}

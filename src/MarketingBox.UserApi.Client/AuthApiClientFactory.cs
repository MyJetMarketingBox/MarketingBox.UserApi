using JetBrains.Annotations;
using MyJetWallet.Sdk.Grpc;

namespace MarketingBox.UserApi.Client
{
    [UsedImplicitly]
    public class AuthApiClientFactory: MyGrpcClientFactory
    {
        public AuthApiClientFactory(string grpcServiceUrl) : base(grpcServiceUrl)
        {
        }
    }
}

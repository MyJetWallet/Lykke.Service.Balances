using Lykke.Service.Wallets.Client.AutorestClient.Models;
using Lykke.Service.Wallets.Client.ResponseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Service.Wallets.Client
{
    public interface IWalletsClient
    {
        Task<IEnumerable<ClientBalanceResponseModel>> GetClientBalances(string clientId);
        Task<ClientBalanceModel> GetClientBalanceByAssetId(ClientBalanceByAssetIdModel model);
    }
}
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Lykke.Service.Wallets.Client.AutorestClient
{
    using Lykke.Service;
    using Lykke.Service.Wallets;
    using Lykke.Service.Wallets.Client;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WalletsService.
    /// </summary>
    public static partial class WalletsServiceExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object IsAlive(this IWalletsService operations)
            {
                return operations.IsAliveAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> IsAliveAsync(this IWalletsService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IsAliveWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            public static IWalletCredentials GetWalletsCredentials(this IWalletsService operations, string clientId)
            {
                return operations.GetWalletsCredentialsAsync(clientId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IWalletCredentials> GetWalletsCredentialsAsync(this IWalletsService operations, string clientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWalletsCredentialsWithHttpMessagesAsync(clientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            public static IList<string> GetWalletsCredentialsHistory(this IWalletsService operations, string clientId)
            {
                return operations.GetWalletsCredentialsHistoryAsync(clientId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetWalletsCredentialsHistoryAsync(this IWalletsService operations, string clientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWalletsCredentialsHistoryWithHttpMessagesAsync(clientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            public static IList<ClientBalanceResponseModel> GetClientBalances(this IWalletsService operations, string clientId)
            {
                return operations.GetClientBalancesAsync(clientId).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='clientId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ClientBalanceResponseModel>> GetClientBalancesAsync(this IWalletsService operations, string clientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClientBalancesWithHttpMessagesAsync(clientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            public static ClientBalanceResponseModel GetClientBalancesByAssetId(this IWalletsService operations, ClientBalanceByAssetIdModel model = default(ClientBalanceByAssetIdModel))
            {
                return operations.GetClientBalancesByAssetIdAsync(model).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='model'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ClientBalanceResponseModel> GetClientBalancesByAssetIdAsync(this IWalletsService operations, ClientBalanceByAssetIdModel model = default(ClientBalanceByAssetIdModel), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetClientBalancesByAssetIdWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

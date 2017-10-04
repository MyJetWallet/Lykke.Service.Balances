﻿using Autofac;
using AzureStorage.Tables;
using Common.Log;
using Lykke.Service.Wallets.AzureRepositories;
using Lykke.Service.Wallets.AzureRepositories.Account;
using Lykke.Service.Wallets.AzureRepositories.Wallets;
using Lykke.Service.Wallets.Core.Wallets;
using Lykke.Service.Wallets.Settings;
using Lykke.SettingsReader;

namespace Lykke.Service.Wallets.Modules
{
    public class ServiceModule : Module
    {
        private readonly IReloadingManager<WalletsSettings> _settings;
        
        public ServiceModule(IReloadingManager<WalletsSettings> settings)
        {
            _settings = settings;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(_settings)
                .SingleInstance();

            builder.RegisterType<WalletsRepository>().As<IWalletsRepository>().SingleInstance();
            builder.RegisterType<WalletCredentialsRepository>().As<IWalletCredentialsRepository>().SingleInstance();
            builder.RegisterType<WalletCredentialsHistoryRepository>().As<IWalletCredentialsHistoryRepository>().SingleInstance();

            builder.Register(kernel => AzureTableStorage<WalletEntity>.Create(_settings.ConnectionString(x => x.Db.ClientPersonalInfoConnString), "Accounts", kernel.Resolve<ILog>())).SingleInstance();
            builder.Register(kernel => AzureTableStorage<WalletCredentialsEntity>.Create(_settings.ConnectionString(x => x.Db.ClientPersonalInfoConnString), "WalletCredentials", kernel.Resolve<ILog>())).SingleInstance();
            builder.Register(kernel => AzureTableStorage<WalletCredentialsHistoryRecord>.Create(_settings.ConnectionString(x => x.Db.ClientPersonalInfoConnString), "WalletCredentialsHistory", kernel.Resolve<ILog>())).SingleInstance();
        }
    }
}

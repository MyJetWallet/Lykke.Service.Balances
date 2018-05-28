﻿using JetBrains.Annotations;
using Lykke.Service.Balances.Core.Settings;

namespace Lykke.Service.Balances.Settings
{
    [UsedImplicitly]
    public class BalancesSettings
    {
        public DbSettings Db { get; set; }
        public RedisSettings BalanceCache { get; set; }
    }
}
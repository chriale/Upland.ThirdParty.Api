﻿namespace Optimizer.Packages.Apis.UplandThirdParty.Types
{
    public class EscrowAsset
    {
        public long Id { get; set; }
        public string TransactionId { get; set; }
        public double? Amount { get; set; }
        public long? AssetId { get; set; }
        public string Category { get; set; }
        public string OwnerEOSId { get; set; }
        public string Status { get; set; }
    }
}

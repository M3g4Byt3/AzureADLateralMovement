﻿namespace AzureActiveDirectoryApplication.Models.BloodHound
{
    internal class Trust
    {
        private string _targetName;

        public string TargetName
        {
            get => _targetName;
            set => _targetName = value.ToUpper();
        }

        public bool? IsTransitive { get; set; }
        public int TrustDirection { get; set; }
        public string TrustType { get; set; }
    }

    internal enum TrustDirection
    {
        Inbound = 0,
        Outbound = 1,
        Bidrectional = 2
    }
}
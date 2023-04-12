using System;
using Newtonsoft.Json;

public class BankTransferConfig
{
    public string lang { get; set; }
    public Transfer transfer { get; set; }
    public string[] methods { get; set; }
    public ConfirmationConfig confirmation { get; set; }

    public BankTransferConfig(string jsonConfig)
    {
        JsonConvert.PopulateObject(jsonConfig, this);
    }

    public class Transfer
    {
        public int threshold { get; set; }
        public string LABORATORIUM { get; set; }
        public string INFORMATIKA { get; set; }
        public string Informatika { get; set; }
        public string Telkom { get; set; }
        public string low_fee { get; set; }
        public string high_fee { get; set; }
    }

    public class ConfirmationConfig
    {
        public string indo { get; set; }
        public string id { get; set; }
    }
}
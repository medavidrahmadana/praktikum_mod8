using System;
using Newtonsoft.Json;
public class Program
{
    public static void Main()
    {
        string jsonConfig = System.IO.File.ReadAllText("bank_transfer_config.json");
        BankTransferConfig config = new BankTransferConfig(jsonConfig);

        Console.WriteLine(config.lang == "id" ? "Masukkan jumlah uang yang akan di-transfer:" :  "Please insert the amount of money to transfer:");

        int transferAmount = Convert.ToInt32(Console.ReadLine());
        int transferFee = 0;
        if (transferAmount <= config.transfer.threshold)
        {
            transferFee = Convert.ToInt32(config.transfer.low_fee);
        }
        else
        {
            transferFee = Convert.ToInt32(config.transfer.high_fee);
        }
        int totalAmount = transferAmount + transferFee;

        Console.WriteLine(config.lang == "id" ? $"Biaya transfer = {transferFee}" : $"Transfer fee = {transferFee}");
        Console.WriteLine(config.lang == "id" ? $"Total biaya = {totalAmount}" : $"Total amount = {totalAmount}");

        Console.WriteLine(config.lang == "id" ? "Pilih metode transfer: " : "Select transfer method:");

        for (int i = 0; i < config.methods.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        Console.WriteLine("Pilih lah methode yang tersedia..");
        string Input = Console.ReadLine();
        if (Input == "RTO")
        {
            Console.WriteLine(config.lang == "id" ? $"Pilihan anda adalah = {Input}" : $"The transfer is completed = {Input}");
        }
        else if (Input == "SKN")
        {
            Console.WriteLine(config.lang == "id" ? $"Pilihan anda adalah = {Input}" : $"The transfer is completed = {Input}");
        }
        else if (Input == "RTGS")
        {
            Console.WriteLine(config.lang == "id" ? $"Pilihan anda adalah = {Input}" : $"The transfer is completed = {Input}");
        }
        else if (Input == "BI")
        {
            Console.WriteLine(config.lang == "id" ? $"Pilihan anda adalah = {Input}" : $"The transfer is completed = {Input}");
        }
        else if (Input == "FAST")
        {
            Console.WriteLine(config.lang == "id" ? $"Pilihan anda adalah = {Input}" : $"The transfer is completed = {Input}");
        }

        Console.WriteLine(config.lang == "id" ? $"Ketik \"{config.confirmation.id}\" untuk mengkonfirmasi transaksi. dan \"{config.confirmation.indo}\" untuk membatalkan transaksi: " : $"Please type \"{config.confirmation.indo}\" to confirm the transaction:");

        string userInput = Console.ReadLine();
        if (userInput ==  config.confirmation.id)
        {
            Console.WriteLine(config.lang == "id" ? "Proses transfer berhasil" : "The transfer is completed");
        }
        else if (userInput == config.confirmation.indo)
        {
            Console.WriteLine(config.lang == "id" ? "Transfer dibatalkan" : "Transfer is cancelled");
        }
    }
}
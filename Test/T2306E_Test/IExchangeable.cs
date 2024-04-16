namespace T2306E_Test;

public interface IExchangeable
{
    double ExchangeRate { get; set; }
    double ConvertToVND(double amount);
}

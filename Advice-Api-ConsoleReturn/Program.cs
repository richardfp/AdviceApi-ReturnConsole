using Flurl;
using Flurl.Http;

var apiReturns = await "https://api.adviceslip.com/advice"
            .GetJsonAsync<ApiReturn>();

Console.WriteLine($"slip: {apiReturns.slip.slip_id}, mensagem: {apiReturns.slip.advice}");



public class ApiReturn
{
    public Slip slip { get; set; }
}

public class Slip
{
    public int slip_id { get; set; }
    public string advice { get; set; }
}
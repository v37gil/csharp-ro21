Console.WriteLine($"int.MaxValue: {int.MaxValue}");
Console.WriteLine($"long.MaxValue: {long.MaxValue}");
Console.WriteLine($"decimal.MaxValue: {decimal.MaxValue}");

int heartBeats = unchecked(80 * 365 * 24 * 60 * 70);
Console.WriteLine($"Удары сердца за 80 лет (int): {heartBeats}");

long correctHeartBeats = 80L * 365 * 24 * 60 * 70;
Console.WriteLine($"Удары сердца за 80 лет (long): {correctHeartBeats}");

const decimal usdToKzt = 512.37m;
decimal tenge = 150m * usdToKzt;

Console.WriteLine($"150 USD в тенге: {tenge}");
Console.WriteLine($"150 USD в тенге (int): {(int)tenge}");
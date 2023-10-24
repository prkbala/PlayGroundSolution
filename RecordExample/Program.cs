// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


AppDetails appDetails = new("SomeApp", "2.1.0");
Console.WriteLine(TransformStringUsingWith(appDetails));

static string TransformStringUsingWith(AppDetails appDetails)
    => appDetails switch
    {
        { Name: "SomeApp" } => (appDetails with { Name = "SomeName_With" }).ToString(),
        null => string.Empty,
        _ => appDetails.ToString(),
    };

public record AppDetails(string Name, string? Version)
{
    public override string ToString()
        => $"{(string.IsNullOrWhiteSpace(Version) ? "?" : Version)} ({Name})";
}
namespace EventStoreDb.Settings;

public record EventStoreDbSettings
{
    public required string ConnectionStr { get; init; }
}
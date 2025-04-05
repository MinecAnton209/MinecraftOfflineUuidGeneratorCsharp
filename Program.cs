namespace MinecraftOfflineUuidGeneratorCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "MinecAnton209";
            Guid offlineUuid = OfflineUuidGenerator.GenerateOfflineUuid(username);
            Console.WriteLine($"Offline UUID for '{username}': {offlineUuid}");

            string anotherUsername = "TestPlayer";
            Guid anotherOfflineUuid = OfflineUuidGenerator.GenerateOfflineUuid(anotherUsername);
            Console.WriteLine($"Offline UUID for '{anotherUsername}': {anotherOfflineUuid}");
        }
    }
}
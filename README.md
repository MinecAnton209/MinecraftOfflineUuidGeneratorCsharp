# Minecraft Offline UUID Generator Example

This repository contains a simple example of C# code for generating offline Minecraft UUIDs based on player usernames.

## Files

* `OfflineUuidGenerator.cs`: Contains the C# code for the `OfflineUuidGenerator` class.
* `Program.cs`: An example console application that uses the `OfflineUuidGenerator` class.
* `README.md`: This file with the description.

## Usage

1.  Create a new C# console project (for example, in Visual Studio or using the .NET CLI).
2.  Create the files `OfflineUuidGenerator.cs` and `Program.cs` in your project and copy the corresponding code from this repository.
3.  Run the project. In the console output, you will see the generated offline UUIDs for the usernames "MinecAnton209" and "TestPlayer".

You can also use the `OfflineUuidGenerator` class in any other C# project where you need to generate offline UUIDs. Simply add the `OfflineUuidGenerator.cs` file to your project and call the `OfflineUuidGenerator.GenerateOfflineUuid("username")` method.
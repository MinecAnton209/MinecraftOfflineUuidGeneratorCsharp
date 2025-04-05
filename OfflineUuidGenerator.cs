using System.Text;
using System.Security.Cryptography;

namespace MinecraftOfflineUuidGeneratorCsharp
{
    public static class OfflineUuidGenerator
    {
        /// <summary>
        /// Generates an offline mode UUID for a given Minecraft username.
        /// </summary>
        /// <param name="username">The Minecraft username.</param>
        /// <returns>A Guid representing the offline UUID.</returns>
        public static Guid GenerateOfflineUuid(string username)
        {
            // The string that is used as input for the UUID generation.
            string offlinePlayerString = $"OfflinePlayer:{username}";
            // Get the bytes of the string using UTF-8 encoding.
            byte[] nameBytes = Encoding.UTF8.GetBytes(offlinePlayerString);

            // Use MD5 hash algorithm to generate a hash from the bytes.
            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(nameBytes);

                // Create a byte array of length 16 to hold the UUID bytes.
                byte[] uuidBytes = new byte[16];
                // Copy the first 16 bytes of the hash to the UUID byte array.
                Array.Copy(hashBytes, uuidBytes, 16);

                // Set the version bits to indicate version 3 (name-based using MD5).
                uuidBytes[6] = (byte)((uuidBytes[6] & 0x0F) | 0x30); // 0x30 is 00110000 in binary

                // Set the variant bits to indicate RFC 4122.
                uuidBytes[8] = (byte)((uuidBytes[8] & 0x3F) | 0x80); // 0x80 is 10000000 in binary

                // Swap bytes to match the correct UUID format.
                SwapBytes(uuidBytes, 0, 3);
                SwapBytes(uuidBytes, 1, 2);
                SwapBytes(uuidBytes, 4, 5);
                SwapBytes(uuidBytes, 6, 7);

                // Create a new Guid from the modified byte array.
                return new Guid(uuidBytes);
            }
        }

        /// <summary>
        /// Swaps two bytes in a byte array.
        /// </summary>
        /// <param name="bytes">The byte array.</param>
        /// <param name="i">The index of the first byte.</param>
        /// <param name="j">The index of the second byte.</param>
        private static void SwapBytes(byte[] bytes, int i, int j)
        {
            (bytes[i], bytes[j]) = (bytes[j], bytes[i]);
        }
    }
}
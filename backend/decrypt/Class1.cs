using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Decryptor
{
    public static void Main()
    {
        string password = "whodrinksroots";
        byte[] key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
        byte[] nonce = Encoding.ASCII.GetBytes("abcdefgh");

        string encryptedFilePath = @"path\to\PO-encrypted.pdf";
        string decryptedFilePath = @"path\to\PO-decrypted.pdf";

        byte[] encryptedData = File.ReadAllBytes(encryptedFilePath);

        // Initialize and configure ChaCha20 cipher here
        // Perform decryption

        File.WriteAllBytes(decryptedFilePath, decryptedData);

        Console.WriteLine("Decryption Complete. Check the decrypted file.");
    }
}

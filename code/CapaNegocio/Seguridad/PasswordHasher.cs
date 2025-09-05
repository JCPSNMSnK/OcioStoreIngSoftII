using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocio.Seguridad
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16; // 16 bytes = 128 bits
        private const int HashSize = 32; // 32 bytes = 256 bits
        private const int Iterations = 4; // Iteraciones para Argon2

        /// <summary>
        /// Crea un hash de una contraseña con un salt aleatorio usando Argon2.
        /// </summary>
        /// <param name="password">La contraseña a hashear.</param>
        /// <returns>Un string que contiene el salt y el hash, listos para guardar en la BD.</returns>
        public static string HashPassword(string password)
        {
            // 1. Generar un "salt" aleatorio
            byte[] salt = new byte[SaltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // 2. Configurar los parámetros de Argon2
            var argon2Params = new Argon2Parameters.Builder(Argon2Parameters.Argon2id)
                .WithVersion(Argon2Parameters.Version13)
                .WithIterations(Iterations)
                .WithMemoryAsKB(65536) // 64 MB
                .WithParallelism(1)
                .WithSalt(salt)
                .Build();

            var generator = new Argon2BytesGenerator();
            generator.Init(argon2Params);

            // 3. Generar el hash
            byte[] hash = new byte[HashSize];
            generator.GenerateBytes(Encoding.UTF8.GetBytes(password), hash, 0, hash.Length);

            // 4. Combinar salt y hash en un solo string para guardarlo
            byte[] combinedBytes = new byte[SaltSize + HashSize];
            Buffer.BlockCopy(salt, 0, combinedBytes, 0, SaltSize);
            Buffer.BlockCopy(hash, 0, combinedBytes, SaltSize, HashSize);

            return Convert.ToBase64String(combinedBytes);
        }

        /// <summary>
        /// Verifica si una contraseña coincide con un hash guardado.
        /// </summary>
        /// <param name="password">La contraseña introducida por el usuario.</param>
        /// <param name="hashedPassword">El hash guardado en la base de datos.</param>
        /// <returns>True si la contraseña es correcta, false en caso contrario.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            try
            {
                // 1. Extraer el salt y el hash del string guardado
                byte[] combinedBytes = Convert.FromBase64String(hashedPassword);
                byte[] salt = new byte[SaltSize];
                byte[] hash = new byte[HashSize];
                Buffer.BlockCopy(combinedBytes, 0, salt, 0, SaltSize);
                Buffer.BlockCopy(combinedBytes, SaltSize, hash, 0, HashSize);

                // 2. Hashear la nueva contraseña con el MISMO salt
                var argon2Params = new Argon2Parameters.Builder(Argon2Parameters.Argon2id)
                    .WithVersion(Argon2Parameters.Version13)
                    .WithIterations(Iterations)
                    .WithMemoryAsKB(65536)
                    .WithParallelism(1)
                    .WithSalt(salt)
                    .Build();

                var generator = new Argon2BytesGenerator();
                generator.Init(argon2Params);

                byte[] newHash = new byte[HashSize];
                generator.GenerateBytes(Encoding.UTF8.GetBytes(password), newHash, 0, newHash.Length);

                // 3. Comparar los hashes en tiempo constante para evitar ataques de temporización
                uint diff = (uint)hash.Length ^ (uint)newHash.Length;
                for (int i = 0; i < hash.Length && i < newHash.Length; i++)
                {
                    diff |= (uint)(hash[i] ^ newHash[i]);
                }

                return diff == 0;
            }
            catch
            {
                // Si el hash guardado tiene un formato incorrecto, la contraseña no es válida.
                return false;
            }
        }
    }
}

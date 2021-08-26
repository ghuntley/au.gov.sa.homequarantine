using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace HomeQuarantine.Helpers
{
	public class EncryptedAuthTokenHelper
	{
		public async Task<string> EncryptAuthToken(string token)
		{
			if (string.IsNullOrWhiteSpace(token))
			{
				return token;
			}
			if (!token.Contains("."))
			{
				throw new ArgumentException("Invalid JWT Token");
			}
			byte[] item = (await GetExistingKeyOrCreate()).Item1;
			byte[] iV = new byte[16];
			byte[] inArray;
			using (Aes aes = Aes.Create())
			{
				aes.Key = item;
				aes.IV = iV;
				ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
				using MemoryStream memoryStream = new MemoryStream();
				using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				using (StreamWriter streamWriter = new StreamWriter(stream))
				{
					streamWriter.Write(token);
				}
				inArray = memoryStream.ToArray();
			}
			return Convert.ToBase64String(inArray);
		}

		public async Task<string> DecryptAuthToken(string token)
		{
			if (string.IsNullOrWhiteSpace(token))
			{
				return token;
			}
			if (token.Contains("."))
			{
				return string.Empty;
			}
			(byte[], bool) obj = await GetExistingKeyOrCreate();
			var (key, _) = obj;
			if (!obj.Item2)
			{
				return string.Empty;
			}
			byte[] iV = new byte[16];
			byte[] buffer = Convert.FromBase64String(token);
			using Aes aes = Aes.Create();
			aes.Key = key;
			aes.IV = iV;
			ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
			using MemoryStream stream = new MemoryStream(buffer);
			using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream2);
			return streamReader.ReadToEnd();
		}

		protected static byte[] CreateKey()
		{
			byte[] array = new byte[32];
			RandomNumberGenerator.Create().GetBytes(array);
			return array;
		}

		protected virtual async Task<(byte[], bool)> GetExistingKeyOrCreate()
		{
			string text = await SecureStorage.GetAsync("auth-token-key");
			if (text == null)
			{
				byte[] key = CreateKey();
				await SecureStorage.SetAsync("auth-token-key", Convert.ToBase64String(key));
				return (key, false);
			}
			return (Convert.FromBase64String(text), true);
		}
	}
}

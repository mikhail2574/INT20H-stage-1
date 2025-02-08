using System;
using System.Linq;
using System.Security.Cryptography;
using VirtualPlatform.Services.Identity.Application.Services;

namespace VirtualPlatform.Services.Identity.Infrastructure.Auth;

internal sealed class Rng : IRng
{
    private static readonly string[] SpecialChars = new[] { "/", "\\", "=", "+", "?", ":", "&" };

    public string Generate(int length = 50, bool removeSpecialChars = true)
    {
        var bytes = new byte[length];
        RandomNumberGenerator.Fill(bytes);
        var result = Convert.ToBase64String(bytes);

        return removeSpecialChars
            ? SpecialChars.Aggregate(result, (current, chars) => current.Replace(chars, string.Empty))
            : result;
    }
}
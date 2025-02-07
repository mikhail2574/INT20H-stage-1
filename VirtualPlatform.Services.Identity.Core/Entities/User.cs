using System;
using System.Collections.Generic;
using System.Linq;
using VirtualPlatform.Services.Identity.Core.Exceptions;

namespace VirtualPlatform.Services.Identity.Core.Entities
{
    public class User : AggregateRoot
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public IEnumerable<string> Permissions { get; private set; }

        // New properties for profile info and social auth
        public string FullName { get; private set; }
        public string Avatar { get; private set; }
        public IList<string> QuestHistory { get; private set; }
        public string ExternalProvider { get; private set; }
        public string ExternalId { get; private set; }

        // Constructor for email registration
        public User(Guid id, string email, string password, string role,
            DateTime createdAt, IEnumerable<string> permissions,
            string fullName = null, string avatar = null, IList<string> questHistory = null)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new InvalidEmailException(email);
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new InvalidPasswordException();
            }

            if (!Entities.Role.IsValid(role))
            {
                throw new InvalidRoleException(role);
            }

            Id = id;
            Email = email.ToLowerInvariant();
            Password = password;
            Role = role;
            CreatedAt = createdAt;
            Permissions = permissions;
            FullName = fullName;
            Avatar = avatar;
            QuestHistory = questHistory ?? new List<string>();
        }

        public User(Guid id, string email, string role, DateTime createdAt,
            IEnumerable<string> permissions, string externalProvider, string externalId,
            string fullName = null, string avatar = null, IList<string> questHistory = null)
        {
            Id = id;
            Email = email;
            Role = role;
            CreatedAt = createdAt;
            Permissions = permissions;
            ExternalProvider = externalProvider;
            ExternalId = externalId;
            FullName = fullName;
            Avatar = avatar;
            QuestHistory = questHistory ?? new List<string>();
        }
    }
}
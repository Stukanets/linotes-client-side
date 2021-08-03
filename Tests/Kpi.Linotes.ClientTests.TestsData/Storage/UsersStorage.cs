using System;
using System.Collections.Generic;
using Bogus;
using Kpi.Linotes.ClientTests.Model.Domain.Main;

namespace Kpi.Linotes.ClientTests.TestsData.Storage
{
    public static class UsersStorage
    {
        public static Dictionary<string, UserInformation> Users =>
            new Dictionary<string, UserInformation>
            {
                { "ValidUser", ValidUser },
                { "InvalidUser", InvalidUser }
            };

        private static UserInformation ValidUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Login, "sendermails2020@gmail.com")
                .RuleFor(u => u.Password, "Qwertyuiop12");

        private static UserInformation InvalidUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Login, Guid.NewGuid().ToString)
                .RuleFor(u => u.Password, Guid.NewGuid().ToString);
    }
}

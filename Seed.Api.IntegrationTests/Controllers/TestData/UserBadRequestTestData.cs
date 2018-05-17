﻿using System.Collections;
using System.Collections.Generic;

namespace Seed.Api.IntegrationTests.Controllers.TestData
{
    public class UserBadRequestTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { null };
            yield return new object[] 
            {
                new
                {
                    Mail = "anEmail@email.com",
                    Name = "someName",
                    Name_Last = "someLastName",
                    LoginId = "userName"
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
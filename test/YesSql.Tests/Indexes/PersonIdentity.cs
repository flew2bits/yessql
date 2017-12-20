using System;
using YesSql.Indexes;
using YesSql.Tests.Models;

namespace YesSql.Tests.Indexes
{
    public class PersonIdentity : MapIndex
    {
        public PersonIdentity(string identity)
        {
            Identity = identity;
        }

        public string Identity { get; set; }
    }

    public class PersonIdentitiesIndexProvider : IndexProvider<Person>
    {
        public override void Describe(DescribeContext<Person> context, IReadOnlySession session)
        {
            context
                .For<PersonIdentity>()
                .Map(p => new [] {
                    new PersonIdentity(p.Firstname),
                    new PersonIdentity(p.Lastname)
                });
        }
    }
}

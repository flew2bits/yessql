using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesSql.Indexes
{
    public abstract class IndexProvider<T> : IIndexProvider
    {
        public abstract void Describe(DescribeContext<T> context, IReadOnlySession session);

        void IIndexProvider.Describe(IDescriptor context, IReadOnlySession session)
        {
            Describe((DescribeContext<T>)context, session);
        }

        public string CollectionName { get; set; }

        public Type ForType()
        {
            return typeof(T);
        }
    }
}

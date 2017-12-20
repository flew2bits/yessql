using System;

namespace YesSql.Indexes
{
    public interface IIndexProvider
    {
        void Describe(IDescriptor context, IReadOnlySession session);
        Type ForType();
        string CollectionName { get; set; }
    }
}
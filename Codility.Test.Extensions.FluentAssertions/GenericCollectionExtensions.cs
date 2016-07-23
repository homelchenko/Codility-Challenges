using System.Collections.Generic;
using System.Linq;

using FluentAssertions;
using FluentAssertions.Collections;

namespace Codility.Test.Extensions.FluentAssertions
{
    public static class GenericCollectionExtensions
    {
        public static AndConstraint<GenericCollectionAssertions<T>> Be<T>(this GenericCollectionAssertions<T> assertions, IEnumerable<T> expected, string because = "", params object[] becauseArgs)
        {
            T[] bufferedExpected = expected.ToArray();

            return assertions
                .HaveCount(bufferedExpected.Length, because, becauseArgs)
                .And.ContainInOrder(bufferedExpected, because, becauseArgs);
        }
    }
}

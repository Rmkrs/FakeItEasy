namespace FakeItEasy
{
    using FakeItEasy.Configuration;

    /// <summary>
    /// Provides extension methods for <see cref="IAssertConfiguration"/>.
    /// </summary>
    public static class AssertConfigurationExtensions
    {
        /// <summary>
        /// Asserts that the specified call must have happened once or more.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappened(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.AtLeast.Once);
        }

        /// <summary>
        /// Asserts that the specified call has not happened.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        public static void MustNotHaveHappened(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            configuration.MustHaveHappened(Repeated.Never);
        }

        /// <summary>
        /// Asserts that the specified call must have happened once exactly.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappenedOnceExactly(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.Exactly.Once);
        }

        /// <summary>
        /// Asserts that the specified call must have happened once or more.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappenedOnceOrMore(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.AtLeast.Once);
        }

        /// <summary>
        /// Asserts that the specified call must have happened once or less.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappenedOnceOrLess(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.NoMoreThan.Once);
        }

        /// <summary>
        /// Asserts that the specified call must have happened twice exactly.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappenedTwiceExactly(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.Exactly.Twice);
        }

        /// <summary>
        /// Asserts that the specified call must have happened twice or more.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappenedTwiceOrMore(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.AtLeast.Twice);
        }

        /// <summary>
        /// Asserts that the specified call must have happened twice or less.
        /// </summary>
        /// <param name="configuration">The configuration to assert on.</param>
        /// <returns>An object to assert the call order.</returns>
        public static UnorderedCallAssertion MustHaveHappenedTwiceOrLess(this IAssertConfiguration configuration)
        {
            Guard.AgainstNull(configuration, nameof(configuration));

            return configuration.MustHaveHappened(Repeated.NoMoreThan.Twice);
        }
    }
}

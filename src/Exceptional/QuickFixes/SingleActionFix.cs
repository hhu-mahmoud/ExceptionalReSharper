namespace ReSharper.Exceptional.QuickFixes
{
    using JetBrains.ReSharper.Feature.Services.QuickFixes;
    using JetBrains.Util;

    /// <summary>Base class for all fixes that serves only one <see cref="QuickFixBase" />. </summary>
    internal abstract class SingleActionFix : QuickFixBase
    {
        #region methods

        /// <summary>Determines whether the specified cache is available. </summary>
        /// <param name="cache">The cache.</param>
        /// <returns><c>true</c> if the specified cache is available; otherwise, <c>false</c>. </returns>
        public override bool IsAvailable(IUserDataHolder cache)
        {
            return true;
        }

        #endregion
    }
}
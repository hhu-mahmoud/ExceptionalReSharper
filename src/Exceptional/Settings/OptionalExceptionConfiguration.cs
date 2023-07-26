﻿namespace ReSharper.Exceptional.MF.Settings
{
    using JetBrains.ReSharper.Psi;

    public sealed class OptionalExceptionConfiguration
    {
        #region constructors and destructors

        public OptionalExceptionConfiguration(IDeclaredType exceptionType, OptionalExceptionReplacementType replacementType)
        {
            ExceptionType = exceptionType;
            ReplacementType = replacementType;
        }

        #endregion

        #region properties

        public IDeclaredType ExceptionType { get; }

        public OptionalExceptionReplacementType ReplacementType { get; }

        #endregion
    }
}
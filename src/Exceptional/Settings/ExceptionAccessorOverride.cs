namespace ReSharper.Exceptional.Settings
{
    using System;

    using JetBrains.ReSharper.Psi;
    using JetBrains.Util.Logging;

    public sealed class ExceptionAccessorOverride
    {
        #region member vars

        private IDeclaredType _exceptionType;
        private bool _exceptionTypeLoaded;

        #endregion

        #region constructors and destructors

        public ExceptionAccessorOverride(string fullMethodName, string exceptionType, string exceptionAccessor)
        {
            FullMethodName = fullMethodName;
            ExceptionType = exceptionType;
            ExceptionAccessor = exceptionAccessor;
        }

        #endregion

        #region methods

        public IDeclaredType GetExceptionType()
        {
            if (_exceptionTypeLoaded)
            {
                return _exceptionType;
            }
            try
            {
                _exceptionType = TypeFactory.CreateTypeByCLRName(ExceptionType, ServiceLocator.StageProcess.PsiModule);
            }
            catch (Exception ex)
            {
                Logger.LogException(string.Format("[Exceptional] Error loading excluded method exception '{0}'", ExceptionType), ex);
            }
            finally
            {
                _exceptionTypeLoaded = true;
            }
            return _exceptionType;
        }

        #endregion

        #region properties

        public string ExceptionAccessor { get; }

        public string ExceptionType { get; }

        public string FullMethodName { get; }

        #endregion
    }
}
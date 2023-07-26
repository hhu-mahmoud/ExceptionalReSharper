namespace ReSharper.Exceptional.MF.Highlightings
{
    using JetBrains.ReSharper.Feature.Services.Daemon;
    using JetBrains.ReSharper.Psi.CSharp;

    using Models;

    [RegisterConfigurableSeverity(
        Id,
        Constants.CompoundName,
        HighlightingGroupIds.BestPractice,
        "Exceptional.ExceptionNotThrownOptional",
        "Exceptional.ExceptionNotThrownOptional",
        Severity.HINT)]
    [ConfigurableSeverityHighlighting(Id, CSharpLanguage.Name)]
    public class ExceptionNotThrownOptionalHighlighting : HighlightingBase
    {
        #region constants

        public const string Id = "ExceptionNotThrownOptional";

        #endregion

        #region constructors and destructors

        /// <summary>Initializes a new instance of the <see cref="ExceptionNotThrownOptionalHighlighting" /> class. </summary>
        /// <param name="exceptionDocumentation">The exception documentation. </param>
        internal ExceptionNotThrownOptionalHighlighting(ExceptionDocCommentModel exceptionDocumentation)
        {
            ExceptionDocumentation = exceptionDocumentation;
        }

        #endregion

        #region properties

        /// <summary>Gets the message which is shown in the editor. </summary>
        protected override string Message =>
            Constants.OptionalPrefix + string.Format(
                Resources.HighlightNotThrownDocumentedExceptions,
                ExceptionDocumentation.ExceptionType.GetClrName().ShortName);

        /// <summary>Gets the exception documentation. </summary>
        internal ExceptionDocCommentModel ExceptionDocumentation { get; }

        #endregion
    }
}
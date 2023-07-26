﻿namespace ReSharper.Exceptional.MF.Contexts
{
    using JetBrains.ReSharper.Psi.CSharp.Tree;
    using JetBrains.ReSharper.Psi.Tree;

    using Models;

    internal class NullProcessContext : IProcessContext
    {
        #region explicit interfaces

        public void EnterAccessor(IAccessorDeclaration accessorDeclarationNode)
        {
        }

        public void EnterCatchClause(ICatchClause catchClauseNode)
        {
        }

        public void EnterTryBlock(ITryStatement tryStatement)
        {
        }

        public void LeaveAccessor()
        {
        }

        public void LeaveCatchClause()
        {
        }

        public void LeaveTryBlock()
        {
        }

        public IAnalyzeUnit Model => null;

        public void Process(IThrowStatement throwStatement)
        {
        }

        public void Process(ICatchVariableDeclaration catchVariableDeclaration)
        {
        }

        public void Process(IReferenceExpression invocationExpression)
        {
        }

        public void Process(IObjectCreationExpression objectCreationExpression)
        {
        }

        public void Process(IDocCommentBlock docCommentBlockNode)
        {
        }

        public void Process(IThrowExpression throwExpression)
        {
        }

        public void RunAnalyzers()
        {
        }

        public void StartProcess(IAnalyzeUnit analyzeUnit)
        {
        }

        #endregion
    }
}
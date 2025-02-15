﻿using System.Linq;
using System.Collections.Generic;
using CTA.Rules.Config;
using TextSpan = Codelyzer.Analysis.Model.TextSpan;

namespace CTA.Rules.Models.Tokens
{
    public class NodeToken
    {
        public NodeToken()
        {
            AttributeActions = new List<AttributeAction>();
            AttributeListActions = new List<AttributeAction>();
            ClassDeclarationActions = new List<ClassDeclarationAction>();
            UsingActions = new List<UsingAction>();
            IdentifierNameActions = new List<IdentifierNameAction>();
            InvocationExpressionActions = new List<InvocationExpressionAction>();
            ExpressionActions = new List<ExpressionAction>();
            MethodDeclarationActions = new List<MethodDeclarationAction>();
            ElementAccessActions = new List<ElementAccessAction>();
            MemberAccessActions = new List<MemberAccessAction>();
            NamespaceActions = new List<NamespaceAction>();
            ObjectCreationExpressionActions = new List<ObjectCreationExpressionAction>();
            PackageActions = new List<PackageAction>();
            InterfaceDeclarationActions = new List<InterfaceDeclarationAction>();
            ProjectLevelActions = new List<ProjectLevelAction>();
            ProjectFileActions = new List<ProjectLevelAction>();
            TargetCPU = new List<string>();
            TextChanges = new List<TextChange>();
        }
        public string Key { get; set; }
        public string TrimmedKey => !string.IsNullOrEmpty(Key) ? Utils.EscapeAllWhitespace(Key) : string.Empty;
        public string Namespace { get; set; }
        public string Type { get; set; }
        public string FullKey { get; set; }
        public TextSpan TextSpan { get; set; }
        public string Description { get; set; }
        public IList<TextChange> TextChanges { get; set; }
        public List<string> TargetCPU { get; set; }
        public List<AttributeAction> AttributeActions { get; set; }
        public List<AttributeAction> AttributeListActions { get; set; }
        public List<ClassDeclarationAction> ClassDeclarationActions { get; set; }
        public List<InterfaceDeclarationAction> InterfaceDeclarationActions { get; set; }
        public List<MethodDeclarationAction> MethodDeclarationActions { get; set; }
        public List<ElementAccessAction> ElementAccessActions { get; set; }
        public List<MemberAccessAction> MemberAccessActions { get; set; }
        public List<UsingAction> UsingActions { get; set; }
        public List<IdentifierNameAction> IdentifierNameActions { get; set; }
        public List<InvocationExpressionAction> InvocationExpressionActions { get; set; }
        public List<ExpressionAction> ExpressionActions { get; set; }
        public List<NamespaceAction> NamespaceActions { get; set; }
        public List<ObjectCreationExpressionAction> ObjectCreationExpressionActions { get; set; }
        public List<PackageAction> PackageActions { get; set; }
        public List<ProjectLevelAction> ProjectLevelActions { get; set; }
        public List<ProjectLevelAction> ProjectFileActions { get; set; }

        public NodeToken Clone()
        {
            NodeToken cloned = (NodeToken)this.MemberwiseClone();
            cloned.TextChanges = cloned.TextChanges?.Select(textChange => textChange.Clone()).ToList();
            cloned.TargetCPU = cloned.TargetCPU?.ToList();
            cloned.AttributeActions = cloned.AttributeActions?.Select(action => action.Clone<AttributeAction>())?.ToList();
            cloned.AttributeListActions = cloned.AttributeListActions?.Select(action => action.Clone<AttributeAction>())?.ToList();
            cloned.ClassDeclarationActions = cloned.ClassDeclarationActions?.Select(action => action.Clone<ClassDeclarationAction>())?.ToList();
            cloned.InterfaceDeclarationActions = cloned.InterfaceDeclarationActions.Select(action => action.Clone<InterfaceDeclarationAction>()).ToList();
            cloned.MethodDeclarationActions = cloned.MethodDeclarationActions.Select(action => action.Clone<MethodDeclarationAction>()).ToList();
            cloned.ElementAccessActions = cloned.ElementAccessActions.Select(action => action.Clone<ElementAccessAction>()).ToList();
            cloned.MemberAccessActions = cloned.MemberAccessActions.Select(action => action.Clone<MemberAccessAction>()).ToList();
            cloned.UsingActions = cloned.UsingActions.Select(action => action.Clone<UsingAction>()).ToList();
            cloned.IdentifierNameActions = cloned.IdentifierNameActions.Select(action => action.Clone<IdentifierNameAction>()).ToList();
            cloned.InvocationExpressionActions = cloned.InvocationExpressionActions.Select(action => action.Clone<InvocationExpressionAction>()).ToList();
            cloned.ExpressionActions = cloned.ExpressionActions.Select(action => action.Clone<ExpressionAction>()).ToList();
            cloned.NamespaceActions = cloned.NamespaceActions.Select(action => action.Clone<NamespaceAction>()).ToList();
            cloned.ObjectCreationExpressionActions = cloned.ObjectCreationExpressionActions.Select(action => action.Clone<ObjectCreationExpressionAction>()).ToList();
            cloned.PackageActions = cloned.PackageActions.Select(action => action.Clone()).ToList();
            cloned.ProjectLevelActions = cloned.ProjectLevelActions.Select(action => action.Clone<ProjectLevelAction>()).ToList();
            cloned.ProjectFileActions = cloned.ProjectFileActions.Select(action => action.Clone<ProjectLevelAction>()).ToList();
            return cloned;
        }

        public List<GenericAction> AllActions
        {
            get
            {
                var allActions = new List<GenericAction>();
                allActions.AddRange(AttributeActions);
                allActions.AddRange(AttributeListActions);
                allActions.AddRange(MethodDeclarationActions);
                allActions.AddRange(ClassDeclarationActions);
                allActions.AddRange(InterfaceDeclarationActions);
                allActions.AddRange(ElementAccessActions);
                allActions.AddRange(MemberAccessActions);
                allActions.AddRange(IdentifierNameActions);
                allActions.AddRange(InvocationExpressionActions);
                allActions.AddRange(ExpressionActions);
                allActions.AddRange(MemberAccessActions);
                allActions.AddRange(UsingActions);
                allActions.AddRange(ObjectCreationExpressionActions);
                allActions.AddRange(NamespaceActions);
                return allActions;
            }
        }

    }
}

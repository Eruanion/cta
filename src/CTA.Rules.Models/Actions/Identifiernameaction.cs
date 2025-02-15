﻿
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;

namespace CTA.Rules.Models
{
    public class IdentifierNameAction : GenericAction
    {
        public Func<SyntaxGenerator, IdentifierNameSyntax, IdentifierNameSyntax> IdentifierNameActionFunc { get; set; }

        public override bool Equals(object obj)
        {
            var action = (IdentifierNameAction)obj;
            return action?.Key == this.Key
                && action?.Value == this.Value
                && action?.IdentifierNameActionFunc.Method.Name == this.IdentifierNameActionFunc.Method.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Key, Value, IdentifierNameActionFunc?.Method.Name);
        }
    }
}

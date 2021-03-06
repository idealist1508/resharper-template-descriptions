﻿using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.CodeCompletion;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.Match;
using JetBrains.ReSharper.Feature.Services.Lookup;
using JetBrains.TextControl;
using JetBrains.UI.Icons;
using JetBrains.UI.RichText;
using JetBrains.Util;

namespace CitizenMatt.ReSharper.LiveTemplates.Descriptions
{
    public class WrappedLookupItem : IWrappedLookupItem
    {
        protected WrappedLookupItem(ILookupItem innerLookupItem)
        {
            Item = innerLookupItem;
        }

        public virtual ILookupItem Item { get; private set; }

        public virtual bool AcceptIfOnlyMatched(LookupItemAcceptanceContext itemAcceptanceContext)
        {
            return Item.AcceptIfOnlyMatched(itemAcceptanceContext);
        }

        public MatchingResult Match(PrefixMatcher prefixMatcher, ITextControl textControl)
        {
            return Item.Match(prefixMatcher, textControl);
        }

        public virtual void Accept(ITextControl textControl, TextRange nameRange, LookupItemInsertType lookupItemInsertType, Suffix suffix,
            ISolution solution, bool keepCaretStill)
        {
            Item.Accept(textControl, nameRange, lookupItemInsertType, suffix, solution, keepCaretStill);
        }

        public virtual TextRange GetVisualReplaceRange(ITextControl textControl, TextRange nameRange)
        {
            return Item.GetVisualReplaceRange(textControl, nameRange);
        }

        public virtual bool Shrink()
        {
            return Item.Shrink();
        }

        public virtual void Unshrink()
        {
            Item.Unshrink();
        }

        public LookupItemPlacement Placement
        {
            get { return Item.Placement; }
            set { Item.Placement = value; }
        }

        public virtual IconId Image
        {
            get { return Item.Image; }
        }

        public virtual RichText DisplayName
        {
            get { return Item.DisplayName; }
        }

        public virtual RichText DisplayTypeName
        {
            get { return Item.DisplayTypeName; }
        }

        public virtual bool CanShrink
        {
            get { return Item.CanShrink; }
        }

        public virtual int Multiplier
        {
            get { return Item.Multiplier; }
            set { Item.Multiplier = value; }
        }

        public EvaluationMode Mode
        {
            get { return Item.Mode; }
            set { Item.Mode = value; }
        }

        public virtual bool IsDynamic
        {
            get { return Item.IsDynamic; }
        }

        public virtual bool IgnoreSoftOnSpace
        {
            get { return Item.IgnoreSoftOnSpace; }
        }

        public int Identity { get { return Item.Identity; } }
    }
}
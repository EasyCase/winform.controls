#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Text.Template
{
    internal class TextNode : TokenNode
    {
        private string _Text;

        public TextNode(string text)
        {
            _Text = text;
        }

        public override void Evaluate(IExpressionParser parser, ITemplateContext context, StringBuilder output)
        {
            output.Append(this._Text);
        }

        public static implicit operator TextNode(string text)
        {
            return new TextNode(text);
        }

        public override string ToString()
        {
            return this.GetType().Name + ": \"" + this.Text + "\"";
        }

        public string Text
        {
            get { return this._Text; }
            set { this._Text = value; }
        }
    }
}

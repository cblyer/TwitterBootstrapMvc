﻿using System;
using System.ComponentModel;
using System.Web.Mvc;
using TwitterBootstrapMVC.ControlInterfaces;
using TwitterBootstrapMVC.Infrastructure.Enums;
using TwitterBootstrapMVC.Renderers;

namespace TwitterBootstrapMVC.Controls
{
    public class BootstrapControlGroupTextArea : BootstrapTextArea
    {
        public BootstrapControlGroupTextArea(HtmlHelper html, string htmlFieldName, ModelMetadata metadata)
            : base(html, htmlFieldName, metadata)
        {
            this._model.displayValidationMessage = true;
        }

        public override IBootstrapLabel Label()
        {
            IBootstrapLabel l = new BootstrapControlGroupLabeled(html, _model, BootstrapInputType.TextArea);
            return l;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToHtmlString()
        {
            return Renderer.RenderControlGroupTextArea(html, _model, null);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() { return ToHtmlString(); }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) { return base.Equals(obj); }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() { return base.GetHashCode(); }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Type GetType() { return base.GetType(); }
    }
}

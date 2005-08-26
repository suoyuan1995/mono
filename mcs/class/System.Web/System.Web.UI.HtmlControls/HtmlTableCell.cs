//
// System.Web.UI.HtmlControls.HtmlTableRow.cs
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.ComponentModel;
using System.Globalization;

namespace System.Web.UI.HtmlControls {

	[ConstructorNeedsTag (true)]
	public class HtmlTableCell : HtmlContainerControl {

		public HtmlTableCell ()
			: base ("td")
		{
		}

		public HtmlTableCell (string tagName)
			: base (tagName)
		{
		}


		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public string Align {
			get {
				string s = Attributes ["align"];
				return (s == null) ? String.Empty : s;
			}
			set {
				if (value == null)
					Attributes.Remove ("align");
				else
					Attributes ["align"] = value;
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public string BgColor {
			get {
				string s = Attributes ["bgcolor"];
				return (s == null) ? String.Empty : s;
			}
			set {
				if (value == null)
					Attributes.Remove ("bgcolor");
				else
					Attributes ["bgcolor"] = value;
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public string BorderColor {
			get {
				string s = Attributes ["bordercolor"];
				return (s == null) ? String.Empty : s;
			}
			set {
				if (value == null)
					Attributes.Remove ("bordercolor");
				else
					Attributes ["bordercolor"] = value;
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public int ColSpan {
			get {
				string s = Attributes ["colspan"];
				return (s == null) ? -1 : Convert.ToInt32 (s);
			}
			set {
				if (value == -1)
					Attributes.Remove ("colspan");
				else
					Attributes ["colspan"] = value.ToString (CultureInfo.InvariantCulture);
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public string Height {
			get {
				string s = Attributes ["height"];
				return (s == null) ? String.Empty : s;
			}
			set {
				if (value == null)
					Attributes.Remove ("align");
				else
					Attributes ["height"] = value;
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
#if NET_2_0
		[MonoTODO ("duplicate internal class for TypeConverter ?")]
		[TypeConverter ("System.Web.UI.MinimizableAttributeTypeConverter, System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
#endif
		public bool NoWrap {
			get { return (Attributes ["nowrap"] == "nowrap"); }
			set {
				if (value)
					Attributes ["nowrap"] = "nowrap";
				else
					Attributes.Remove ("nowrap");
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public int RowSpan {
			get {
				string s = Attributes ["rowspan"];
				return (s == null) ? -1 : Convert.ToInt32 (s);
			}
			set {
				if (value == -1)
					Attributes.Remove ("rowspan");
				else
					Attributes ["rowspan"] = value.ToString (CultureInfo.InvariantCulture);
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public string VAlign {
			get {
				string s = Attributes ["valign"];
				return (s == null) ? String.Empty : s;
			}
			set {
				if (value == null)
					Attributes.Remove ("valign");
				else
					Attributes ["valign"] = value;
			}
		}

		[DefaultValue ("")]
		[DesignerSerializationVisibility (DesignerSerializationVisibility.Hidden)]
		public string Width {
			get {
				string s = Attributes ["width"];
				return (s == null) ? String.Empty : s;
			}
			set {
				if (value == null)
					Attributes.Remove ("width");
				else
					Attributes ["width"] = value;
			}
		}


		protected override void RenderEndTag (HtmlTextWriter writer)
		{
			writer.WriteEndTag (TagName);
			if (writer.Indent == 0)
				writer.WriteLine ();
		}
	}
}

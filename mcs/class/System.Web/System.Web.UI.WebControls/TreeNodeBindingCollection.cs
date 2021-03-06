//
// System.Web.UI.WebControls.TreeNodeBindingCollection.cs
//
// Authors:
//	Lluis Sanchez Gual (lluis@novell.com)
//
// (C) 2004 Novell, Inc (http://www.novell.com)
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
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
//


using System;
using System.Collections;
using System.Web.UI;

namespace System.Web.UI.WebControls
{
	public sealed class TreeNodeBindingCollection: StateManagedCollection
	{
		static Type[] types = new Type[] { typeof (TreeNodeBinding) };
		
		internal TreeNodeBindingCollection ()
		{
		}
		
		public int Add (TreeNodeBinding binding)
		{
			return ((IList)this).Add (binding);
		}
		
		public bool Contains (TreeNodeBinding binding)
		{
			return ((IList)this).Contains (binding);
		}
		
		public void CopyTo (TreeNodeBinding[] array, int index)
		{
			((IList)this).CopyTo (array, index);
		}
		
		protected override object CreateKnownType (int index)
		{
			return new TreeNodeBinding ();
		}
		
		protected override Type[] GetKnownTypes ()
		{
			return types;
		}
		
		public int IndexOf (TreeNodeBinding binding)
		{
			return ((IList)this).IndexOf (binding);
		}
		
		public void Insert (int index, TreeNodeBinding binding)
		{
			((IList)this).Insert (index, binding);
		}
		
		public void Remove (TreeNodeBinding binding)
		{
			((IList)this).Remove (binding);
		}
		
		public void RemoveAt (int index)
		{
			((IList)this).RemoveAt (index);
		}
		
		public TreeNodeBinding this [int i] {
			get { return (TreeNodeBinding) ((IList)this) [i]; }
			set { ((IList)this) [i] = value; }
		}
		
		protected override void SetDirtyObject (object o)
		{
			((TreeNodeBinding)o).SetDirty ();
		}

		// These three methods are present, but undocumented
		protected override void OnClear ()
		{
			// Why override?
			base.OnClear ();
		}

		protected override void OnRemoveComplete (int index, object value)
		{
			// Why override?
			base.OnRemoveComplete (index, value);
		}

		protected override void OnValidate (object value)
		{
			// Why override?
			base.OnValidate (value);
		}
	}
}


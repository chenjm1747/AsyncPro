using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

namespace ExTapi
{
	/// <summary>
	/// Summary description for Component1.
	/// </summary>
	public class Component1 : System.ComponentModel.Component
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Component1(System.ComponentModel.IContainer container)
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public Component1()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace CustomList
{
	
	[Activity (Label = "CustomList", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private ListView listView;
		List<TableItem> tableItems = new List<TableItem>();

		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			this.listView = this.FindViewById<ListView> (Resource.Id.left_drawer);

			// Get our button from the layout resource,
			// and attach an event to it
			tableItems.Add(new TableItem() { Text = "Map", Image = Resource.Drawable.Icon });
			tableItems.Add(new TableItem() { Text = "Settings", Image = Resource.Drawable.Icon });
			tableItems.Add(new TableItem() { Text = "Users", Image = Resource.Drawable.Icon });

			this.listView.Adapter = new ListAdapter(this, tableItems);

		}
	}
}



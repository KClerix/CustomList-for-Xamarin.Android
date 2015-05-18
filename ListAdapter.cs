using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;
using Android.Views;

namespace CustomList
{
	public class ListAdapter : BaseAdapter<TableItem> {
		List<TableItem> items;
		Activity context;
		public ListAdapter(Activity context, List<TableItem> items)
			: base()
		{
			this.context = context;
			this.items = items;
		}
		public override long GetItemId(int position)
		{
			return position;
		}
		public override TableItem this[int position]
		{
			get { return items[position]; }
		}
		public override int Count
		{
			get { return items.Count; }
		}
		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.listitem, null);
			view.FindViewById<TextView>(Resource.Id.Text1).Text = item.Text;
			view.FindViewById<ImageView>(Resource.Id.Image).SetImageResource(item.Image);
			return view;
		}
	}
}


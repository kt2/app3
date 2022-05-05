using Xamarin.Forms;

namespace App3.ViewModels
{

	public class ProgressSelector : DataTemplateSelector
	{
		public DataTemplate CurrentTemplate { get; set; }

		public DataTemplate NormalTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			return ((Monkey)item).Discovering ? CurrentTemplate : NormalTemplate;
		}
	}
}


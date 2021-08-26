using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HomeQuarantine.Extensions
{
	public static class ObservableExtension
	{
		public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
		{
			ObservableCollection<T> observableCollection = new ObservableCollection<T>();
			foreach (T item in source)
			{
				observableCollection.Add(item);
			}
			return observableCollection;
		}
	}
}

using System.Collections.Generic;
using FFImageLoading.Forms;
using FFImageLoading.Transformations;
using FFImageLoading.Work;
using Xamarin.Forms;

namespace HomeQuarantine.Controls
{
	public class TintedCachedImage : CachedImage
	{
		public static readonly BindableProperty TintColorProperty = BindableProperty.Create("TintColor", typeof(Color), typeof(TintedCachedImage), (object)Color.Transparent, (BindingMode)2, (ValidateValueDelegate)null, new BindingPropertyChangedDelegate(UpdateColor), (BindingPropertyChangingDelegate)null, (CoerceValueDelegate)null, (CreateDefaultValueDelegate)null);

		public Color TintColor
		{
			get
			{
				//IL_000b: Unknown result type (might be due to invalid IL or missing references)
				return (Color)((BindableObject)this).GetValue(TintColorProperty);
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				((BindableObject)this).SetValue(TintColorProperty, (object)value);
			}
		}

		private static void UpdateColor(BindableObject bindable, object oldColor, object newColor)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			Color val = (Color)oldColor;
			Color val2 = (Color)newColor;
			if (!((object)(Color)(ref val)).Equals((object?)val2))
			{
				TintedCachedImage obj = (TintedCachedImage)(object)bindable;
				List<ITransformation> list = new List<ITransformation>();
				TintTransformation val3 = new TintTransformation((int)(((Color)(ref val2)).get_R() * 255.0), (int)(((Color)(ref val2)).get_G() * 255.0), (int)(((Color)(ref val2)).get_B() * 255.0), (int)(((Color)(ref val2)).get_A() * 255.0));
				val3.set_EnableSolidColor(true);
				list.Add((ITransformation)val3);
				List<ITransformation> transformations = list;
				((CachedImage)obj).set_Transformations(transformations);
			}
		}

		public TintedCachedImage()
			: this()
		{
		}
	}
}

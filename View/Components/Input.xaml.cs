using static System.Net.Mime.MediaTypeNames;

namespace ESSIVI.View.Components;

public partial class Input : Border
{
	#region Property

	//***************************PLACEHOLDER************************************************
	
	public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
		propertyName: nameof(Placeholder),
		returnType: typeof(string),
		declaringType: typeof(Input),
		propertyChanged: OnPlaceholderChanged
		);

	static void OnPlaceholderChanged(BindableObject bindable, object oldValue, object newValue)
	{
	if (newValue is not null && bindable is not null)
		{
			var component = bindable as Input;

			component._entry.Placeholder = (string)newValue;
		}
	}

	public string Placeholder
	{
		get => (string)GetValue(PlaceholderProperty);
		set => SetValue(PlaceholderProperty, value);
	}


	//***************************TEXT************************************************


	public static readonly BindableProperty TextProperty = BindableProperty.Create(
		propertyName: nameof(Text),
		returnType: typeof(string),
		declaringType: typeof(Input)
		);


	public string Text => _entry.Text;


	//***************************Type************************************************

	public static readonly BindableProperty TypeProperty = BindableProperty.Create(
		propertyName: nameof(Type),
		returnType: typeof(bool),
		declaringType: typeof(Input),
		propertyChanged: OnTypeChanged
		);

	static void OnTypeChanged(BindableObject bindable, object oldValue, object newValue)
	{
		var component = bindable as Input;
		switch (newValue)
		{
			case "password":
				component._entry.IsPassword = true;
					break;
			default:
				component._entry.IsPassword = false;
				break;
		}
	}

	public string Type
	{
		get => (string)GetValue(TypeProperty);
		set => SetValue(TypeProperty, value);
	}
	#endregion






	public Input()
	{
		InitializeComponent();

		var borderColor = _border.Stroke;

		_entry.Focused += delegate
		{
			_border.Stroke = Color.FromArgb("#22427c");
		};

		_entry.Unfocused += delegate
		{
			_border.Stroke = borderColor;
		};
	}
}
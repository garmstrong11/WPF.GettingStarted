namespace WPF.GettingStarted.Models
{
  using Catel.Data;

  public class Family : ModelBase
  {
    /// <summary>
    /// Gets or sets the family name.
    /// </summary>
    public string FamilyName
    {
      get { return GetValue<string>(FamilyNameProperty); }
      set { SetValue(FamilyNameProperty, value); }
    }

    /// <summary>
    /// Register the FamilyName property so it is known in the class.
    /// </summary>
    public static readonly PropertyData FamilyNameProperty = RegisterProperty(
      "FamilyName",
      typeof(string),
      null);
  }
}
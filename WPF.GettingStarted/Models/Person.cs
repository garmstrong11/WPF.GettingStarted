namespace WPF.GettingStarted.Models
{
  using Catel.Data;

  public class Person : ModelBase
  {
    /// <summary>
    /// Gets or sets the first name of this person.
    /// </summary>
    public string FirstName
    {
      get { return GetValue<string>(FirstNameProperty); }
      set { SetValue(FirstNameProperty, value); }
    }

    /// <summary>
    /// Register the FirstName property so it is known in the class.
    /// </summary>
    public static readonly PropertyData 
      FirstNameProperty = RegisterProperty("FirstName", typeof (string));

    /// <summary>
    /// Gets or sets the property value.
    /// </summary>
    public string LastName
    {
      get { return GetValue<string>(LastNameProperty); }
      set { SetValue(LastNameProperty, value); }
    }

    /// <summary>
    /// Register the LastName property so it is known in the class.
    /// </summary>
    public static readonly PropertyData 
      LastNameProperty = RegisterProperty("LastName", typeof(string));

    public override string ToString()
    {
      var fullName = string.Empty;
      var firstNameNotEmpty = !string.IsNullOrWhiteSpace(FirstName);
      var lastNameNotEmpty = !string.IsNullOrWhiteSpace(LastName);

      if (firstNameNotEmpty) {
        fullName += FirstName;
      }
      if (firstNameNotEmpty && lastNameNotEmpty) {
        fullName += " ";
      }
      if (lastNameNotEmpty) {
        fullName += LastName;
      }

      return fullName;
    }
  }
} 
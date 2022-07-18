using System.Text;

namespace BasicConApp
{
  public static class StringFunctions
  {
    #region isPalindrome
    public static bool isPalindrome(string value)
    {
      StringBuilder sb = new StringBuilder();
      for (int i = value.Length - 1; i >= 0; i--)
      {
        sb.Append(value[i]);
      }
      return sb.ToString().Equals(value);
    }
    #endregion
    
    #region Cardinal to Ordinal
    public static string CardinalToOrdinal(int value)
    {
      switch (value)
      {
        case 11:
        case 12:
        case 13:

          return $"{value}th";
        default:
          {
            int lastDigit = value % 10;
            string suffix = null;
            switch (lastDigit)
            {
              case 1:
                suffix = "st";
                break;
              case 2:
                suffix = "nd";
                break;
              case 3:
                suffix = "rd";
                break;
              default:
                suffix = "th";
                break;
            };
            return $"{value}{suffix}";
          }
      }
    } 
    #endregion


  }
}

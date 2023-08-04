
public static class MessegeValidator
{
    public static  bool IsValidMessage(string content)
    {
        if (string.IsNullOrEmpty(content))
            throw new ArgumentNullException("Content is empty");
        return true;
    }
}

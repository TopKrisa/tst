namespace tst
{
    public static class LabelIsValidate
    {
        public static bool IsValid(this TextBox label)
        {
            if (string.IsNullOrEmpty(label.Text))
                return false;
            return true;
        }
        
        public static void Clear(this TextBox label)=> label.Text = string.Empty;
        public static int ToInt(this string str) => Convert.ToInt32(str);
    }
}

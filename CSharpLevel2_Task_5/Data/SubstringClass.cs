using System.Text;

namespace CSharpLevel2_Task_5.Data
{
    public static class SubstringClass
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder temp = new StringBuilder();

            string result = sb.ToString();
            result = result.Substring(index, length);

            return temp.Append(result);
        }
    }
}

using System;

namespace StringLibrary
{
    public class StringArray
    {
        private string data;  

        
        public StringArray()
        {
            data = string.Empty;
        }

        
        public StringArray(string str)
        {
            data = str;
        }

        
        ~StringArray() { }

        
        public int Length()
        {
            return data.Length;
        }

        
        public void RemoveChar(char c)
        {
            data = data.Replace(c.ToString(), string.Empty);
        }

        
        public string GetData()
        {
            return data;
        }
    }
}

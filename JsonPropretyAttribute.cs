namespace CityApp
{
    internal class JsonPropretyAttribute : Attribute
    {
        private string v;

        public JsonPropretyAttribute(string v)
        {
            this.v = v;
        }
    }
}
namespace TwitterSystem.Web
{
    using System.Web.Mvc;

    public static class ViewEnginesConfig
    {
        public static void RegisterViewEngines(ViewEngineCollection viewEngine)
        {
            viewEngine.Clear();
            viewEngine.Add(new RazorViewEngine());
        }
    }
}
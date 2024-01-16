namespace WebApplication1.Helper
{
    public class NavigationHelper
    {
        public static string IsPageActive(string currentPage, string targetPage)
        {
            return currentPage == targetPage ? "active" : "";
        }
    }
}

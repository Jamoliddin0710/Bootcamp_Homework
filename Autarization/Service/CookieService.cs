namespace Autarization.Service
{
    public class CookieService
    {
        public string?  GetUserFromCookies(HttpContext context )
        {
            if (context.Request.Cookies.ContainsKey("Password"))
                {
                return context.Request.Cookies["Password"];
                }
            return null;
        }

        public void SendUserFromCookies(HttpContext context , string Password)
        {
            context.Response.Cookies.Append("Password", Password);
        }
    }
}

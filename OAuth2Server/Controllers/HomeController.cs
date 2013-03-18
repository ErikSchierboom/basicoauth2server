namespace OAuth2Server.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// This controller will server as a test client, allowing the user
    /// </summary>
    [RequireHttps]
    public class HomeController : Controller
    {
        /// <summary>
        /// This action will show a short introduction on what can be done with this website.
        /// </summary>
        /// <returns>The view result.</returns>
        [HttpGet]
        public ViewResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// This action will allow the user to expirement with the OAuth 2 client credentials grant workflow. 
        /// </summary>
        /// <remarks>See: http://tools.ietf.org/html/rfc6749#section-4.4 </remarks>
        /// <returns>The view result.</returns>
        [HttpGet]
        public ViewResult ClientCredentialsGrant()
        {
            return this.View();
        }

        /// <summary>
        /// This action will allow the user to expirement with the OAuth 2 resource owner credentials grant workflow.
        /// </summary>
        /// <remarks>See: http://tools.ietf.org/html/rfc6749#section-4.3 </remarks>
        /// <returns>The view result.</returns>
        [HttpGet]
        public ViewResult ResourceOwnerCredentialsGrant()
        {
            return this.View();
        }

        /// <summary>
        /// This action will allow the user to expirement with the OAuth 2 resource owner credentials grant workflow.
        /// </summary>
        /// <remarks>See: http://tools.ietf.org/html/rfc6749#section-6 </remarks>
        /// <returns>The view result.</returns>
        [HttpGet]
        public ViewResult RefreshToken()
        {
            return this.View();
        }
    }
}
using CzomPack.Network;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace HardverApro.NET
{
    public class Authenticaton
    {
        public async Task<LoginRespose> Login(string email, string password)
        {

            var initResponse = NetHandler.GetRequestData(Endpoints.Auth, RequestMethod.GET, $"HardverApro.NET/{Assembly.GetCallingAssembly().GetName().Version:4}");

            const form = generateFormData(initResponse.body, email, password);
            const cookieString = extractInitCookie(initResponse);

            const authResponse = await request.post(request.endpoints.AUTH, form, cookieString);

            const authBody = JSON.parse(authResponse.body);
            if (authBody.hasOwnProperty("message") && authBody["message"] == "Sikeres belépés, rögtön továbbítunk...")
            {
                return extractAuthCookieString(authResponse);
            }
            else
            {
                return extractErrorMessage(authBody);
            }
        }
    }
}

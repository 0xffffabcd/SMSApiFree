using System;
using System.Net;
using System.Threading.Tasks;

namespace FreeSMSLib
{
    public class FreeSMSLib
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public FreeSMSLib(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username is mandatory",nameof(username));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password is mandatory",nameof(password));
            }

            Username = username;
            Password = password;
        }

        public async Task<bool> SendNotification(string message)
        {
            var errorMessage = string.Empty;
            var destinationUri = new Uri(
                $"https://smsapi.free-mobile.fr/sendmsg?user={Username}&pass={Password}&msg={message}");
            try
            {
                var request = WebRequest.CreateHttp(destinationUri);
                var response = (HttpWebResponse) (await request.GetResponseAsync());

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch (WebException e)
            {
                var httpWebResponse = e.Response as HttpWebResponse;
                if (httpWebResponse == null) throw new Exception(errorMessage, e);

                switch (httpWebResponse.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        errorMessage = "Missing parameter(s).";
                        break;
                    case HttpStatusCode.PaymentRequired:
                        errorMessage = "Too many SMS' sent in a short period";
                        break;
                    case HttpStatusCode.Forbidden:
                        errorMessage = "Username/Password incorrect or service not activated";
                        break;
                    case HttpStatusCode.InternalServerError:
                        errorMessage = "Server error. try again later";
                        break;
                    default:
                        errorMessage = "Unknown error. Check the innerException for more info";
                        break;
                }

                throw new Exception(errorMessage, e);
            }
            return false;
        }

        
    }
}

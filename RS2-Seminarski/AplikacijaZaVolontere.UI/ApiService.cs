using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.ViewModels;
using Flurl;
using Flurl.Http;
using System.Windows.Forms;
namespace AplikacijaZaVolontere.UI
{
    public class ApiService
    {
        private string _route = null;
        public static string Token { get; set; }
        public ApiService(string route)
        {
            _route = route;
        }
        public async Task <T> Get<T>()
        {
            try
            {

            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
            return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> GetSearch<T>(object  request)
        {
            try
            {

            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
            return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> GetByID<T>(object id)
        {
            try
            {

            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            var result = await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
            return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {

            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>(); 
            return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> Prijava<T>(object request)
        {
            try
            {

                var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
                var result = await url.PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
        public async Task<T> Update<T>(object request)
        {
            try
            {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            var result = await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>();
            return result;

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == 401)
                {
                    MessageBox.Show("Neuspješna autentifikacija.");
                }
                if (ex.Call.Response.StatusCode == 403)
                {
                    MessageBox.Show("Nemate permisije za pristup ovom resursu.");
                }
                throw;
            }
        }
    }
}

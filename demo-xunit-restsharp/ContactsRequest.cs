﻿using RestSharp;
using System.Net;
using Xunit;

namespace PhoneBookTest
{
    public class ContactsRequest
    {

        public void PostContact(string name, string mobilephone, string homephone, HttpStatusCode code)
        {
            var client = new RestClient($"{DomainRequest.URL}/contacts");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { name, mobilephone, homephone });

            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.Equal(code, statusCode);
        }

        public void GetContact(string parameter_type, string parameter_content, HttpStatusCode code)
        {
            RestClient client = new RestClient($"{DomainRequest.URL}/contacts?{parameter_type}={parameter_content}");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.Equal(code, statusCode);

            /////// Implementar a validação do JSON
            //var message = response.Content;
            //message.Should().BeEquivalentTo("");
        }

        public void PutContact(string id, string name, string mobilephone, string homephone, HttpStatusCode code, HttpResponseHeader res)
        {
            var client = new RestClient($"{DomainRequest.URL}/contacts/{id}");
            var request = new RestRequest(Method.PUT);

            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { name, mobilephone, homephone });

            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.Equal(code, statusCode);


            var statusMsg = response.Content;
            Assert.Equal(res.ToString(), statusMsg); //YAHA
        }

        public void DeleteContact(string id, HttpStatusCode code)
        {
            var client = new RestClient($"{DomainRequest.URL}/contacts/{id}");
            var request = new RestRequest(Method.DELETE);

            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.Equal(code, statusCode);
        }
    }
}


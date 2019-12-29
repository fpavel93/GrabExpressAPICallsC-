using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public class APICallMethods
{

    // Holds the API URL
    String apiUrl;

    private static APICallMethods instance = null;

    private APICallMethods()
    {
        // API URL initialization
        apiUrl = "https://partner-api.grab.com/grab-express/v1/grab-express/v1/deliveries";
    }

    public static APICallMethods getInstance()
    {
        if (instance == null)
        {
            instance = new APICallMethods();
        }
        return instance;
    }

    //Post Method: Request for delivery service
    public GetDelivery delivery(DeliveryPost delivery)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
        GetDelivery result = null;

        string data = JsonConvert.SerializeObject(delivery);
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);

        request.ContentLength = dataBytes.Length;
        request.ContentType = "application/json";
        request.Method = "POST";

        using (Stream requestBody = request.GetRequestStream())
        {
            requestBody.Write(dataBytes, 0, dataBytes.Length);
        }

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            //if responseCode is OK return GetDelivery object from the response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<GetDelivery>(reader.ReadToEnd());

                //if responseCode is HTTP_BAD_REQUEST, HTTP_NOT_FOUND or HTTP_CONFLICT
                //get the message from the response and print to the console
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == HttpStatusCode.Conflict)
            {
                Error error1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(reader.ReadToEnd());
                Console.WriteLine(error1.Message);
            }
            else
            {
                Console.WriteLine("ERROR: Connection refused");
            }

        }
        return result;
    }

    //Post Method: Request for delivery service quotes
    public Quotes deliveryQuotes(DeliveryPostQuotes delivery)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl + "/quotes");
        Quotes result = null;

        string data = JsonConvert.SerializeObject(delivery);
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);

        request.ContentLength = dataBytes.Length;
        request.ContentType = "application/json";
        request.Method = "POST";

        using (Stream requestBody = request.GetRequestStream())
        {
            requestBody.Write(dataBytes, 0, dataBytes.Length);
        }

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            //if responseCode is OK return Quotes object from the response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<Quotes>(reader.ReadToEnd());

                //if responseCode is HTTP_BAD_REQUEST, HTTP_NOT_FOUND or HTTP_CONFLICT
                //get the message from the response and print to the console
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == HttpStatusCode.Conflict)
            {
                Error error1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(reader.ReadToEnd());
                Console.WriteLine(error1.Message);
            }
            else
            {
                Console.WriteLine("ERROR: Connection refused");
            }

        }
        return result;
    }

    //Get Method: Get the full information of a delivery
    public GetDelivery getDelivery(int id)
    {
        GetDelivery result = null;

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl + "/" + id);

        request.Method = "GET";

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            //if responseCode is OK return GetDelivery object from the response
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result = Newtonsoft.Json.JsonConvert.DeserializeObject<GetDelivery>(reader.ReadToEnd());

                //if responseCode is HTTP_BAD_REQUEST or HTTP_NOT_FOUND
                //get the message from the response and print to the console
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.NotFound)
            {
                Error error1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(reader.ReadToEnd());
                Console.WriteLine(error1.Message);
            }
            else
            {
                Console.WriteLine("ERROR: Connection refused");
            }

        }
        return result;
    }

    //Delete Method: Cancel a delivery
    public void deleteDelivery(int id)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl + "/" + id);

        request.Method = "DELETE";

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            //if responseCode is OK print Delivery deleted to the console
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine("Delivery deleted");
                //if responseCode is HTTP_BAD_REQUEST, HTTP_NOT_FOUND or HTTP_CONFLICT
                //get the message from the response and print to the console
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == HttpStatusCode.Conflict)
            {
                Error error1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Error>(reader.ReadToEnd());
                Console.WriteLine(error1.Message);
            }
            else
            {
                Console.WriteLine("ERROR: Connection refused");
            }
        }
    }
}
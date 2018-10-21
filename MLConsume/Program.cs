using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MLConsume
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await InvokeRequestResponseService();
        }

        static async Task InvokeRequestResponseService()
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "symboling", "3"
                                            },
                                            {
                                                "normalized-losses", "1"
                                            },
                                            {
                                                "make", "alfa-romero"
                                            },
                                            {
                                                "fuel-type", "gas"
                                            },
                                            {
                                                "aspiration", "std"
                                            },
                                            {
                                                "num-of-doors", "two"
                                            },
                                            {
                                                "body-style", "convertible"
                                            },
                                            {
                                                "drive-wheels", "rwd"
                                            },
                                            {
                                                "engine-location", "front"
                                            },
                                            {
                                                "wheel-base", "88.6"
                                            },
                                            {
                                                "length", "168.8"
                                            },
                                            {
                                                "width", "64.1"
                                            },
                                            {
                                                "height", "48.8"
                                            },
                                            {
                                                "curb-weight", "2548"
                                            },
                                            {
                                                "engine-type", "dohc"
                                            },
                                            {
                                                "num-of-cylinders", "four"
                                            },
                                            {
                                                "engine-size", "130"
                                            },
                                            {
                                                "fuel-system", "mpfi"
                                            },
                                            {
                                                "bore", "3.47"
                                            },
                                            {
                                                "stroke", "2.68"
                                            },
                                            {
                                                "compression-ratio", "9"
                                            },
                                            {
                                                "horsepower", "111"
                                            },
                                            {
                                                "peak-rpm", "5000"
                                            },
                                            {
                                                "city-mpg", "21"
                                            },
                                            {
                                                "highway-mpg", "27"
                                            },
                                            {
                                                "price", "13495"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                const string apiKey = "8Oowmhmt4+VjZs38NzAsRdb48gXsXXwhpfxP7Tp6fcstExxLeomNt9FDhK37G+NBHqmrWvS5TeBc8zu/pQlcVw=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://europewest.services.azureml.net/workspaces/42d606822f144b4daf8ded5246815466/services/133f33c903bc478a972776b833681e86/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp,
                    // which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }

                Console.ReadLine();
            }
        }
    }
}

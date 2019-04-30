using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Tesla.Web.Models;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Project.Tesla.Web.ApiClients
{
    public class SessionAPI
    {          
        public async Task<string> CreateSession(Sessions session)
        {
            try
            {
                var client = new HttpClient();

                //client.BaseAddress = new System.Uri("https://project-tesla-api.azurewebsites.net");

                // client.DefaultRequestHeaders.Add("Accept", "application/json");

                //  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");

                client.DefaultRequestHeaders.Add("x-functions-key", "5AjR3SEyA/hLqncy4zr6nqw96JmyaVJ3ZbkzhwwN8S55ebUstrgaaA==");

                List<Behavior> behaviors = new List<Behavior>();

                var behavior1 = new Behavior
                {
                    BehaviorId="1",
                    BehaviorName = "shouting"
                };

                var behavior2 = new Behavior
                {
                    BehaviorId = "2",
                    BehaviorName = "ignoring"
                };

                behaviors.Add(behavior1);
                behaviors.Add(behavior2);
              
                // var finalBehaviors = JsonConvert.SerializeObject(behaviors);

                var sessionContent = new
                {
                    ActivityName = session.ActivityName,
                    Type = "session",
                    Status = "started",
                    ChildID = session.ChildName,
                    TherapistId = "100",
                    RewardGoal = session.RewardGoal,
                    ActivityDuration = session.ActivityDuration,
                    StartingReward = "2",
                    NotificationType = "vibrate",
                    Behaviors = behaviors
                };

                var finalContent = JsonConvert.SerializeObject(sessionContent);

                var result = await client.PostAsync("https://project-tesla-api.azurewebsites.net/api/session", new StringContent(finalContent, Encoding.UTF8, "application/json"));
                                
                string sessionId = string.Empty;

                if (result.IsSuccessStatusCode)
                {
                    sessionId = await result.Content.ReadAsStringAsync();
                }
               
                return sessionId;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}

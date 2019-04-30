using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Project.Tesla.Web.Models
{
    public class Sessions
    {
        public string Id { get; set; }    
        public string Type { get; set; }   
        public string ActivityName { get; set; }
        public string ChildName { get; set; }
        public string RewardGoal { get; set; }
        public string ActivityDuration { get; set; }
        public string Behaviors { get; set; }
      

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

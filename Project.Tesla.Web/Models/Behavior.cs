using Newtonsoft.Json;

namespace Project.Tesla.Web.Models
{
    public class Behavior
    {
        public string BehaviorId { get; set; }
        public string BehaviorName { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

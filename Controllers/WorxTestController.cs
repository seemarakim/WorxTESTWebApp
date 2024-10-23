using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace WorxTESTWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorxTestController : Controller
    {
        [HttpGet]
        public string GetWorkOrderJSON(string WorkOrderNum)
        {
            string RawJSONResult = "Empty";
            //PLACEHOLDER FOR RETRIEVING RAW JSON STRING
            //Retrieving JSON file with queried work order number=============================================
            foreach (var item in Directory.GetFiles("C:\\Users\\Seems\\Documents\\Custom Projects\\Arthrex"))
            {
                if (item.Contains(WorkOrderNum))
                {
                    RawJSONResult = System.IO.File.ReadAllText(item);
                }
            }
            //================================================================================================
            return RawJSONResult;          
        }     
    }
}

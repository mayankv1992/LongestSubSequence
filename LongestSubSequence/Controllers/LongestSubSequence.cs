using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace LongestSubSequence.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LongestSubSequenceAPI : ControllerBase
    {
        //private const string Pattern = "^[\d\s]+$";
        private readonly ILogger<LongestSubSequenceAPI> _logger;

        public LongestSubSequenceAPI(ILogger<LongestSubSequenceAPI> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string Post(string strInput)
        {
            string strOutput = string.Empty;
          
            if (string.IsNullOrEmpty(strInput))
            {
                return string.Empty;
            }
            //else if (Regex.IsMatch(strInput, Pattern))
            //{
            //    return string.Empty;
            //}
            else
            {
                return LongestSubSeqAPI.LongestSubSeq(strInput);
            }
                       
        }
    }
}

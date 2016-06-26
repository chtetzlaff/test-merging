using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibStandard
{
    /// <summary>
    /// The ultimate parser
    /// </summary>
    public class Parser
    {
        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Stream InputSource { get; set; }
    }
}

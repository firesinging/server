using System.Collections.Generic;
using SuperSocket.SocketBase.Metadata;

namespace Libraries.manager.models
{
    
    /// <summary>
    /// Login command result
    /// </summary>
    public class LoginResult : CommandResult
    {
        
        /// <summary>
        /// Gets or sets the server metadata source.
        /// </summary>
        /// <value>
        /// The server metadata source.
        /// </value>
        public List<KeyValuePair<string, StatusInfoAttribute[]>> ServerMetadataSource { get; set; }

    }

}

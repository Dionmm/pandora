using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.EventHub.v2021_01_01_preview.AuthorizationRulesEventHubs
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "3865f04d22e82db481be0727b406021d29cd2b70" 

        public string ApiVersion => "2021-01-01-preview";
        public string Name => "AuthorizationRulesEventHubs";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new EventHubsCreateOrUpdateAuthorizationRuleOperation(),
            new EventHubsListAuthorizationRulesOperation(),
            new EventHubsListKeysOperation(),
            new EventHubsRegenerateKeysOperation(),
        };
    }
}

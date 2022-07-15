using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamailio.VisualStudio
{
#pragma warning disable 649
    public class KamailioContentDefinition
    {
        [Export]
        [Name("kamailio")]
        [BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
        internal static ContentTypeDefinition KamailioContentTypeDefinition;

        [Export]
        [FileExtension(".cfg")]
        [ContentType("kamailio")]
        internal static FileExtensionToContentTypeDefinition KamailioFileExtensionDefinition;
    }
#pragma warning restore 649
}

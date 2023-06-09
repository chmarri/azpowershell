﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSNodeFile
    {
        
        internal Microsoft.Azure.Batch.NodeFile omObject;
        
        private PSFileProperties properties;
        
        internal PSNodeFile(Microsoft.Azure.Batch.NodeFile omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public System.Boolean? IsDirectory
        {
            get
            {
                return this.omObject.IsDirectory;
            }
        }
        
        public string Path
        {
            get
            {
                return this.omObject.Path;
            }
        }
        
        public PSFileProperties Properties
        {
            get
            {
                if (((this.properties == null) 
                            && (this.omObject.Properties != null)))
                {
                    this.properties = new PSFileProperties(this.omObject.Properties);
                }
                return this.properties;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
    }
}

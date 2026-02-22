using System;
using System.Collections.Generic;
using System.Text;

namespace JobAssistant.Domain.Entities
{
    public class JobPosting
    {
       /// <summary>
       /// Gets or sets the title associated with the object.
       /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the company associated with the object.
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// Gets or sets the location associated with the object.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the description associated with the object.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the apply link associated with the object.
        /// </summary>
        public string ApplyLink { get; set; }

    }
}

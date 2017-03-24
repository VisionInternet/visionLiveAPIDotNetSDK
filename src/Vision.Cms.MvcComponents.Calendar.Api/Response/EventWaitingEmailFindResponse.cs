﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Vision.Api.Common;
using Vision.Api.Common.Domain;
using Vision.Cms.MvcComponents.Calendar.Api.Domain;
using Vision.Cms.MvcComponents.Calendar.Api.Request;

namespace Vision.Cms.MvcComponents.Calendar.Api.Response
{
    [ApiResponse]
    [XmlRoot(Namespace = ApiConstant.DEFAULT_DATACONTRACT_NAMESPACE)]
    public class EventWaitingEmailFindResponse : Vision.Api.Common.ApiResponse<EventWaitingEmailFindRequest>
    {
        [XmlElement]
        [ApiResponseProperty]
        public PagingList<EventWaitingEmail> PagingList { get; set; }
    }
}

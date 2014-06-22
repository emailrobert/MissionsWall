//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Diagnostics;

namespace DoSomethingWeb
{

    [Serializable]

    [ServiceContract(Namespace = "DoSomethingWeb")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    public class dsservice
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public dosomething GetDoSomething(Guid dsId)
        {
            try
            {
                DoSomethingDataContext ds = new DoSomethingDataContext();

                var ddata = from d in ds.dosomethings
                              where d.Id == dsId
                              select d;

                dosomething dd = ddata.First<dosomething>();
                return dd;

            }
            catch (Exception ex)
            {
                throw new Exception("Error finding DoSomething " + ex.Message);
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public dosomething[] GetAllDoSomethings()
        {
            try
            {
                DoSomethingDataContext ds = new DoSomethingDataContext();
                var dss = from i in ds.dosomethings
                                  select i;
                dosomething[] ii = dss.ToArray<dosomething>();
                return ii;
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Getting All DoSomethings", ex.Message);
                return null;
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void AddDoSomething(string contactname, string contactemail, string contactareacode, string contactprefix, string contactnumber, string eventtitle, string eventdesc, string eventlocation, string startdate, string starttime, string enddate, string endtime)
        //public void AddDoSomething(string contactname, string contactemail)
        {
            try
            {
                Guid newg = Guid.NewGuid();
                dosomething d = new dosomething
                {
                    Id = newg,
                    contactname = contactname,
                    contactemail = contactemail,
                    contactareacode = contactareacode,
                    contactprefix = contactprefix,
                    contactnumber = contactnumber,
                    eventtitle = eventtitle,
                    eventdesc = eventdesc,
                    eventlocation = eventlocation,
                    startdate = startdate,
                    starttime = starttime,
                    enddate = enddate,
                    endtime = endtime
                };

                DoSomethingDataContext ds = new DoSomethingDataContext();
                ds.dosomethings.InsertOnSubmit(d);
                ds.SubmitChanges();

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Adding DoSomething", ex.Message);
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void UpdateDoSomething(Guid dsId, string eventtitle, string eventdesc, string eventlocation)
        //public void AddDoSomething(string contactname, string contactemail)
        {
            try
            {

                DoSomethingDataContext ds = new DoSomethingDataContext();

                var sl = from n in ds.dosomethings
                         where n.Id == dsId
                         select n;

                dosomething s = sl.First<dosomething>();

                s.eventtitle = eventtitle;
                s.eventdesc = eventdesc;
                s.eventlocation = eventlocation;             
                ds.SubmitChanges();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Updating DoSomething", ex.Message);
            }
        }

    }
}

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
using System.Configuration;

namespace DoSomethingWeb
{

    [Serializable]

    [ServiceContract(Namespace = "DoSomethingWeb")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    public class dsservice
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void DeleteDoSomething(Guid dsId)
        {
            try
            {
                DoSomethingDataContext cg = new DoSomethingDataContext();

                var ds = from v in cg.dosomethings
                             where v.Id == dsId
                             select v;

                dosomething rv = ds.First<dosomething>();
                cg.dosomethings.DeleteOnSubmit(rv);
                cg.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting Do Something " + ex.Message);
            }
        }

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
                          orderby i.submissiondate descending
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
        public dosomething[] GetAllApprovedDoSomethings()
        {
            try
            {
                DoSomethingDataContext ds = new DoSomethingDataContext();
                var dss = from i in ds.dosomethings
                          where i.approved == true && ( i.startdate == "" || Convert.ToDateTime(i.startdate) >= DateTime.Today)
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
        public void AddDoSomething(string contactname, string contactemail, string contactareacode, string contactprefix, string contactnumber, string eventtitle, string eventdesc, string eventlocation, string startdate, string starttime, string enddate, string endtime, bool approved, string submittername, string submitteremail)
        {
            try
            {
                Guid newg = Guid.NewGuid();
                dosomething d = new dosomething
                {
                    Id = newg,
                    submittername = submittername,
                    submitteremail = submitteremail,
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
                    endtime = endtime,
                    approved = approved,
                    submissiondate = DateTime.Now.ToString()
                };

                DoSomethingDataContext ds = new DoSomethingDataContext();
                ds.dosomethings.InsertOnSubmit(d);
                ds.SubmitChanges();

                string managers = ConfigurationManager.AppSettings["DoSomethingManagers"];

                string messagebody = "A new Do Something posting has been submitted!" + Environment.NewLine + Environment.NewLine + contactname + Environment.NewLine + contactemail + Environment.NewLine + contactareacode + "-" + contactprefix + "-" + contactnumber + Environment.NewLine + eventtitle + Environment.NewLine + eventdesc + Environment.NewLine + eventlocation + Environment.NewLine + "http://manage.visitcrossway.org";
                string customerbody = "Thank you for your Do Something posting!" + Environment.NewLine + Environment.NewLine + contactname + Environment.NewLine + contactemail + Environment.NewLine + contactareacode + "-" + contactprefix + "-" + contactnumber + Environment.NewLine + eventtitle + Environment.NewLine + eventdesc + Environment.NewLine + eventlocation + Environment.NewLine + "Once approved, your post will show up on the live display wall!" + Environment.NewLine + "Go to the live display wall here:" + Environment.NewLine + "http://ministrywall.visitcrossway.org";

                Globals gf = new Globals();
                gf.MailMessage("dosomething@visitcrossway.org", managers, "Do Something Submission", messagebody, "");
                gf.MailMessage("dosomething@visitcrossway.org", submitteremail, "Do Something Submission", customerbody, "");
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Adding DoSomething", ex.Message);
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void UpdateDoSomething(Guid dsId, string eventtitle, string eventdesc, string eventlocation, bool approved, string startdate)
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
                s.approved = approved;
                s.startdate = startdate;
                ds.SubmitChanges();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Updating DoSomething", ex.Message);
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void UpdateDoSomethings(Guid dsId, string contactname, string contactemail, string contactareacode, string contactprefix, string contactnumber, string eventtitle, string eventdesc, string eventlocation, string startdate, string starttime, string enddate, string endtime)
        {
            try
            {

                DoSomethingDataContext ds = new DoSomethingDataContext();

                var sl = from n in ds.dosomethings
                         where n.Id == dsId
                         select n;

                dosomething s = sl.First<dosomething>();

                s.contactname = contactname;
                s.contactemail = contactemail;
                s.contactareacode = contactareacode;
                s.contactprefix = contactprefix;
                s.contactnumber = contactnumber;
                s.eventtitle = eventtitle;
                s.eventdesc = eventdesc;
                s.eventlocation = eventlocation;
                s.startdate = startdate;
                s.starttime = starttime;
                s.enddate = enddate;
                s.endtime = endtime;
                s.approved = false;
                s.submissiondate = DateTime.Now.ToString();
                ds.SubmitChanges();

                string managers = ConfigurationManager.AppSettings["DoSomethingManagers"];

                string messagebody = "A Do Something has been updated." + Environment.NewLine + Environment.NewLine + contactname + Environment.NewLine + contactemail + Environment.NewLine + contactareacode + "-" + contactprefix + "-" + contactnumber + Environment.NewLine + eventtitle + Environment.NewLine + eventdesc + Environment.NewLine + eventlocation + Environment.NewLine + "http://manage.visitcrossway.org";
                string customerbody = "Thank you for updating your Do Something posting!" + Environment.NewLine + Environment.NewLine + contactname + Environment.NewLine + contactemail + Environment.NewLine + contactareacode + "-" + contactprefix + "-" + contactnumber + Environment.NewLine + eventtitle + Environment.NewLine + eventdesc + Environment.NewLine + eventlocation + Environment.NewLine + "If you ever need to update or change this event click this link:" + Environment.NewLine + "http://visitcrossway.com/es.html?uid=" + dsId + Environment.NewLine + Environment.NewLine + "Once approved, your post will show up on the live display wall!" + Environment.NewLine + Environment.NewLine + "Go to the live display wall here:" + Environment.NewLine + "http://ministrywall.visitcrossway.org";

                Globals gf = new Globals();
                gf.MailMessage("dosomething@visitcrossway.org", managers, "Do Something Updated", messagebody, "");
                gf.MailMessage("dosomething@visitcrossway.org", s.submitteremail, "Do Something Updated", customerbody, "");

            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Updating DoSomethings", ex.Message);
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void ChangeDoSomethingStatus(Guid dsId, bool approved)
        {
            try
            {

                DoSomethingDataContext ds = new DoSomethingDataContext();

                var sl = from n in ds.dosomethings
                         where n.Id == dsId
                         select n;
                dosomething s = sl.First<dosomething>();
                s.approved = approved;

                ds.SubmitChanges();

                if (approved == true)
                {
                    string customerbody = "Your Do Something Posting Has Been Approved!" + Environment.NewLine + s.eventtitle + Environment.NewLine + s.eventdesc + Environment.NewLine + s.eventlocation + Environment.NewLine + Environment.NewLine + "If you ever need to update or change this event click this link:" + Environment.NewLine + "http://visitcrossway.com/es.html?uid=" + dsId + Environment.NewLine + Environment.NewLine + "You can see your posting live here!" + Environment.NewLine + "http://ministrywall.visitcrossway.org";
                    Globals gf = new Globals();
                    gf.MailMessage("dosomething@visitcrossway.org", s.submitteremail, "Do Something Approved!", customerbody, "");
                }
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Updating DoSomething Status", ex.Message);
            }
        }

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public void SendUpdateEmail(Guid dsId)
        {
            try
            {
                DoSomethingDataContext ds = new DoSomethingDataContext();

                var sl = from n in ds.dosomethings
                         where n.Id == dsId
                         select n;
                dosomething s = sl.First<dosomething>();

                string customerbody = "Your Do Something Update Link for this post" + Environment.NewLine + Environment.NewLine + s.eventtitle + Environment.NewLine + s.eventdesc + Environment.NewLine + s.eventlocation + Environment.NewLine + Environment.NewLine + "Click this link to update this post:" + Environment.NewLine + "http://visitcrossway.com/es.html?uid=" + dsId + Environment.NewLine + Environment.NewLine + "You can see your posting live here once approved:" + Environment.NewLine + "http://ministrywall.visitcrossway.org";
                Globals gf = new Globals();
                gf.MailMessage("dosomething@visitcrossway.org", s.submitteremail, "Do Something Update Link", customerbody, "");
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error Updating DoSomething Status", ex.Message);
            }
        }

    }
}

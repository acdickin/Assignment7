using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Assignment7.DataAccess;
using System.Data;

namespace Assignment7
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommunityAssistServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CommunityAssistServices.svc or CommunityAssistServices.svc.cs at the Solution Explorer and start debugging.
    public class CommunityAssistServices : ICommunityAssistServices
    {
     

        public List<ComService> getServices()
        {
            CommunityServiceDB cs = new CommunityServiceDB();
            DataTable table = cs.getServices();
            List<ComService> serv = new List<ComService>();
            foreach (DataRow row in table.Rows)
            {
                ComService c = new ComService();
                c.servicename = row["ServiceName"].ToString();
                c.servicedescription = row["ServiceDescription"].ToString();
                serv.Add(c);

            }
            return serv;
        }
    }
}

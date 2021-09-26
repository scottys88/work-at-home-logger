using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ClassLibrary
{
    public class User
    {
        public User()
        {

        }
        public User(int userId)
        {
            UserId = userId;
            IpAddresses = new List<IpAddressDetail>();
            WorkDayList = new List<WorkDay>();
        }

        public int UserId { get; private set; }
        public string Name { get; set; }
        public List<IpAddressDetail> IpAddresses { get; set; }

        public bool IsAutomaticallyStartWorkDay { get; private set; }

        public List<WorkDay> WorkDayList { get; set; }

        
        public bool HasMatchingIpAddress()
        {
            var MachineIpAddresses = IpAddress.GetIpAddresses();
            List<string> MachineIpAddressesList = new List<string>();
            foreach (IPAddress ip in MachineIpAddresses)
            {
                MachineIpAddressesList.Add(ip.ToString());
            }         
            
            var matchIps = IpAddresses
                .Where(i => MachineIpAddressesList.Contains(i.IpAddress))
                .ToList();

            return matchIps.Count > 0;            
        }

        public WorkDay CreateNewWorkDay()
        {
            var workdayRepository = new WorkDayRepository();
            var workDay = workdayRepository.Retrieve();

            workDay.StartTime = new DateTimeOffset(DateTime.Now);
            workDay.EndTime = new DateTimeOffset(DateTime.Now.AddHours(8));

            return workDay;
        }
    }
}

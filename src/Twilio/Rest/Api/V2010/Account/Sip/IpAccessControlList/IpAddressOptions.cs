using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Sip.IpAccessControlList 
{

    /// <summary>
    /// ReadIpAddressOptions
    /// </summary>
    public class ReadIpAddressOptions : ReadOptions<IpAddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The ip_access_control_list_sid
        /// </summary>
        public string PathIpAccessControlListSid { get; }

        /// <summary>
        /// Construct a new ReadIpAddressOptions
        /// </summary>
        ///
        /// <param name="pathIpAccessControlListSid"> The ip_access_control_list_sid </param>
        public ReadIpAddressOptions(string pathIpAccessControlListSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateIpAddressOptions
    /// </summary>
    public class CreateIpAddressOptions : IOptions<IpAddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The ip_access_control_list_sid
        /// </summary>
        public string PathIpAccessControlListSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The ip_address
        /// </summary>
        public string IpAddress { get; }

        /// <summary>
        /// Construct a new CreateIpAddressOptions
        /// </summary>
        ///
        /// <param name="pathIpAccessControlListSid"> The ip_access_control_list_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="ipAddress"> The ip_address </param>
        public CreateIpAddressOptions(string pathIpAccessControlListSid, string friendlyName, string ipAddress)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            FriendlyName = friendlyName;
            IpAddress = ipAddress;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (IpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAddress", IpAddress));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchIpAddressOptions
    /// </summary>
    public class FetchIpAddressOptions : IOptions<IpAddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The ip_access_control_list_sid
        /// </summary>
        public string PathIpAccessControlListSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchIpAddressOptions
        /// </summary>
        ///
        /// <param name="pathIpAccessControlListSid"> The ip_access_control_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchIpAddressOptions(string pathIpAccessControlListSid, string pathSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateIpAddressOptions
    /// </summary>
    public class UpdateIpAddressOptions : IOptions<IpAddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The ip_access_control_list_sid
        /// </summary>
        public string PathIpAccessControlListSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The ip_address
        /// </summary>
        public string IpAddress { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateIpAddressOptions
        /// </summary>
        ///
        /// <param name="pathIpAccessControlListSid"> The ip_access_control_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateIpAddressOptions(string pathIpAccessControlListSid, string pathSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAddress", IpAddress));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteIpAddressOptions
    /// </summary>
    public class DeleteIpAddressOptions : IOptions<IpAddressResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The ip_access_control_list_sid
        /// </summary>
        public string PathIpAccessControlListSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteIpAddressOptions
        /// </summary>
        ///
        /// <param name="pathIpAccessControlListSid"> The ip_access_control_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteIpAddressOptions(string pathIpAccessControlListSid, string pathSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}
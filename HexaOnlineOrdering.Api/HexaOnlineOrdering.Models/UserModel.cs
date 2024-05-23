using System;
using System.Collections.Generic;
using System.Linq;

namespace HexaOnlineOrdering.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public int UserRoleId { get; set; }
        public string Role { get; set; }
        public List<ProductTypeModel> AdminProductTypePermission { get; set; }
        public int? ContactId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime LastUpdate { get; set; }
        public string DisplayPicture { get; set; }
        public List<DoctorContactModel> Doctors { get; set; } = new List<DoctorContactModel>();
        public List<ClinicContactModel> Clinics { get; set; } = new List<ClinicContactModel>();

        public List<int> AdminProductTypeId
        {
            get 
            { 
                if(AdminProductTypePermission != null)
                {
                    return AdminProductTypePermission.Select(s => s.Id).ToList();
                }
                return null;
            }
        }
    }

    public class SubContactModel
    {
        public List<DoctorContactModel> Doctors { get; set; } = new List<DoctorContactModel>();
        public List<ClinicContactModel> Clinics { get; set; } = new List<ClinicContactModel>();
    }
}

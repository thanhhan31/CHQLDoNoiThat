using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBusiness
{
    public class AccountObject
    {
        private string _id;
        private string _name;
        private DateTime _dob;
        private string _gender;
        private string _phone;
        private string _idNo;
        private string _address;
        private string _email;
        private byte[] _avatar;
        private int _idType;

        public AccountObject(string id, string name, DateTime dob,
            string gender, string phone, string idNo, string address, string email,
            byte[] avatar, int idType)
        {
            this.Id = id;
            this.Name = name;
            this.Dob = dob;
            this.Gender = gender;
            this.Phone = phone;
            this.IdNo = idNo;
            this.Address = address;
            this.Email = email;
            this.Avatar = avatar;
            this.IdType = idType;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Dob { get => _dob; set => _dob = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string IdNo { get => _idNo; set => _idNo = value; }
        public string Address { get => _address; set => _address = value; }
        public string Email { get => _email; set => _email = value; }
        public byte[] Avatar { get => _avatar; set => _avatar = value; }
        public int IdType { get => _idType; set => _idType = value; }
    }
}

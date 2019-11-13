using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace BookRoomManage
{
    public class Customer
    {
        #region property
        public Guid CustomerID { get; set; }

        public string CustomerNo { get; set; }

        public string CustomerName { get; set; }

        public DateTime Birthday { get; set; }

        public bool Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string IdentityCard { get; set; }

        public string Email { get; set; }

        public string Nationality { get; set; }
        #endregion

        #region constructor
        public Customer()
        {

        }


        public Customer(Guid customerID,string customerNo, string customerName, DateTime birthday, bool gender, string phoneNumber, string identityCard, string email, string nationality)
        {
            CustomerID = customerID;
            CustomerNo = customerNo;
            CustomerName = customerName;
            Birthday = birthday;
            Gender = gender;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
            Email = email;
            Nationality = nationality;
        }

        public Customer(string customerNo,string customerName,string phoneNumber, string identityCard)
        {
            CustomerID = Guid.NewGuid();
            CustomerNo = customerNo;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
        }

        public Customer(string customerNo, string customerName, DateTime birthday, bool gender, string phoneNumber, string identityCard, string email, string nationality)
        {
            CustomerID = Guid.NewGuid();
            CustomerNo = customerNo;
            CustomerName = customerName;
            Birthday = birthday;
            Gender = gender;
            PhoneNumber = phoneNumber;
            IdentityCard = identityCard;
            Email = email;
            Nationality = nationality;
        }
        #endregion

        #region method
        public DataTable GetCustomers()
        {
            return Provider.Instance.ExcuteQuery("PROC_GetCustomers");
        } 

        /// <summary>
        /// Thêm mới Khách hàng
        /// </summary>
        public int InsertCustomer()
        {
            int result = Provider.Instance.ExcuteNonQuery("PROC_InsertCustomer", this);
            return result;
        }

        /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        public int UpdateCustomer()
        {
            int result = Provider.Instance.ExcuteNonQuery("PROC_UpdateCustomer", this);
            return result;
        }

        /// <summary>
        /// Tìm kiếm khách hàng theo số CMT
        /// </summary>
        /// <returns>Thông tin chi tiết khách hàng</returns>
        public Customer FindCustomer()
        {
            Customer customer=null;
            return customer;
        }
        #endregion
    }
}

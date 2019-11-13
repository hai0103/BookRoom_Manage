using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRoomManage
{
    public class BookRoom
    {
        #region property
        public Guid BookRoomID { get; set; }

        public string BookRoomNo { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Deposit { get; set; }

        public Guid? RoomID { get; set; }

        public Guid? CustomerID { get; set; }

        public Guid? EmployeeID { get; set; }
        #endregion

        #region constructor
        public BookRoom()
        {

        }

        public BookRoom(string bookRoomNo, DateTime createDate, DateTime startDate, DateTime endDate, decimal deposit,Guid roomID,Guid employeeID)
        {
            BookRoomID = Guid.NewGuid();
            BookRoomNo = bookRoomNo;
            CreateDate = createDate;
            StartDate = startDate;
            EndDate = endDate;
            Deposit = deposit;
            RoomID = roomID;
            CustomerID = null;
            EmployeeID = employeeID;

        }

        public BookRoom(string bookRoomNo,DateTime createDate,DateTime startDate,DateTime endDate,decimal deposit,Guid roomID,Guid? customerId,Guid? employeeID)
        {
            BookRoomID = Guid.NewGuid();
            BookRoomNo = bookRoomNo;
            CreateDate = createDate;
            StartDate = startDate;
            EndDate = endDate;
            Deposit = deposit;
            RoomID = roomID;
            CustomerID = customerId;
            EmployeeID = employeeID;
        }
        #endregion

        #region method

        public int Insert()
        {
            int result = Provider.Instance.ExcuteNonQuery("PROC_InsertBookRoom", this);
            return result;
        }

        public decimal CalculateDeposit(DateTime startDate, DateTime endDate)
        {

            int noDays = (endDate - startDate).Days;
            //return; 
        }
        #endregion
    }
}

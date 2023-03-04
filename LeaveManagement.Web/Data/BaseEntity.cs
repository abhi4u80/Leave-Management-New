namespace LeaveManagement.Web.Data
{
    public partial class BaseEntity
    {
        public int id { get; set; }
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}

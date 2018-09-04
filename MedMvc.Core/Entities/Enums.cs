
namespace MedMvc.Core.Entities
{
    public enum Gender
    {
        Unspecified,
        Male,
        Female
    }

    public enum TicketType
    {
        Inbound,
        Outbound
    }

    public enum TicketStatus
    {
        Transfer,
        Dispatch,
        Reject
    }

    public enum Role
    {
        CallCenterExecutive,
        DispatcherExecutive,
        Manager,
        Admin,
        SuperAdmin
    }
}

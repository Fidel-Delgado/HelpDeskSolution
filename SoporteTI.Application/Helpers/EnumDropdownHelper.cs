using SoporteTI.Domain.Enums;

namespace SoporteTI.Application.Helpers
{
    public static class EnumDropdownHelper
    {
        public static List<EnumListItem> GetStatusTicket()
        {
            return Enum.GetValues(typeof(StatusTicket))
                       .Cast<StatusTicket>()
                       .Select(e => new EnumListItem
                       {
                           Value = ((int)e).ToString(),
                           Text = e.ToString()
                       }).ToList();
        }

        public static EnumListItem GetStatusTicketbyId(string id)
        {
            return Enum.GetValues(typeof(StatusTicket))
                       .Cast<StatusTicket>()
                       .Select(e => new EnumListItem
                       {
                           Value = ((int)e).ToString(),
                           Text = e.ToString()
                       })
                       .FirstOrDefault(x => x.Value == id);
        }

        public static List<EnumListItem> GetImpactTicket()
        {
            return Enum.GetValues(typeof(ImpactTicket))
                       .Cast<ImpactTicket>()
                       .Select(e => new EnumListItem
                       {
                           Value = ((int)e).ToString(),
                           Text = e.ToString()
                       }).ToList();
        }
        public static EnumListItem GetImpactTicketbyId(string id)
        {
            return Enum.GetValues(typeof(ImpactTicket))
                       .Cast<ImpactTicket>()
                       .Select(e => new EnumListItem
                       {
                           Value = ((int)e).ToString(),
                           Text = e.ToString()
                       }).FirstOrDefault(x => x.Value == id);
        }

        public static List<EnumListItem> GetPriorityTicket()
        {
            return Enum.GetValues(typeof(PriorityTicket))
                       .Cast<PriorityTicket>()
                       .Select(e => new EnumListItem
                       {
                           Value = ((int)e).ToString(),
                           Text = e.ToString()
                       }).ToList();
        }
        public static EnumListItem GetPriorityTicketbyId(string id)
        {
            return Enum.GetValues(typeof(PriorityTicket))
                       .Cast<PriorityTicket>()
                       .Select(e => new EnumListItem
                       {
                           Value = ((int)e).ToString(),
                           Text = e.ToString()
                       }).FirstOrDefault(x => x.Value == id);
        }
    }
}

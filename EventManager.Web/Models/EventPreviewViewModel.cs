﻿using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
    public class EventPreviewViewModel
    {
        private Dictionary<Status, Color> colorByStatus = new Dictionary<Status, Color>
        {
            { Status.Upcoming, Color.success },
            { Status.Inactive, Color.light },
            { Status.Cancelled, Color.danger },
            { Status.BookedOut, Color.dark }
        };

        public EventPreviewViewModel(String name, String dateRange, String timeRange, String excerpt, Status status, decimal lowestPrice, String image)
        {
            bool isUpcoming = (status == Status.Upcoming);

            this.Name = name;
            this.DateRange = dateRange;
            this.TimeRange = timeRange;
            this.Excerpt = excerpt;
            this.EventStatus = status.ToString();
            this.UIColor = colorByStatus[status].ToString();
            this.LowestPrice = lowestPrice.ToString();
            this.ButtonText = isUpcoming ? "View Event" : this.EventStatus;
            this.Image = string.Format("/images/{0}", image);
        }

        public String Name { get; }
        public String DateRange { get; }
        public String TimeRange { get; }
        public String Excerpt { get; }
        public String EventStatus { get; }
        public String UIColor { get; }
        public String ButtonText { get; }
        public String LowestPrice { get; }
        public String Image { get; }

    }
}

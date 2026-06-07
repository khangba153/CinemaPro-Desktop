using System;

namespace CinemaPro.WinForms.DesignFirst.ViewModels
{
    public sealed class TodayShowtimeViewModel
    {
        public string ShowtimeId { get; set; } = "";
        public string ShowtimeCode { get; set; } = "";
        public string MovieCode { get; set; } = "";
        public string MovieTitle { get; set; } = "";
        public string RoomCode { get; set; } = "";
        public string RoomName { get; set; } = "";
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public decimal Price { get; set; }
        public string Format { get; set; } = "";
        public string Status { get; set; } = "";
        public int SoldSeatCount { get; set; }

        public string TimeText => $"{StartTime:hh\\:mm} - {EndTime:hh\\:mm}";
        public string DisplayText => $"{TimeText} | {RoomName} | {Format} ({SoldSeatCount} ghế đã bán)";
    }
}
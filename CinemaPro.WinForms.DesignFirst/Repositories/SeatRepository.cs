namespace CinemaPro.WinForms.DesignFirst.Repositories;

public sealed class SeatRepository
{
    public void UpdateSeatStatus(int roomId, string seatCode, string status)
    {
        const string sql = """
            UPDATE dbo.Seats
            SET SeatStatus = @SeatStatus
            WHERE RoomId = @RoomId
                AND SeatCode = @SeatCode;
            """;

        DatabaseHelper.ExecuteNonQuery(
            sql,
            new SqlParameter("@RoomId", roomId),
            new SqlParameter("@SeatCode", seatCode),
            new SqlParameter("@SeatStatus", status));
    }
}
